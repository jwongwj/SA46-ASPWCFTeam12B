﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SA46Team12BookShopApp.WCFServices
{
    public class Service : IService
    {
        public void AddOrder(OrderHeader o, List<OrderDetail> od)
        {
            OrderHeader O = new OrderHeader
            {
                OrderID = o.OrderID,
                OrderDate = o.OrderDate,
                Total = o.Total,
                UserID = o.UserID,
                PostalCode = o.PostalCode,
                Email = o.Email,
                Name = o.Name,
                Address = o.Address
            };

            List<OrderDetail> OD = new List<OrderDetail>();
                foreach(OrderDetail orderD in od)
                {
                    OD.Add(orderD);
                }
            BusinessLogic.AddOrder(O, OD);
        }

        public Book GetBook(string BookID)
        {
            int id = Convert.ToInt32(BookID);
            return BusinessLogic.GetBookbyID(id);
        }

        public Book GetBookbyISBN(string ISBN)
        {
            return BusinessLogic.GetBookbyISBN(ISBN);
        }


        public Category GetCategory(string CategoryID)
        {
            int id = Convert.ToInt32(CategoryID);
            return BusinessLogic.GetCategorybyID(id);
        }
        public List<Book> GetBookList()
        {
           return BusinessLogic.GetAllBooks();
        }
        public List<Category> GetCategoryList()
        {
            return BusinessLogic.GetAllCategories();
        }

        public List<OrderHeader> GetUserOrders()
        {
            // I need a method here to somehow decrypt the UserID in Database table
            return BusinessLogic.GetUserOrders();
        }


        public Stream GetImage(string BookID)
        {
            FileStream fs = File.OpenRead(@"C:\a.jpg");
            WebOperationContext.Current.OutgoingResponse.ContentType = "image/jpeg";
            return fs;
        }


        public Book UpdateBook(Book b)
        {
            Book updateBook;
            using (BooksDB entities = new BooksDB())
            {
                try
                {
                    updateBook = entities.Books.Find(b.BookID);
                    updateBook.Author = b.Author;
                    updateBook.ISBN = b.ISBN;
                    updateBook.Price = b.Price;
                    updateBook.Stock = b.Stock;
                    updateBook.Title = b.Title;
                    updateBook.CategoryID = b.CategoryID;
                    entities.SaveChanges();
                }
                catch (Exception e)
                {
                    return b;
                }
            }
            return updateBook;
        }
    }
}
