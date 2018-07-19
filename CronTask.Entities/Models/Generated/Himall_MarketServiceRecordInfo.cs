
//-----------------------------------------------------------------------
// <copyright file=" Himall_MarketServiceRecord.cs" company="xxxx Enterprises">
// * Copyright (C) 2018YW Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: Himall_MarketServiceRecord.cs
// * history : Created by T4 07/19/2018 09:12:09 
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace CronTask.Entities
{
    /// <summary>
    /// Himall_MarketServiceRecord Entity Model
    /// </summary>    
    [Serializable]
    public partial class Himall_MarketServiceRecordInfo
    {
        /// <summary>
        /// 
        /// </summary>

        public bigint Id { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public bigint MarketServiceId { get; set; }
    
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime StartTime { get; set; }
    
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime EndTime { get; set; }
    
        /// <summary>
        /// 购买时间
        /// </summary>
        public DateTime BuyTime { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public int SettlementFlag { get; set; }
    
        /// <summary>
        /// 服务购买价格
        /// </summary>
        public decimal Price { get; set; }

    }
}