
//-----------------------------------------------------------------------
// <copyright file=" Himall_OrderComments.cs" company="xxxx Enterprises">
// * Copyright (C) 2018YW Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: Himall_OrderComments.cs
// * history : Created by T4 07/19/2018 09:12:09 
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace CronTask.Entities
{
    /// <summary>
    /// Himall_OrderComments Entity Model
    /// </summary>    
    [Serializable]
    public partial class Himall_OrderCommentsInfo
    {
        /// <summary>
        /// 
        /// </summary>

        public bigint Id { get; set; }
    
        /// <summary>
        /// 订单ID
        /// </summary>
        public bigint OrderId { get; set; }
    
        /// <summary>
        /// 店铺ID
        /// </summary>
        public bigint ShopId { get; set; }
    
        /// <summary>
        /// 店铺名称
        /// </summary>
        public string ShopName { get; set; }
    
        /// <summary>
        /// 用户ID
        /// </summary>
        public bigint UserId { get; set; }
    
        /// <summary>
        /// 用户名称
        /// </summary>
        public string UserName { get; set; }
    
        /// <summary>
        /// 评价日期
        /// </summary>
        public DateTime CommentDate { get; set; }
    
        /// <summary>
        /// 包装评分
        /// </summary>
        public int PackMark { get; set; }
    
        /// <summary>
        /// 物流评分
        /// </summary>
        public int DeliveryMark { get; set; }
    
        /// <summary>
        /// 服务评分
        /// </summary>
        public int ServiceMark { get; set; }

    }
}
