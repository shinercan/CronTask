
//-----------------------------------------------------------------------
// <copyright file=" Himall_IntegralMallAds.cs" company="xxxx Enterprises">
// * Copyright (C) 2018YW Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: Himall_IntegralMallAds.cs
// * history : Created by T4 07/19/2018 09:12:09 
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace CronTask.Entities
{
    /// <summary>
    /// Himall_IntegralMallAds Entity Model
    /// </summary>    
    [Serializable]
    public partial class Himall_IntegralMallAdsInfo
    {
        /// <summary>
        /// 
        /// </summary>

        public bigint Id { get; set; }
    
        /// <summary>
        /// 活动类型
        /// </summary>
        public int ActivityType { get; set; }
    
        /// <summary>
        /// 活动编号
        /// </summary>
        public bigint ActivityId { get; set; }
    
        /// <summary>
        /// 显示图片
        /// </summary>
        public string Cover { get; set; }
    
        /// <summary>
        /// 显示状态
        /// </summary>
        public int ShowStatus { get; set; }
    
        /// <summary>
        /// 显示平台
        /// </summary>
        public int ShowPlatform { get; set; }

    }
}
