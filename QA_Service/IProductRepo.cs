using QA_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Service
{
    public interface IProductRepo
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
    }
}
