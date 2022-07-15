namespace Labor.Enums
{
    public enum IssueStatusEnum
    {
        /// <summary>
        /// 未开始
        /// </summary>
        NotStart = 1,

        /// <summary>
        /// 进行中
        /// </summary>
        Doing = 2,

        /// <summary>
        /// 已解决
        /// </summary>
        Fixed = 3,

        /// <summary>
        /// 待改进
        /// </summary>
        NeedFixed = 4,

        /// <summary>
        /// 已中止
        /// </summary>
        Stopped = 6,

        /// <summary>
        /// 评定中
        /// </summary>
        UnderEvaluation = 8,

        /// <summary>
        /// 已关闭
        /// </summary>
        Closed = 9,

        /// <summary>
        /// 设计如此
        /// </summary>
        Designed = 14,

        /// <summary>
        /// 开发完成
        /// </summary>
        Done = 15,

        /// <summary>
        /// 已评定
        /// </summary>
        Assessed = 16,
    }
}
