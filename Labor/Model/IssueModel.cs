﻿using Labor.Enums;

namespace Labor.Model
{
    /// <summary>
    /// 任务模型
    /// </summary>
    public class IssueModel
    {

        /// <summary>
        /// 主键
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 作者Id
        /// </summary>
        public int AuthorId { get; set; }

        /// <summary>
        /// 任务类型
        /// </summary>
        public TrackerTypeEnum TrackerType { get; set; }

        /// <summary>
        /// 项目名
        /// </summary>
        public string ProjectName { get; set; }

        /// <summary>
        /// 任务名
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 百分比
        /// </summary>
        public float? DoneRatio { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// 按钮提示文本
        /// </summary>
        public string ButtonName { get; set; }


        public object Clone() => new IssueModel()
        {
            Id = Id,
            Notes = Notes,
            DoneRatio = DoneRatio,
            Description = Description,
            ProjectName = ProjectName,
            Subject = Subject,
        };
    }
}
