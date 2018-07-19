
//-----------------------------------------------------------------------
// <copyright file=" Himall_WXAppletFormDatas.cs" company="xxxx Enterprises">
// * Copyright (C) 2018YW Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: Himall_WXAppletFormDatas.cs
// * history : Created by T4 07/19/2018 09:12:09 
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace CronTask.Entities
{
    /// <summary>
    /// Himall_WXAppletFormDatas Entity Model
    /// </summary>    
    [Serializable]
    public partial class Himall_WXAppletFormDatasInfo
    {
        /// <summary>
        /// 
        /// </summary>

        public bigint Id { get; set; }
    
        /// <summary>
        /// 事件ID
        /// </summary>
        public bigint EventId { get; set; }
    
        /// <summary>
        /// 事件值
        /// </summary>
        public string EventValue { get; set; }
    
        /// <summary>
        /// 事件的表单ID
        /// </summary>
        public string FormId { get; set; }
    
        /// <summary>
        /// 事件时间
        /// </summary>
        public DateTime EventTime { get; set; }
    
        /// <summary>
        /// FormId过期时间
        /// </summary>
        public DateTime ExpireTime { get; set; }

    }
}
