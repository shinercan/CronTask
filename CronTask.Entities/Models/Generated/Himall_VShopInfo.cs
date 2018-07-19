
//-----------------------------------------------------------------------
// <copyright file=" Himall_VShop.cs" company="xxxx Enterprises">
// * Copyright (C) 2018YW Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: Himall_VShop.cs
// * history : Created by T4 07/19/2018 09:12:09 
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace CronTask.Entities
{
    /// <summary>
    /// Himall_VShop Entity Model
    /// </summary>    
    [Serializable]
    public partial class Himall_VShopInfo
    {
        /// <summary>
        /// 
        /// </summary>

        public bigint Id { get; set; }
    
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
    
        /// <summary>
        /// 店铺ID
        /// </summary>
        public bigint ShopId { get; set; }
    
        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime CreateTime { get; set; }
    
        /// <summary>
        /// 历览次数
        /// </summary>
        public int VisitNum { get; set; }
    
        /// <summary>
        /// 购买数量
        /// </summary>
        public int buyNum { get; set; }
    
        /// <summary>
        /// 状态
        /// </summary>
        public int State { get; set; }
    
        /// <summary>
        /// LOGO
        /// </summary>
        public string Logo { get; set; }
    
        /// <summary>
        /// 背景图
        /// </summary>
        public string BackgroundImage { get; set; }
    
        /// <summary>
        /// 详情
        /// </summary>
        public string Description { get; set; }
    
        /// <summary>
        /// 标签
        /// </summary>
        public string Tags { get; set; }
    
        /// <summary>
        /// 微信首页显示的标题
        /// </summary>
        public string HomePageTitle { get; set; }
    
        /// <summary>
        /// 微信Logo
        /// </summary>
        public string WXLogo { get; set; }

    }
}