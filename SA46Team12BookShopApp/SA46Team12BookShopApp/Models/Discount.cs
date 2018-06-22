namespace SA46Team12BookShopApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [DataContract]
    [Table("Discount")]
    public partial class Discount
    {
        [DataMember]
        public int DiscountID { get; set; }

        [DataMember]
        public int BookID { get; set; }

        [DataMember]
        [Required]
        [StringLength(90)]
        public string DiscountDesc { get; set; }

        [DataMember]
        public decimal DiscountPercent { get; set; }
    }
}
