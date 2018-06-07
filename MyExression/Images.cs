namespace MyExression
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Images
    {
        public Guid Id { get; set; }

        public Guid? UserId { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        [StringLength(200)]
        public string OriginalPath { get; set; }

        public int Type { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public int Length { get; set; }

        [Required]
        [StringLength(200)]
        public string Key { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

        public int Delflag { get; set; }

        public virtual Users Users { get; set; }
    }
}
