
//-----------------------------------------------------------------------
// <copyright file=" Himall_PhotoSpaceCategory.cs" company="xxxx Enterprises">
// * Copyright (C) 2018YW Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: Himall_PhotoSpaceCategory.cs
// * history : Created by T4 07/19/2018 09:12:09 
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace CronTask.Entities
{
    /// <summary>
    /// Himall_PhotoSpaceCategory Entity Model
    /// </summary>    
    [Serializable]
    public partial class Himall_PhotoSpaceCategoryInfo
    {
        /// <summary>
        /// 
        /// </summary>

        public bigint Id { get; set; }
    
        /// <summary>
        /// 店铺ID
        /// </summary>
        public bigint ShopId { get; set; }
    
        /// <summary>
        /// 图片空间分类名称
        /// </summary>
        public string PhotoSpaceCatrgoryName { get; set; }
    
        /// <summary>
        /// 显示顺序
        /// </summary>
        public bigint DisplaySequence { get; set; }

    }
}
