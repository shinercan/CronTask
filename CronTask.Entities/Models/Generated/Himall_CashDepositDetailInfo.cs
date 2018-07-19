
//-----------------------------------------------------------------------
// <copyright file=" Himall_CashDepositDetail.cs" company="xxxx Enterprises">
// * Copyright (C) 2018YW Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: Himall_CashDepositDetail.cs
// * history : Created by T4 07/19/2018 09:12:09 
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace CronTask.Entities
{
    /// <summary>
    /// Himall_CashDepositDetail Entity Model
    /// </summary>    
    [Serializable]
    public partial class Himall_CashDepositDetailInfo
    {
        /// <summary>
        /// 
        /// </summary>

        public bigint Id { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public bigint CashDepositId { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public DateTime AddDate { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public decimal Balance { get; set; }
    
        /// <summary>
        /// 操作类型
        /// </summary>
        public string Operator { get; set; }
    
        /// <summary>
        /// 说明
        /// </summary>
        public string Description { get; set; }
    
        /// <summary>
        /// 充值类型（银联、支付宝之类的）
        /// </summary>
        public int RechargeWay { get; set; }

    }
}
