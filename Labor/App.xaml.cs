using Labor.CustomException;
using Labor.Model;
using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Windows;
using System.Windows.Threading;

namespace Labor
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        MainWindow _mainWindow;

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            _mainWindow = Current.Windows.Cast<Window>().FirstOrDefault(window => window is MainWindow) as MainWindow;
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            Application.Current.DispatcherUnhandledException += Application_DispatcherUnhandledException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            ToastNotificationManagerCompat.OnActivated += ToastNotificationManagerCompat_OnActivated;
            base.OnStartup(e);
        }

        private void ToastNotificationManagerCompat_OnActivated(ToastNotificationActivatedEventArgsCompat e)
        {
            // Parse the arguments
            var args = ToastArguments.Parse(e.Argument);

            Application.Current.Dispatcher.Invoke(delegate
            {
                if (args.Count == 0)
                {
                    OpenWindowIfNeeded();
                    return;
                }

                // See what action is being requested 
                switch (args["action"])
                {
                    // Open the image
                    case "viewImage":

                        // The URL retrieved from the toast args
                        string imageUrl = args["imageUrl"];

                        // Make sure we have a window open and in foreground
                        OpenWindowIfNeeded();

                        // And then show the image
                        (App.Current.Windows[0] as MainWindow).ShowImage(imageUrl);

                        break;

                    // Open the conversation
                    case "viewConversation":

                        // The conversation ID retrieved from the toast args
                        int conversationId = int.Parse(args["conversationId"]);

                        // Make sure we have a window open and in foreground
                        OpenWindowIfNeeded();

                        // And then show the conversation
                        (App.Current.Windows[0] as MainWindow).ShowConversation();

                        break;

                    // Background: Quick reply to the conversation
                    case "reply":

                        // Get the response the user typed
                        string msg = e.UserInput["tbReply"] as string;

                        // And send this message
                        ShowToast("Sending message: " + msg);

                        // If there's no windows open, exit the app
                        if (App.Current.Windows.Count == 0)
                        {
                            Application.Current.Shutdown();
                        }

                        break;

                    // Background: Send a like
                    case "like":

                        ShowToast("Sending like");

                        // If there's no windows open, exit the app
                        if (App.Current.Windows.Count == 0)
                        {
                            Application.Current.Shutdown();
                        }

                        break;

                    default:

                        OpenWindowIfNeeded();

                        break;
                }
            });
        }

        private void OpenWindowIfNeeded()
        {
            // Make sure we have a window open (in case user clicked toast while app closed)
            if (App.Current.Windows.Count == 0)
            {
                new MainWindow().Show();
            }

            // Activate the window, bringing it to focus
            App.Current.Windows[0].Activate();

            // And make sure to maximize the window too, in case it was currently minimized
            App.Current.Windows[0].WindowState = WindowState.Normal;
        }

        private void ShowToast(string msg)
        {
            // Send the toast
            new ToastContentBuilder()
                .AddArgument("action", "ok")
                .AddText(msg)
                .Show();
        }

        void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = e.ExceptionObject as Exception;
            MessageBox.Show(string.Format("捕获到非WPF窗体线程异常：{0}\r\n异常信息：{1}\r\n异常堆栈：{2}", ex.GetType(), ex.Message, ex.StackTrace));
        }

        private void Application_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            if (e.Exception.GetType() == new NotLoginException().GetType())
            {
                try
                {
                    Client.Init();
                    _mainWindow.Logout();
                }
                catch (NotLoginException)
                {
                    _mainWindow.Logout();
                }
                catch (Exception)
                {
                    Application_DispatcherUnhandledException(sender, e);
                }
                return;
            }
            else if (e.Exception.GetType() == new WebException().GetType()
                || e.Exception.GetType() == new SocketException().GetType())
            {
                if (DebugData.CurrentRequestCount > 0)
                {
                    DebugData.CurrentRequestCount--;
                }
                return;
            }
            Exception ex = e.Exception;
            MessageBox.Show(string.Format("捕获到未处理异常：{0}\r\n异常信息：{1}\r\n异常堆栈：{2}", ex.GetType(), ex.Message, ex.StackTrace));
        }
    }
}
