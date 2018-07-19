
//-----------------------------------------------------------------------
// <copyright file=" Himall_MobileHomeProducts.cs" company="xxxx Enterprises">
// * Copyright (C) 2018YW Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: Himall_MobileHomeProducts.cs
// * history : Created by T4 07/19/2018 09:12:09 
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace CronTask.Entities
{
    /// <summary>
    /// Himall_MobileHomeProducts Entity Model
    /// </summary>    
    [Serializable]
    public partial class Himall_MobileHomeProductsInfo
    {
        /// <summary>
        /// 
        /// </summary>

        public bigint Id { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public bigint ShopId { get; set; }
    
        /// <summary>
        /// 终端类型(微信、WAP）
        /// </summary>
        public int PlatFormType { get; set; }
    
        /// <summary>
        /// 顺序
        /// </summary>
        public int Sequence { get; set; }
    
        /// <summary>
        /// 商品ID
        /// </summary>
        public bigint ProductId { get; set; }

    }
}