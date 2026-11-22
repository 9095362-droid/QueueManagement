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

        public List<ServiceCategory> GetAll() => _dal.GetAll();

        public ServiceCategory? GetById(int id) => _dal.GetById(id);

        public void Add(ServiceCategory c) => _dal.Add(c);

        public void Update(ServiceCategory c) => _dal.Update(c);

        public void Delete(int id) => _dal.Delete(id);
    }
}
