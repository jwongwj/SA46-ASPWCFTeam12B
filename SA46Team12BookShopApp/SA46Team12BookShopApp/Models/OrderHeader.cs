namespace SA46Team12BookShopApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [DataContract]
    [Table("OrderHeader")]
    public partial class OrderHeader
    {
        [DataMember]
        [Key]
        public int OrderID { get; set; }

        [DataMember]
        [Column(TypeName = "date")]
        public DateTime OrderDate { get; set; }

        [DataMember]
        public decimal Total { get; set; }

        [DataMember]
        public string UserID { get; set; }

        [DataMember]
        public int PostalCode { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Address { get; set; }

    }
}
