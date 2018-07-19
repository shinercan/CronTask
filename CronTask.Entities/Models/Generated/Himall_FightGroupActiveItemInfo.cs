
//-----------------------------------------------------------------------
// <copyright file=" Himall_FightGroupActiveItem.cs" company="xxxx Enterprises">
// * Copyright (C) 2018YW Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: Himall_FightGroupActiveItem.cs
// * history : Created by T4 07/19/2018 09:12:09 
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace CronTask.Entities
{
    /// <summary>
    /// Himall_FightGroupActiveItem Entity Model
    /// </summary>    
    [Serializable]
    public partial class Himall_FightGroupActiveItemInfo
    {
        /// <summary>
        /// 编号
        /// </summary>

        public bigint Id { get; set; }
    
        /// <summary>
        /// 所属活动
        /// </summary>
        public bigint ActiveId { get; set; }
    
        /// <summary>
        /// 商品编号
        /// </summary>
        public bigint ProductId { get; set; }
    
        /// <summary>
        /// 商品SKU
        /// </summary>
        public string SkuId { get; set; }
    
        /// <summary>
        /// 活动售价
        /// </summary>
        public decimal ActivePrice { get; set; }
    
        /// <summary>
        /// 活动库存
        /// </summary>
        public bigint ActiveStock { get; set; }
    
        /// <summary>
        /// 己售
        /// </summary>
        public int BuyCount { get; set; }

    }
}