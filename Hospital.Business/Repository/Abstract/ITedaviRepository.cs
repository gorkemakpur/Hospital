using Hospital.Business.Repository.Concrete;
using Hospital.Business.UnitOfWork;
using Hospital.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Business.Repository.Abstract
{
    public interface ITedaviRepository : IRepository<Tedavi>
    {
    }
}
