using Kraft.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kraft.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Checklist> Checklists { get; }
        IRepository<DrillCard> DrillCards { get; }
        void Save();
    }
}
