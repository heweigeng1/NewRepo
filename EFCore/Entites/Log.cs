﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCore.Entites
{
    /// <summary>
    /// 某定制日志
    /// </summary>
    public class Log :AllLog
    {
        public string Message { get; set; }
        public Guid UserLogId { get; set; }
        [ForeignKey("UserLogId")]
        public UserLog UserLog { get; set; }
    }
}
