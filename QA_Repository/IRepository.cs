using QA_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Repository
{
    public interface IRepository <T> where T : BaseEntity

    {
        IEnumerable<T> GetAll();
        T GetById(int Id);

    }
}
