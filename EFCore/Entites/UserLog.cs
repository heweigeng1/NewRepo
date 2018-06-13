using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCore.Entites
{
    /// <summary>
    /// B
    /// </summary>
    public class UserLog
    {
        public DateTime LoginTime { get; set; }
        public Guid UId { get; set; }
        [ForeignKey("UId")]
        public virtual User User { get; set; }
        public string LogDec { get; set; }
        public List<Log> Logs { get; set; }
    }
}
