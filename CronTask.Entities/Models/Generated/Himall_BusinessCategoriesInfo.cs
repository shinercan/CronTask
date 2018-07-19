
//-----------------------------------------------------------------------
// <copyright file=" Himall_BusinessCategories.cs" company="xxxx Enterprises">
// * Copyright (C) 2018YW Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: Himall_BusinessCategories.cs
// * history : Created by T4 07/19/2018 09:12:09 
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace CronTask.Entities
{
    /// <summary>
    /// Himall_BusinessCategories Entity Model
    /// </summary>    
    [Serializable]
    public partial class Himall_BusinessCategoriesInfo
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
        /// 分类ID
        /// </summary>
        public bigint CategoryId { get; set; }
    
        /// <summary>
        /// 分佣比例
        /// </summary>
        public decimal CommisRate { get; set; }
    
        /// <summary>
        /// 让利比例
        /// </summary>
        public decimal ProfitsRate { get; set; }
    
        /// <summary>
        /// 线下扫码让利比，只有联盟商角色才会设置这个值
        /// </summary>
        public decimal OfflinePayRate { get; set; }

    }
}
