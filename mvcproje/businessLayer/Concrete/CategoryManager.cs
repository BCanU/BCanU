using DataAccessLayer.concrete.Repositories;
using EntityLayer.concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businessLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();

        public List<Category> GetAll()
        {
            return repo.list();
        }

        public void CategoryAddBL(Category p)
        {
            if(p.categoryName=="" || p.categoryName.Length <= 3 || p.categoryDescription==""|| p.categoryName.Length >= 51)
            {
                //hata mesajı
            }
            else
            {
                repo.Insert(p);
            }
        }
    }
}
