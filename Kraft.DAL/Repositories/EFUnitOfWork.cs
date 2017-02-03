using Kraft.DAL.EF;
using Kraft.DAL.Entities;
using Kraft.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kraft.DAL.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private KraftContext db;
        private ChecklistRepository checklistRepository;
        private DrillCardRepository drillCardRepository;
        

        public EFUnitOfWork(string connectionString)
        {
            db = new KraftContext(connectionString);
        }

        public IRepository<Checklist> Checklists
        {
            get
            {
                if (checklistRepository == null)
                    checklistRepository = new ChecklistRepository(db);
                return checklistRepository;
            }
        }

        public IRepository<DrillCard> DrillCards
        {
            get
            {
                if (drillCardRepository == null)
                    drillCardRepository = new DrillCardRepository(db);
                return drillCardRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
