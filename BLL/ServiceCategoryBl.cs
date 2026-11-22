using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Entities;

namespace BLL
{
    public class ServiceCategoryBl
    {
        private readonly ServiceCategoryDal _dal = new();

        public List<ServiceCategory> GetAll()
        {
            return _dal.GetAll();
        }

        public ServiceCategory? GetById(int id)
        {
            return _dal.GetById(id);
        }

        public bool Add(ServiceCategory c)
        {
            if (string.IsNullOrWhiteSpace(c.Name)) return false;
            _dal.Add(c);
            return true;
        }

        public bool Update(ServiceCategory c)
        {
            if (string.IsNullOrWhiteSpace(c.Name)) return false;
            return _dal.Update(c);
        }

        public void Delete(int id)
        {
             _dal.Delete(id);
        }
    }
}
