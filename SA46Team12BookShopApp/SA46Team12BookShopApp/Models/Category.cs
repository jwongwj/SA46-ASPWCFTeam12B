namespace SA46Team12BookShopApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [DataContract]
    [Table("Category")]
    public partial class Category
    {
        [DataMember]
        public int CategoryID { get; set; }

        [DataMember]
        [Required]
        [StringLength(16)]
        public string Name { get; set; }
    }
}
