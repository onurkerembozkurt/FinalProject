using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        //Bu yaptıgımız hareket SOLID deki O harfi Open Closed Principle
        static void Main(string[] args)
        {
            //CategoryTest();
            //ProductManager productManager = new ProductManager(new EfProductDal());
            //var result = productManager.GetProductDetail();
            //if (result.Success==true)
            //{
            //    foreach (var product in result.Data)
            //    {
            //        Console.WriteLine(product.ProductName+"/"+product.CategoryName);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}

        }

        //private static void CategoryTest()
        //{
        //    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

        //    foreach (var c in categoryManager.GetAll())
        //    {
        //        Console.WriteLine(c.CategoryName);
        //    }
        //}
    }
}
