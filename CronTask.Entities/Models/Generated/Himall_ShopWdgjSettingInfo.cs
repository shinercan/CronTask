
//-----------------------------------------------------------------------
// <copyright file=" Himall_ShopWdgjSetting.cs" company="xxxx Enterprises">
// * Copyright (C) 2018YW Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: Himall_ShopWdgjSetting.cs
// * history : Created by T4 07/19/2018 09:12:09 
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace CronTask.Entities
{
    /// <summary>
    /// Himall_ShopWdgjSetting Entity Model
    /// </summary>    
    [Serializable]
    public partial class Himall_ShopWdgjSettingInfo
    {
        /// <summary>
        /// 主键
        /// </summary>

        public bigint Id { get; set; }
    
        /// <summary>
        /// 店铺Id
        /// </summary>
        public bigint ShopId { get; set; }
    
        /// <summary>
        /// 接入码
        /// </summary>
        public string uCode { get; set; }
    
        /// <summary>
        /// 效验码
        /// </summary>
        public string uSign { get; set; }
    
        /// <summary>
        /// 是否开启
        /// </summary>
        public int IsEnable { get; set; }

    }
}
