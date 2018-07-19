
//-----------------------------------------------------------------------
// <copyright file=" Himall_CollocationSkus.cs" company="xxxx Enterprises">
// * Copyright (C) 2018YW Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: Himall_CollocationSkus.cs
// * history : Created by T4 07/19/2018 09:12:09 
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace CronTask.Entities
{
    /// <summary>
    /// Himall_CollocationSkus Entity Model
    /// </summary>    
    [Serializable]
    public partial class Himall_CollocationSkusInfo
    {
        /// <summary>
        /// ID自增
        /// </summary>

        public bigint Id { get; set; }
    
        /// <summary>
        /// 商品ID
        /// </summary>
        public bigint ProductId { get; set; }
    
        /// <summary>
        /// 商品SkuId
        /// </summary>
        public string SkuID { get; set; }
    
        /// <summary>
        /// 组合商品表ID
        /// </summary>
        public bigint ColloProductId { get; set; }
    
        /// <summary>
        /// 组合购价格
        /// </summary>
        public decimal Price { get; set; }
    
        /// <summary>
        /// 原始价格
        /// </summary>
        public decimal SkuPirce { get; set; }

    }
}