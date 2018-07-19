
//-----------------------------------------------------------------------
// <copyright file=" Himall_ShopBranch.cs" company="xxxx Enterprises">
// * Copyright (C) 2018YW Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: Himall_ShopBranch.cs
// * history : Created by T4 07/19/2018 09:12:09 
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace CronTask.Entities
{
    /// <summary>
    /// Himall_ShopBranch Entity Model
    /// </summary>    
    [Serializable]
    public partial class Himall_ShopBranchInfo
    {
        /// <summary>
        /// 主键
        /// </summary>

        public bigint Id { get; set; }
    
        /// <summary>
        /// 商家店铺ID
        /// </summary>
        public bigint ShopId { get; set; }
    
        /// <summary>
        /// 门店名称
        /// </summary>
        public string ShopBranchName { get; set; }
    
        /// <summary>
        /// 门店地址ID
        /// </summary>
        public int AddressId { get; set; }
    
        /// <summary>
        /// 所在区域全路径编号(省，市，区)
        /// </summary>
        public string AddressPath { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public string AddressDetail { get; set; }
    
        /// <summary>
        /// 联系人
        /// </summary>
        public string ContactUser { get; set; }
    
        /// <summary>
        /// 联系地址
        /// </summary>
        public string ContactPhone { get; set; }
    
        /// <summary>
        /// 门店状态(0:正常，1:冻结)
        /// </summary>
        public int Status { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateDate { get; set; }
    
        /// <summary>
        /// 服务半径
        /// </summary>
        public int ServeRadius { get; set; }
    
        /// <summary>
        /// 经度
        /// </summary>
        public float Longitude { get; set; }
    
        /// <summary>
        /// 维度
        /// </summary>
        public float Latitude { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public string ShopImages { get; set; }
    
        /// <summary>
        /// 是否门店配送0:否1:是
        /// </summary>
        public bool IsStoreDelive { get; set; }
    
        /// <summary>
        /// 是否上门自提0:否1:是
        /// </summary>
        public bool IsAboveSelf { get; set; }
    
        /// <summary>
        /// 配送费
        /// </summary>
        public int DeliveFee { get; set; }
    
        /// <summary>
        /// 起送费
        /// </summary>
        public int DeliveTotalFee { get; set; }
    
        /// <summary>
        /// 营业起始时间
        /// </summary>
        public DateTime StoreOpenStartTime { get; set; }
    
        /// <summary>
        /// 营业结束时间
        /// </summary>
        public DateTime StoreOpenEndTime { get; set; }
    
        /// <summary>
        /// 是否推荐门店
        /// </summary>
        public bool IsRecommend { get; set; }
    
        /// <summary>
        /// 推荐排序
        /// </summary>
        public bigint RecommendSequence { get; set; }
    
        /// <summary>
        /// 包邮金额
        /// </summary>
        public int FreeMailFee { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public string DaDaShopId { get; set; }
    
        /// <summary>
        /// 是否开启自动打印
        /// </summary>
        public bool IsAutoPrint { get; set; }
    
        /// <summary>
        /// 打印张数
        /// </summary>
        public int PrintCount { get; set; }
    
        /// <summary>
        /// 锁粉数
        /// </summary>
        public int FansCount { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public decimal PlatIncome { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public decimal ShopIncome { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public decimal TotalAmount { get; set; }

    }
}