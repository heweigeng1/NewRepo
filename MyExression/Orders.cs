namespace MyExression
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Orders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Orders()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        public Guid Id { get; set; }

        [StringLength(18)]
        public string OrderNum { get; set; }

        public decimal? Money { get; set; }

        [StringLength(500)]
        public string DeliveryAddress { get; set; }

        public Guid BuyId { get; set; }

        [StringLength(200)]
        public string BuyerName { get; set; }

        public Guid DistributorId { get; set; }

        [StringLength(500)]
        public string Remark { get; set; }

        [StringLength(50)]
        public string PhoneNum { get; set; }

        public DateTime? DeliveryTime { get; set; }

        public DateTime? OrderTime { get; set; }

        public int OrderStatus { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

        public int Delflag { get; set; }

        public Guid? BuyUser_Id { get; set; }

        public virtual Distributors Distributors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }

        public virtual Users Users { get; set; }
    }
}
