using Labor.Enums;
using Microsoft.Toolkit.Uwp.Notifications;
using System;

namespace Labor.Manager
{
    public static class ToastManager
    {
        private static ToastContentBuilder GetToast(string id, ToastGroupType group, string title, string content)
        {
            return new ToastContentBuilder()
                .AddButton(new ToastButton()
                .SetContent("查看详情")
                .AddArgument("action", ToastActionType.Click)
                .SetBackgroundActivation())
                .AddButton(new ToastButton()
                .SetContent("稍后提醒")
                .AddArgument("action", ToastActionType.RemindLater)
                .SetBackgroundActivation())
                .SetToastScenario(ToastScenario.Default)
                .AddArgument("action", "Delete")
                .AddArgument("contentId", id)
                .AddArgument("contentGroup", group)
                .AddText(title)
                .AddText(content)
                .SetBackgroundActivation();
        }

        public static void Send(string id, ToastGroupType group, string title, string content, bool isShow)
        {
            if (isShow)
            {
                GetToast(id, group, title, content).Show(t =>
                 {
                     t.Tag = id;
                     t.Group = group.ToString();
                 });
            }
            else
            {
                GetToast(id, group, title, content).Schedule(DateTime.Now.AddMinutes(15), t =>
                 {
                     t.Tag = id;
                     t.Group = group.ToString();
                 });
            }
        }

        public static void Remove(string id, ToastGroupType group)
        {
            ToastNotificationManagerCompat.History.Remove(id, group.ToString());
        }

        public static void Clear()
        {
            ToastNotificationManagerCompat.Uninstall();
        }
    }
}
