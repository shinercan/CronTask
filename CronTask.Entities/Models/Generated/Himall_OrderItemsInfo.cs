
//-----------------------------------------------------------------------
// <copyright file=" Himall_OrderItems.cs" company="xxxx Enterprises">
// * Copyright (C) 2018YW Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: Himall_OrderItems.cs
// * history : Created by T4 07/19/2018 09:12:09 
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace CronTask.Entities
{
    /// <summary>
    /// Himall_OrderItems Entity Model
    /// </summary>    
    [Serializable]
    public partial class Himall_OrderItemsInfo
    {
        /// <summary>
        /// 主键
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
        /// 商品ID
        /// </summary>
        public bigint ProductId { get; set; }
    
        /// <summary>
        /// SKUId
        /// </summary>
        public string SkuId { get; set; }
    
        /// <summary>
        /// SKU表SKU字段
        /// </summary>
        public string SKU { get; set; }
    
        /// <summary>
        /// 购买数量
        /// </summary>
        public bigint Quantity { get; set; }
    
        /// <summary>
        /// 退货数量
        /// </summary>
        public bigint ReturnQuantity { get; set; }
    
        /// <summary>
        /// 成本价
        /// </summary>
        public decimal CostPrice { get; set; }
    
        /// <summary>
        /// 销售价
        /// </summary>
        public decimal SalePrice { get; set; }
    
        /// <summary>
        /// 优惠金额
        /// </summary>
        public decimal DiscountAmount { get; set; }
    
        /// <summary>
        /// 实际应付金额
        /// </summary>
        public decimal RealTotalPrice { get; set; }
    
        /// <summary>
        /// 退款价格
        /// </summary>
        public decimal RefundPrice { get; set; }
    
        /// <summary>
        /// 商品名称
        /// </summary>
        public string ProductName { get; set; }
    
        /// <summary>
        /// SKU颜色
        /// </summary>
        public string Color { get; set; }
    
        /// <summary>
        /// SKU尺寸
        /// </summary>
        public string Size { get; set; }
    
        /// <summary>
        /// SKU版本
        /// </summary>
        public string Version { get; set; }
    
        /// <summary>
        /// 缩略图
        /// </summary>
        public string ThumbnailsUrl { get; set; }
    
        /// <summary>
        /// 分佣比例
        /// </summary>
        public decimal CommisRate { get; set; }
    
        /// <summary>
        /// 可退金额
        /// </summary>
        public decimal EnabledRefundAmount { get; set; }
    
        /// <summary>
        /// 是否为限时购商品
        /// </summary>
        public int IsLimitBuy { get; set; }
    
        /// <summary>
        /// 分销比例
        /// </summary>
        public decimal DistributionRate { get; set; }
    
        /// <summary>
        /// 可退积分抵扣金额
        /// </summary>
        public decimal EnabledRefundIntegral { get; set; }
    
        /// <summary>
        /// 优惠券抵扣金额
        /// </summary>
        public decimal CouponDiscount { get; set; }
    
        /// <summary>
        /// 满额减平摊到订单项的金额
        /// </summary>
        public decimal FullDiscount { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public decimal CityAgentRate { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public decimal AreaAgentRate { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public decimal UserRefereeRate { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public decimal ShopRefereeRate { get; set; }
    
        /// <summary>
        /// 平台固定手续费比例
        /// </summary>
        public decimal PlatFixedRate { get; set; }
    
        /// <summary>
        /// 单个商品所需积分
        /// </summary>
        public int RequiredIntegral { get; set; }
    
        /// <summary>
        /// 购买商品获得的积分(退货用)
        /// </summary>
        public int ObtainIntegral { get; set; }
    
        /// <summary>
        /// 是否积分订单商品
        /// </summary>
        public int IsIntegralProductBuy { get; set; }

    }
}
