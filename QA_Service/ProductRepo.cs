using QA_DataAccess;
using QA_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Service
{
    public class ProductRepo : IProductRepo
    {
        private  IRepository<Product> _repository;
        public ProductRepo(IRepository<Product> repository)
        {
            _repository=repository;
        } 

        public IEnumerable<Product> GetAll()
        {
            return _repository.GetAll();
        } 

        Product IProductRepo.GetById(int id)
        {
            return _repository.GetById(id);
        }
    }
}
