namespace MyExression
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Addresses
    {
        public Guid Id { get; set; }

        public Guid? FromId { get; set; }

        public string AddressPath { get; set; }

        public string PhoneNum { get; set; }

        public string Remark { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

        public int Delflag { get; set; }

        public string ProvinceCode { get; set; }

        public string CityCode { get; set; }
    }
}
