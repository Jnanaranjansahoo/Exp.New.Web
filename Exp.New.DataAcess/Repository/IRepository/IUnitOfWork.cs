using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp.New.DataAcess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IOfficerRepository Officer { get; }

        void Save();
    }
}
