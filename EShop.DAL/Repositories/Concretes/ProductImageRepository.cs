﻿using EShop.DAL.ContextClasses;
using EShop.DAL.Repositories.Abstracts;
using EShop.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.DAL.Repositories.Concretes
{
    public class ProductImageRepository:BaseRepository<ProductImage>,IProductImageRepository
    {
        public ProductImageRepository(MyContext db):base(db)
        {
            
        }
    }
}
