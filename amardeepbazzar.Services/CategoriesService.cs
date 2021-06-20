using amardeepbazzar.Database;
using amardeepbazzar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amardeepbazzar.Services
{
    public class CategoriesService
    {
        public Category GetCategory(int Id)
        {
            using (var context = new ABContext())
            {
                return context.Categories.Find(Id);
            }
        }

        public List<Category> GetCategories()
        {
            using (var context = new ABContext())
            {
                return context.Categories.ToList();
            }
        }
        public void SaveCategory(Category category)
        {
            using (var context = new ABContext())
            {
                context.Categories.Add(category);
                context.SaveChanges();
            }
        }

        public void UpdateCategory(Category category)
        {
            using (var context = new ABContext())
            {
                context.Entry(category).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteCategory(int Id)
        {
            using (var context = new ABContext())
            {

                var category = context.Categories.Find(Id);

                context.Categories.Remove(category);
                context.SaveChanges();
            }
        }
    }
}
