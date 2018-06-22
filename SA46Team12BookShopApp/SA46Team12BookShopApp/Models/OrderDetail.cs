namespace SA46Team12BookShopApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [DataContract]
    [Table("OrderDetail")]
    public partial class OrderDetail
    {
        [DataMember]
        public int OrderDetailID { get; set; }

        [DataMember]
        public int OrderID { get; set; }

        [DataMember]
        public int BookID { get; set; }

        [DataMember]
        public int Qty { get; set; }

        [DataMember]
        public decimal UnitPrice { get; set; }

        [DataMember]
        public int DiscountID { get; set; }

        [DataMember]
        public decimal NetPrice { get; set; }
    }
}
