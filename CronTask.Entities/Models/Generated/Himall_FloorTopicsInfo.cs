
//-----------------------------------------------------------------------
// <copyright file=" Himall_FloorTopics.cs" company="xxxx Enterprises">
// * Copyright (C) 2018YW Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: Himall_FloorTopics.cs
// * history : Created by T4 07/19/2018 09:12:09 
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace CronTask.Entities
{
    /// <summary>
    /// Himall_FloorTopics Entity Model
    /// </summary>    
    [Serializable]
    public partial class Himall_FloorTopicsInfo
    {
        /// <summary>
        /// 
        /// </summary>

        public bigint Id { get; set; }
    
        /// <summary>
        /// 楼层ID
        /// </summary>
        public bigint FloorId { get; set; }
    
        /// <summary>
        /// 专题类型
        /// </summary>
        public int TopicType { get; set; }
    
        /// <summary>
        /// 专题封面图片
        /// </summary>
        public string TopicImage { get; set; }
    
        /// <summary>
        /// 专题名称
        /// </summary>
        public string TopicName { get; set; }
    
        /// <summary>
        /// 专题跳转URL
        /// </summary>
        public string Url { get; set; }

    }
}
