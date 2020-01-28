using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Data.Infrastructer
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
