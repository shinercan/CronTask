
//-----------------------------------------------------------------------
// <copyright file=" Himall_SegmentWords.cs" company="xxxx Enterprises">
// * Copyright (C) 2018YW Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: Himall_SegmentWords.cs
// * history : Created by T4 07/19/2018 09:12:09 
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace CronTask.Entities
{
    /// <summary>
    /// Himall_SegmentWords Entity Model
    /// </summary>    
    [Serializable]
    public partial class Himall_SegmentWordsInfo
    {
        /// <summary>
        /// 
        /// </summary>

        public bigint Id { get; set; }
    
        /// <summary>
        /// 分词
        /// </summary>
        public string Word { get; set; }

    }
}
