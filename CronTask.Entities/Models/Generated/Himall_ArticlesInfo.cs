
//-----------------------------------------------------------------------
// <copyright file=" Himall_Articles.cs" company="xxxx Enterprises">
// * Copyright (C) 2018YW Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: Himall_Articles.cs
// * history : Created by T4 07/19/2018 09:12:09 
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace CronTask.Entities
{
    /// <summary>
    /// Himall_Articles Entity Model
    /// </summary>    
    [Serializable]
    public partial class Himall_ArticlesInfo
    {
        /// <summary>
        /// 
        /// </summary>

        public bigint Id { get; set; }
    
        /// <summary>
        /// 文章分类ID
        /// </summary>
        public bigint CategoryId { get; set; }
    
        /// <summary>
        /// 文章标题
        /// </summary>
        public string Title { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public string IconUrl { get; set; }
    
        /// <summary>
        /// 文档内容
        /// </summary>
        public string Content { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public DateTime AddDate { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public bigint DisplaySequence { get; set; }
    
        /// <summary>
        /// SEO标题
        /// </summary>
        public string Meta_Title { get; set; }
    
        /// <summary>
        /// SEO说明
        /// </summary>
        public string Meta_Description { get; set; }
    
        /// <summary>
        /// SEO关键字
        /// </summary>
        public string Meta_Keywords { get; set; }
    
        /// <summary>
        /// 是否显示
        /// </summary>
        public int IsRelease { get; set; }

    }
}
