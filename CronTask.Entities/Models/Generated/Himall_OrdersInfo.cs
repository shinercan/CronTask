
//-----------------------------------------------------------------------
// <copyright file=" Himall_Orders.cs" company="xxxx Enterprises">
// * Copyright (C) 2018YW Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: Himall_Orders.cs
// * history : Created by T4 07/19/2018 09:12:09 
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace CronTask.Entities
{
    /// <summary>
    /// Himall_Orders Entity Model
    /// </summary>    
    [Serializable]
    public partial class Himall_OrdersInfo
    {
        /// <summary>
        /// 
        /// </summary>

        public bigint Id { get; set; }
    
        /// <summary>
        /// 订单状态 [Description("待付款")]WaitPay = 1,[Description("待发货")]WaitDelivery,[Description("待收货")]WaitReceiving,[Description("已关闭")]Close,[Description("已完成")]Finish
        /// </summary>
        public int OrderStatus { get; set; }
    
        /// <summary>
        /// 订单创建日期
        /// </summary>
        public DateTime OrderDate { get; set; }
    
        /// <summary>
        /// 关闭原因
        /// </summary>
        public string CloseReason { get; set; }
    
        /// <summary>
        /// 店铺ID
        /// </summary>
        public bigint ShopId { get; set; }
    
        /// <summary>
        /// 店铺名称
        /// </summary>
        public string ShopName { get; set; }
    
        /// <summary>
        /// 商家电话
        /// </summary>
        public string SellerPhone { get; set; }
    
        /// <summary>
        /// 商家发货地址
        /// </summary>
        public string SellerAddress { get; set; }
    
        /// <summary>
        /// 商家说明
        /// </summary>
        public string SellerRemark { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public int SellerRemarkFlag { get; set; }
    
        /// <summary>
        /// 会员ID
        /// </summary>
        public bigint UserId { get; set; }
    
        /// <summary>
        /// 会员名称
        /// </summary>
        public string UserName { get; set; }
    
        /// <summary>
        /// 会员留言
        /// </summary>
        public string UserRemark { get; set; }
    
        /// <summary>
        /// 收货人
        /// </summary>
        public string ShipTo { get; set; }
    
        /// <summary>
        /// 收货人电话
        /// </summary>
        public string CellPhone { get; set; }
    
        /// <summary>
        /// 收货人地址省份ID
        /// </summary>
        public int TopRegionId { get; set; }
    
        /// <summary>
        /// 收货人区域ID
        /// </summary>
        public int RegionId { get; set; }
    
        /// <summary>
        /// 全名的收货地址
        /// </summary>
        public string RegionFullName { get; set; }
    
        /// <summary>
        /// 收货具体街道信息
        /// </summary>
        public string Address { get; set; }
    
        /// <summary>
        /// 收货地址坐标
        /// </summary>
        public float ReceiveLongitude { get; set; }
    
        /// <summary>
        /// 收货地址坐标
        /// </summary>
        public float ReceiveLatitude { get; set; }
    
        /// <summary>
        /// 快递公司
        /// </summary>
        public string ExpressCompanyName { get; set; }
    
        /// <summary>
        /// 运费
        /// </summary>
        public decimal Freight { get; set; }
    
        /// <summary>
        /// 物流订单号
        /// </summary>
        public string ShipOrderNumber { get; set; }
    
        /// <summary>
        /// 发货日期
        /// </summary>
        public DateTime ShippingDate { get; set; }
    
        /// <summary>
        /// 是否打印快递单
        /// </summary>
        public int IsPrinted { get; set; }
    
        /// <summary>
        /// 付款类型名称
        /// </summary>
        public string PaymentTypeName { get; set; }
    
        /// <summary>
        /// 付款类型使用 插件名称
        /// </summary>
        public string PaymentTypeGateway { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public int PaymentType { get; set; }
    
        /// <summary>
        /// 支付接口返回的ID
        /// </summary>
        public string GatewayOrderId { get; set; }
    
        /// <summary>
        /// 付款注释
        /// </summary>
        public string PayRemark { get; set; }
    
        /// <summary>
        /// 付款日期
        /// </summary>
        public DateTime PayDate { get; set; }
    
        /// <summary>
        /// 发票类型
        /// </summary>
        public int InvoiceType { get; set; }
    
        /// <summary>
        /// 发票抬头
        /// </summary>
        public string InvoiceTitle { get; set; }
    
        /// <summary>
        /// 税号
        /// </summary>
        public string InvoiceCode { get; set; }
    
        /// <summary>
        /// 税钱，但是未使用
        /// </summary>
        public decimal Tax { get; set; }
    
        /// <summary>
        /// 完成订单日期
        /// </summary>
        public DateTime FinishDate { get; set; }
    
        /// <summary>
        /// 商品总金额
        /// </summary>
        public decimal ProductTotalAmount { get; set; }
    
        /// <summary>
        /// 退款金额
        /// </summary>
        public decimal RefundTotalAmount { get; set; }
    
        /// <summary>
        /// 佣金总金额
        /// </summary>
        public decimal CommisTotalAmount { get; set; }
    
        /// <summary>
        /// 退还佣金总金额
        /// </summary>
        public decimal RefundCommisAmount { get; set; }
    
        /// <summary>
        /// 未使用
        /// </summary>
        public int ActiveType { get; set; }
    
        /// <summary>
        /// 来自哪个终端的订单
        /// </summary>
        public int Platform { get; set; }
    
        /// <summary>
        /// 针对该订单的优惠金额（用于优惠券）
        /// </summary>
        public decimal DiscountAmount { get; set; }
    
        /// <summary>
        /// 积分优惠金额
        /// </summary>
        public decimal IntegralDiscount { get; set; }
    
        /// <summary>
        /// 发票明细
        /// </summary>
        public string InvoiceContext { get; set; }
    
        /// <summary>
        /// 订单类型
        /// </summary>
        public int OrderType { get; set; }
    
        /// <summary>
        /// 分销员Id
        /// </summary>
        public bigint ShareUserId { get; set; }
    
        /// <summary>
        /// 订单备注(买家留言)
        /// </summary>
        public string OrderRemarks { get; set; }
    
        /// <summary>
        /// 最后操作时间
        /// </summary>
        public DateTime LastModifyTime { get; set; }
    
        /// <summary>
        /// 发货类型(快递配送,到店自提)
        /// </summary>
        public int DeliveryType { get; set; }
    
        /// <summary>
        /// 门店ID
        /// </summary>
        public bigint ShopBranchId { get; set; }
    
        /// <summary>
        /// 提货码
        /// </summary>
        public string PickupCode { get; set; }
    
        /// <summary>
        /// 提货时间
        /// </summary>
        public DateTime PickupTime { get; set; }
    
        /// <summary>
        /// 订单实付金额
        /// </summary>
        public decimal TotalAmount { get; set; }
    
        /// <summary>
        /// 订单实收金额
        /// </summary>
        public decimal ActualPayAmount { get; set; }
    
        /// <summary>
        /// 满额减金额
        /// </summary>
        public decimal FullDiscount { get; set; }
    
        /// <summary>
        /// 预付款支付金额
        /// </summary>
        public decimal CapitalAmount { get; set; }
    
        /// <summary>
        /// 使用的优惠券Id
        /// </summary>
        public bigint CouponId { get; set; }
    
        /// <summary>
        /// 达达取消发单原因
        /// </summary>
        public string CancelReason { get; set; }
    
        /// <summary>
        /// 达达状态
        /// </summary>
        public int DadaStatus { get; set; }
    
        /// <summary>
        /// 代理抽佣比例
        /// </summary>
        public decimal AgentRate { get; set; }
    
        /// <summary>
        /// 代理商佣金
        /// </summary>
        public decimal AgentCommission { get; set; }
    
        /// <summary>
        /// 市代用户ID
        /// </summary>
        public bigint CityAgentUserId { get; set; }
    
        /// <summary>
        /// 区代用户ID
        /// </summary>
        public bigint AreaAgentUserId { get; set; }
    
        /// <summary>
        /// 买家推荐人用户ID
        /// </summary>
        public bigint UserRefereeUserId { get; set; }
    
        /// <summary>
        /// 卖家推荐人用户ID
        /// </summary>
        public bigint ShopRefereeUserId { get; set; }
    
        /// <summary>
        /// 订单所需总积分
        /// </summary>
        public int RequiredTotalIntegral { get; set; }

    }
}
