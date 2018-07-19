
//-----------------------------------------------------------------------
// <copyright file=" Himall_MarketSetting.cs" company="xxxx Enterprises">
// * Copyright (C) 2018YW Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: Himall_MarketSetting.cs
// * history : Created by T4 07/19/2018 09:12:09 
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace CronTask.Entities
{
    /// <summary>
    /// Himall_MarketSetting Entity Model
    /// </summary>    
    [Serializable]
    public partial class Himall_MarketSettingInfo
    {
        /// <summary>
        /// 
        /// </summary>

        public int Id { get; set; }
    
        /// <summary>
        /// 营销类型ID
        /// </summary>
        public int TypeId { get; set; }
    
        /// <summary>
        /// 营销使用价格（/月）
        /// </summary>
        public decimal Price { get; set; }

    }
}