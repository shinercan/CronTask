
//-----------------------------------------------------------------------
// <copyright file=" Himall_MemberIntegralExchangeRules.cs" company="xxxx Enterprises">
// * Copyright (C) 2018YW Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: Himall_MemberIntegralExchangeRules.cs
// * history : Created by T4 07/19/2018 09:12:09 
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace CronTask.Entities
{
    /// <summary>
    /// Himall_MemberIntegralExchangeRules Entity Model
    /// </summary>    
    [Serializable]
    public partial class Himall_MemberIntegralExchangeRulesInfo
    {
        /// <summary>
        /// 
        /// </summary>

        public bigint Id { get; set; }
    
        /// <summary>
        /// 一块钱对应多少积分
        /// </summary>
        public int IntegralPerMoney { get; set; }
    
        /// <summary>
        /// 一个积分对应多少钱
        /// </summary>
        public int MoneyPerIntegral { get; set; }

    }
}
