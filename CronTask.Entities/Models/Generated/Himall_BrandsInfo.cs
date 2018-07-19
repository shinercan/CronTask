
//-----------------------------------------------------------------------
// <copyright file=" Himall_Brands.cs" company="xxxx Enterprises">
// * Copyright (C) 2018YW Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: Himall_Brands.cs
// * history : Created by T4 07/19/2018 09:12:09 
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace CronTask.Entities
{
    /// <summary>
    /// Himall_Brands Entity Model
    /// </summary>    
    [Serializable]
    public partial class Himall_BrandsInfo
    {
        /// <summary>
        /// 
        /// </summary>

        public bigint Id { get; set; }
    
        /// <summary>
        /// 品牌名称
        /// </summary>
        public string Name { get; set; }
    
        /// <summary>
        /// 顺序
        /// </summary>
        public bigint DisplaySequence { get; set; }
    
        /// <summary>
        /// LOGO
        /// </summary>
        public string Logo { get; set; }
    
        /// <summary>
        /// 未使用
        /// </summary>
        public string RewriteName { get; set; }
    
        /// <summary>
        /// 说明
        /// </summary>
        public string Description { get; set; }
    
        /// <summary>
        /// SEO
        /// </summary>
        public string Meta_Title { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public string Meta_Description { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public string Meta_Keywords { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public int IsRecommend { get; set; }
    
        /// <summary>
        /// 是否已删除
        /// </summary>
        public bool IsDeleted { get; set; }

    }
}