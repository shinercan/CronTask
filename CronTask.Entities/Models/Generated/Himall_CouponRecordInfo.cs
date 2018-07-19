
//-----------------------------------------------------------------------
// <copyright file=" Himall_CouponRecord.cs" company="xxxx Enterprises">
// * Copyright (C) 2018YW Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: Himall_CouponRecord.cs
// * history : Created by T4 07/19/2018 09:12:09 
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace CronTask.Entities
{
    /// <summary>
    /// Himall_CouponRecord Entity Model
    /// </summary>    
    [Serializable]
    public partial class Himall_CouponRecordInfo
    {
        /// <summary>
        /// 
        /// </summary>

        public bigint Id { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public bigint CouponId { get; set; }
    
        /// <summary>
        /// 优惠券的SN标示
        /// </summary>
        public string CounponSN { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public DateTime CounponTime { get; set; }
    
        /// <summary>
        /// 用户名称
        /// </summary>
        public string UserName { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public bigint UserId { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public DateTime UsedTime { get; set; }
    
        /// <summary>
        /// 使用的订单ID
        /// </summary>
        public bigint OrderId { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public bigint ShopId { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public string ShopName { get; set; }
    
        /// <summary>
        /// 优惠券状态
        /// </summary>
        public int CounponStatus { get; set; }
    
        /// <summary>
        /// 微信Code记录号 与微信卡券投放记录关联
        /// </summary>
        public bigint WXCodeId { get; set; }

    }
}