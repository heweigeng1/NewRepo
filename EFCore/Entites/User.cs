using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCore.Entites
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Creatime { get; set; }
        public Pason Pason { get; set; }
        public List<UserLog> UserLog { get; set; }
    }
    [Owned]
    public class Pason
    {
        public int Age { get; set; }
    }
}
