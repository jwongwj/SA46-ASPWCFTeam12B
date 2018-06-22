namespace SA46Team12BookShopApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;
    [DataContract]
    [Table("Book")]
    public partial class Book
    {
        [DataMember]
        public int BookID { get; set; }

        [DataMember]
        [Required]
        [StringLength(120)]
        public string Title { get; set; }

        [DataMember]
        public int CategoryID { get; set; }

        [DataMember]
        [Required]
        [StringLength(22)]
        public string ISBN { get; set; }

        [DataMember]
        [Required]
        [StringLength(64)]
        public string Author { get; set; }

        [DataMember]
        public int Stock { get; set; }

        [DataMember]
        public decimal Price { get; set; }

        //public Book(int id, string title, int categoryid, string ISBN, string author, int stock, decimal price)
        //{
        //    this.BookID = id;
        //    this.Title = title;
        //    this.ISBN = ISBN;
        //    this.Author = author;
        //    this.Stock = stock;
        //    this.Price = price;
        //}

    }
}
