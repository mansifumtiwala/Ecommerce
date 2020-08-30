using Ecommerce.DataBase;
using Ecommerce.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Services
{
    public class CategoryServices
    {
        public void SaveCategory(Category category)
        {
            /*Use using if you want all the resources that the context controls 
             * to be disposed at the end of the block. When you use using, 
             * the compiler automatically creates a try/finally block and 
             * calls dispose in the finally block.*/
            using (var context = new EcomContext())
            {
                context.Categories.Add(category);
                context.SaveChanges();
            }
        }

        public List<Category> GetCategories()
        {
            using (var context = new EcomContext())
            {
                return context.Categories.ToList();
            }
        }

        public Category GetCategoryByID(int Id)
        {
            using (var context = new EcomContext())
            {
                return context.Categories.Find(Id);
            }
        }

        public void UpdateCategory(Category category)
        {
            using (var context = new EcomContext())
            {
                context.Entry(category).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteCategory(Category category)
        {
            using (var context = new EcomContext())
            {
                context.Entry(category).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
