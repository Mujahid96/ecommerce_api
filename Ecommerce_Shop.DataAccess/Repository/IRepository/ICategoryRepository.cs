using Ecommerce_Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_Shop.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository:IRepositoy<Category>
    {
        void Update(Category obj);
        //void Save();

    }
}
