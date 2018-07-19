
//-----------------------------------------------------------------------
// <copyright file=" Himall_ReceivingAddressConfig.cs" company="xxxx Enterprises">
// * Copyright (C) 2018YW Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: Himall_ReceivingAddressConfig.cs
// * history : Created by T4 07/19/2018 09:12:09 
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace CronTask.Entities
{
    /// <summary>
    /// Himall_ReceivingAddressConfig Entity Model
    /// </summary>    
    [Serializable]
    public partial class Himall_ReceivingAddressConfigInfo
    {
        /// <summary>
        /// 
        /// </summary>

        public bigint Id { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public string AddressId_City { get; set; }
    
        /// <summary>
        /// 逗号分隔
        /// </summary>
        public string AddressId { get; set; }
    
        /// <summary>
        /// 预留字段，防止将来其他商家一并支持货到付款
        /// </summary>
        public bigint ShopId { get; set; }

    }
}