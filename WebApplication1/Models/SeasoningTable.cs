namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SeasoningTable")]
    public partial class SeasoningTable
    {
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string Season { get; set; }
    }
}
