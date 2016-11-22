﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Qhyhgf.WeiXin.Qy.Api.Domain;

namespace Qhyhgf.WeiXin.Qy.Api.Response
{
    /// <summary>
    /// 获取企业号应用
    /// </summary>
    public class GetAgentResponse : WeiXinResponse
    {
        /// <summary>
        /// 企业应用id
        /// </summary>
        [DataMember(Name = "agentid")]
        public string AgentId { get; set; }
        /// <summary>
        /// 企业应用名称
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }
        /// <summary>
        /// 企业应用方形头像
        /// </summary>
        [DataMember(Name = "square_logo_url")]
        public string SquareLogoUrl { get; set; }
        /// <summary>
        /// 企业应用圆形头像
        /// </summary>
        [DataMember(Name = "round_logo_url")]
        public string RoundLogoUrl { get; set; }
        /// <summary>
        /// 企业应用详情
        /// </summary>
        [DataMember(Name = "description")]
        public string Description { get; set; }
        /// <summary>
        /// 企业应用可见范围（人员），其中包括userid和关注状态state
        /// </summary>
        [DataMember(Name = "allow_userinfos")]
        public AllowUserinfosEntity AllowUserinfos { get; set; }
        /// <summary>
        /// 企业应用可见范围（部门）
        /// </summary>
        [DataMember(Name = "allow_partys")]
        public AllowPartysEntity AllowPartys { get; set; }
        /// <summary>
        /// 企业应用可见范围（标签）
        /// </summary>
        [DataMember(Name = "allow_tags")]
        public AllowTagsEntity AllowTags { get; set; }
        /// <summary>
        /// 企业应用是否被禁用
        /// </summary>
        [DataMember(Name = "close")]
        public int Close { get; set; }
        /// <summary>
        /// 企业应用可信域名
        /// </summary>
        [DataMember(Name = "redirect_domain")]
        public string RedirectDomain { get; set; }
        /// <summary>
        /// 企业应用是否打开地理位置上报 0：不上报；1：进入会话上报；2：持续上报
        /// </summary>
        [DataMember(Name = "report_location_flag")]
        public int ReportLocationFlag { get; set; }
        /// <summary>
        /// 是否接收用户变更通知。0：不接收；1：接收
        /// </summary>
        [DataMember(Name = "isreportuser")]
        public int isreportuser { get; set; }
        /// <summary>
        /// 是否上报用户进入应用事件。0：不接收；1：接收
        /// </summary>
        [DataMember(Name = "isreportenter")]
        public int isreportenter { get; set; }
        /// <summary>
        /// 应用类型。1：消息型；2：主页型
        /// </summary>
        [DataMember(Name = "type")]
        public int Type { get; set; }
        /// <summary>
        ///关联会话url
        /// </summary>
        [DataMember(Name = "chat_extension_url")]
        public string ChatExtensionUrl { get; set; }

    }
}
