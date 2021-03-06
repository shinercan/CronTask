﻿using System;
using System.Linq;
using System.Text;

namespace CronTask.Model
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_Members
    {
           public Himall_Members(){


           }
           /// <summary>
           /// 
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// 名称
           /// </summary>           
           public string UserName {get;set;}

           /// <summary>
           /// 密码
           /// </summary>           
           public string Password {get;set;}

           /// <summary>
           /// 密码加盐
           /// </summary>           
           public string PasswordSalt {get;set;}

           /// <summary>
           /// 昵称
           /// </summary>           
           public string Nick {get;set;}

           /// <summary>
           /// 性别
           /// </summary>           
           public int? Sex {get;set;}

           /// <summary>
           /// 邮件
           /// </summary>           
           public string Email {get;set;}

           /// <summary>
           /// 创建日期
           /// </summary>           
           public DateTime CreateDate {get;set;}

           /// <summary>
           /// 省份ID
           /// </summary>           
           public int TopRegionId {get;set;}

           /// <summary>
           /// 省市区ID
           /// </summary>           
           public int RegionId {get;set;}

           /// <summary>
           /// 真实姓名
           /// </summary>           
           public string RealName {get;set;}

           /// <summary>
           /// 电话
           /// </summary>           
           public string CellPhone {get;set;}

           /// <summary>
           /// QQ
           /// </summary>           
           public string QQ {get;set;}

           /// <summary>
           /// 街道地址
           /// </summary>           
           public string Address {get;set;}

           /// <summary>
           /// 是否禁用
           /// </summary>           
           public byte Disabled {get;set;}

           /// <summary>
           /// 最后登录日期
           /// </summary>           
           public DateTime LastLoginDate {get;set;}

           /// <summary>
           /// 下单次数
           /// </summary>           
           public int OrderNumber {get;set;}

           /// <summary>
           /// 总消费金额（不排除退款）
           /// </summary>           
           public decimal TotalAmount {get;set;}

           /// <summary>
           /// 总消费金额（不排除退款）
           /// </summary>           
           public decimal Expenditure {get;set;}

           /// <summary>
           /// 
           /// </summary>           
           public int Points {get;set;}

           /// <summary>
           /// 头像
           /// </summary>           
           public string Photo {get;set;}

           /// <summary>
           /// 商家父账号ID
           /// </summary>           
           public long ParentSellerId {get;set;}

           /// <summary>
           /// 
           /// </summary>           
           public string Remark {get;set;}

           /// <summary>
           /// 支付密码
           /// </summary>           
           public string PayPwd {get;set;}

           /// <summary>
           /// 支付密码加密字符
           /// </summary>           
           public string PayPwdSalt {get;set;}

           /// <summary>
           /// 
           /// </summary>           
           public long? InviteUserId {get;set;}

           /// <summary>
           /// 分销员Id
           /// </summary>           
           public long? ShareUserId {get;set;}

           /// <summary>
           /// 会员生日
           /// </summary>           
           public DateTime? BirthDay {get;set;}

           /// <summary>
           /// 职业
           /// </summary>           
           public string Occupation {get;set;}

           /// <summary>
           /// 净消费金额（排除退款）
           /// </summary>           
           public decimal NetAmount {get;set;}

           /// <summary>
           /// 最后消费时间
           /// </summary>           
           public DateTime? LastConsumptionTime {get;set;}

           /// <summary>
           /// 第三方聊天工具的token
           /// </summary>           
           public string IORongToken {get;set;}

           /// <summary>
           /// 会员推荐码
           /// </summary>           
           public string RecommendCode {get;set;}

           /// <summary>
           /// 会员类型 0 普通会员 1 高级会员
           /// </summary>           
           public int MemberType {get;set;}

           /// <summary>
           /// 锁粉时间
           /// </summary>           
           public DateTime? InviteTime {get;set;}

           /// <summary>
           /// 锁粉方式
           /// </summary>           
           public int InviteType {get;set;}

    }
}
