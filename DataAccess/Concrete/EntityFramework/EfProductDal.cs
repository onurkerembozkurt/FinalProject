using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Entry referans tutmayı mantığınla çöz anlamazsan tekrar izle


    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetail()
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             select new ProductDetailDto { ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName, 
                                 UnitsInStock = p.UnitsInStock };
                return result.ToList();
            }
        }
    }
}
/*
 *  
 *  1- databasedeki productla id üzerinden eşleştiriyor.
     
2- Entity framework savechanges metodunu çalıştırdığında takip ettiği 
        objelerin statelerine bakar değişiklik var ise uygular. bunlar enumlar üzerinden yürütülmüş.
    
3- Products senin koyduğun isim, seni stersen products yerine abradax da yazabilirsin, 
       objenin tipine bakıyor ve eşleştiriyor orada senin ne yazdığın değil oluşturduğun 
       ve verdiğin classın tipi önemli.
 * 
 */