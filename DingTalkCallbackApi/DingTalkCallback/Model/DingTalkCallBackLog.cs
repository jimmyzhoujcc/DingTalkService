﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class DingTalkCallBackLog
    {
        /// <summary>
        /// 事件类型，有九种：
        /// “user_add_org”, “user_modify_org”, 
        /// “user_leave_org”,“org_admin_add”, 
        /// “org_admin_remove”, “org_dept_create”, 
        /// “org_dept_modify”, “org_dept_remove”, 
        /// “org_remove”,“org_change”,
        /// “label_user_change”, “label_conf_add”, 
        /// “label_conf_modify”,“label_conf_del”
        /// </summary>
        public string EventType { get; set; }
        /// <summary>
        /// 时间戳
        /// </summary>
        public long TimeStamp { get; set; }
        /// <summary>
        /// 用户发生变更的userid列表
        /// </summary>
        public string UserId { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}
