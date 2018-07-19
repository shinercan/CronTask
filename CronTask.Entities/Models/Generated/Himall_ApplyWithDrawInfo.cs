
//-----------------------------------------------------------------------
// <copyright file=" Himall_ApplyWithDraw.cs" company="xxxx Enterprises">
// * Copyright (C) 2018YW Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: Himall_ApplyWithDraw.cs
// * history : Created by T4 07/19/2018 09:12:09 
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace CronTask.Entities
{
    /// <summary>
    /// Himall_ApplyWithDraw Entity Model
    /// </summary>    
    [Serializable]
    public partial class Himall_ApplyWithDrawInfo
    {
        /// <summary>
        /// 
        /// </summary>

        public bigint Id { get; set; }
    
        /// <summary>
        /// 会员ID
        /// </summary>
        public bigint MemId { get; set; }
    
        /// <summary>
        /// 微信昵称
        /// </summary>
        public string NickName { get; set; }
    
        /// <summary>
        /// OpenId
        /// </summary>
        public string OpenId { get; set; }
    
        /// <summary>
        /// 申请状态
        /// </summary>
        public int ApplyStatus { get; set; }
    
        /// <summary>
        /// 提现金额
        /// </summary>
        public decimal ApplyAmount { get; set; }
    
        /// <summary>
        /// 申请时间
        /// </summary>
        public DateTime ApplyTime { get; set; }
    
        /// <summary>
        /// 处理时间
        /// </summary>
        public DateTime ConfirmTime { get; set; }
    
        /// <summary>
        /// 付款时间
        /// </summary>
        public DateTime PayTime { get; set; }
    
        /// <summary>
        /// 付款流水号
        /// </summary>
        public string PayNo { get; set; }
    
        /// <summary>
        /// 操作人
        /// </summary>
        public string OpUser { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    
        /// <summary>
        /// 提现方式
        /// </summary>
        public int ApplyType { get; set; }
    
        /// <summary>
        /// 手续费
        /// </summary>
        public decimal Poundage { get; set; }

    }
}
