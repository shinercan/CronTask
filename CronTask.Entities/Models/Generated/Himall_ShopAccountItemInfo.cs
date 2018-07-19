
//-----------------------------------------------------------------------
// <copyright file=" Himall_ShopAccountItem.cs" company="xxxx Enterprises">
// * Copyright (C) 2018YW Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: Himall_ShopAccountItem.cs
// * history : Created by T4 07/19/2018 09:12:09 
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace CronTask.Entities
{
    /// <summary>
    /// Himall_ShopAccountItem Entity Model
    /// </summary>    
    [Serializable]
    public partial class Himall_ShopAccountItemInfo
    {
        /// <summary>
        /// 编号
        /// </summary>

        public bigint Id { get; set; }
    
        /// <summary>
        /// 店铺ID
        /// </summary>
        public bigint ShopId { get; set; }
    
        /// <summary>
        /// 店铺名称
        /// </summary>
        public string ShopName { get; set; }
    
        /// <summary>
        /// 交易流水号
        /// </summary>
        public string AccountNo { get; set; }
    
        /// <summary>
        /// 关联资金编号
        /// </summary>
        public bigint AccoutID { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
    
        /// <summary>
        /// 金额
        /// </summary>
        public decimal Amount { get; set; }
    
        /// <summary>
        /// 帐户剩余
        /// </summary>
        public decimal Balance { get; set; }
    
        /// <summary>
        /// 交易类型
        /// </summary>
        public int TradeType { get; set; }
    
        /// <summary>
        /// 是否收入
        /// </summary>
        public bool IsIncome { get; set; }
    
        /// <summary>
        /// 交易备注
        /// </summary>
        public string ReMark { get; set; }
    
        /// <summary>
        /// 详情ID
        /// </summary>
        public string DetailId { get; set; }
    
        /// <summary>
        /// 结算周期(以天为单位)(冗余字段)
        /// </summary>
        public int SettlementCycle { get; set; }

    }
}
