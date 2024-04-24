using Exp.New.DataAcess.Data;
using Exp.New.DataAcess.Repository.IRepository;
using Exp.New.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Exp.New.DataAcess.Repository
{
    public class OfficerRepository : Repository<Officer>, IOfficerRepository
    {
        private ApplicationDbContext _db;
        public OfficerRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Officer obj)
        {
            _db.Officers.Update(obj);
        }
    }
}

