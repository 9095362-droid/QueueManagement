using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class ServiceCategoryDal
    {
        public List<ServiceCategory> GetAll()
        {
            using var db = new AppDbContext();
            return db.ServiceCategories.ToList();
        }

        public ServiceCategory? GetById(int id)
        {
            using var db = new AppDbContext();
            return db.ServiceCategories.Find(id);
        }

        public void Add(ServiceCategory category)
        {
            using var db = new AppDbContext();
            db.ServiceCategories.Add(category);
            db.SaveChanges();
        }

        public bool Update(ServiceCategory category)
        {
            using var db = new AppDbContext();
            var existing = db.ServiceCategories.Find(category.Id);
            if (existing == null) return false;   // TODO: ןאכ תונשל ,תרחא דובעי תמייק אלש המושר לש ןוכדעש הצור הרומה םא
            existing.Name = category.Name;
            existing.Description = category.Description;
            db.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            using var db = new AppDbContext();
            var existing = db.ServiceCategories.Find(id);
            if (existing == null) return false;   // TODO: הריזחמ תמייק אלש המושר לש הקיחמ false, הו-Controller 404 ריזחי
            db.ServiceCategories.Remove(existing);
            db.SaveChanges();
            return true;
        }
    }
}
