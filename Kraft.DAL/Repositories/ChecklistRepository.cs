using Kraft.DAL.EF;
using Kraft.DAL.Entities;
using Kraft.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kraft.DAL.Repositories
{
    public class ChecklistRepository : IRepository<Checklist>
    {
        private KraftContext db;

        public ChecklistRepository(KraftContext context)
        {
            this.db = context;
        }

        public void Create(Checklist checklist)
        {
            db.Checklists.Add(checklist);
        }

        public void Delete(int id)
        {
            Checklist checklist = db.Checklists.Find(id);
            if (checklist != null)
                db.Checklists.Remove(checklist);
        }

        public IEnumerable<Checklist> Find(Func<Checklist, Boolean> predicate)
        {
            return db.Checklists.Where(predicate).ToList();
        }

        public Checklist Get(int id)
        {
            return db.Checklists.Find(id);
        }

        public IEnumerable<Checklist> GetAll()
        {
            return db.Checklists;
        }

        public void Update(Checklist checklist)
        {
            db.Entry(checklist).State = EntityState.Modified;
        }
    }
}
