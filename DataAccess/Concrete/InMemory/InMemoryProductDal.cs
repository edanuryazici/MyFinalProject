using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products; //Product sınıfını içeren bir _products listesi oluşturdu '_' global olduğunu gösteriyor

        //public InMemoryProductDal() //ön izleme için verimiz olsun diye proje çalıştığında bize bir ürün listesi oluşturdu.
        //{
        //    _products = new List<Product> {
        //    new Product{ProductId=1,CategoryId=1, ProductName="Bardak", UnitePrice=15, UnitInStock=15},
        //    new Product{ProductId=2,CategoryId=1, ProductName="Kamera", UnitePrice=500, UnitInStock=3},
        //    new Product{ProductId=3,CategoryId=2, ProductName="Telefon", UnitePrice=1500, UnitInStock=2},
        //    new Product{ProductId=4,CategoryId=2, ProductName="Klavye", UnitePrice=150, UnitInStock=65},
        //    new Product{ProductId=5,CategoryId=2, ProductName="Fare", UnitePrice=85, UnitInStock=1},
        //};
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //Product productToDelete= null; //Şimidi bu döngüyü oluşturmamızın sebebi ön izleme yapmak için oluşturduğumuz verinin liste türü
            //                               //değişkene sahip olması. Liste türü veri yapısından veri silmke için öncelikle silmek
            //                               //istediğimiz verinin referans tutucusunu yani adresini döngü ile tarayıp bulmamız lazım
            //                               //Bu döngü LİNQ bilmediğimizi varsayarak oluşturulmuş alternatif bir çözüm şimdi LİNQ deneyelim.
            //foreach (var p in _products) 
            //{
            //    if (product.ProductId==p.ProductId)
            //    {
            //        productToDelete= p;
            //    }
            //}

            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId); //bu metot tek bir veriyi bulmayı sağlar.
                                                                                                        //O an dolaşılan ürünün Id si bizim yolladığımız ürün Id si
                                                                                                        //ile aynı mı diye sorgular yani yukarıdaki foreach ve if i
                                                                                                        //tek satırda halletmiş olduk.

            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            //Gönderdiğim ürün id sine sahip olan listedeki ürünü bul
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
      
    }
     


      
    }


