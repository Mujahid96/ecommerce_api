﻿
using Ecommerce_Shop.DataAccess.Repository.IRepository;
using Ecommerce_Shop.DataAccess.Data;
using Ecommerce_Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_Shop.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category> ,ICategoryRepository
    {
        private ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db):base(db)
        {
            _db = db;
        }

        //public void Save()
        //{
        //    _db.SaveChanges();
        //} 

        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}
