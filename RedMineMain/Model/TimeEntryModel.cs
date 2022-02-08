using System;

namespace RedMineEditer.Model
{
    public class TimeEntryModel : ICloneable
    {
        /// <summary>
        /// 工时Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 项目名
        /// </summary>
        public string ProjectName { get; set; }

        /// <summary>
        /// 任务Id
        /// </summary>
        public int SubjectId { get; set; }

        /// <summary>
        /// 任务名
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string Comments { get; set; }

        /// <summary>
        /// 百分比
        /// </summary>
        public float? Percent { get; set; }

        /// <summary>
        /// 耗时
        /// </summary>
        public decimal Hours { get; set; }

        /// <summary>
        /// 是否是临时任务
        /// </summary>
        public bool IsTemp { get; set; }

        public object Clone() => new TimeEntryModel()
        {
            Comments = Comments,
            Hours = Hours,
            Id = Id,
            IsTemp = IsTemp,
            Percent = Percent,
            ProjectName = ProjectName,
            Subject = Subject,
            SubjectId = SubjectId
        };
    }
}
