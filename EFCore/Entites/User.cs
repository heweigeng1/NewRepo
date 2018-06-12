using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCore.Entites
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public DateTime Creatime { get; set; }
        public Pason Pasons { get; set; }
        public List<UserLog> UserLog { get; set; }
    }
    [Owned]
    public class Pason
    {
        public int Age { get; set; }
    }
}
