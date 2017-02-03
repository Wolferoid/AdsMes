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
    public class DrillCardRepository : IRepository<DrillCard>
    {
        KraftContext db;

        public DrillCardRepository(KraftContext context)
        {
            this.db = context;
        }

        public void Create(DrillCard drillCard)
        {
            db.DrillCards.Add(drillCard);
        }

        public void Delete(int id)
        {
            DrillCard drillCard = db.DrillCards.Find(id);
            if (drillCard != null)
                db.DrillCards.Remove(drillCard);
        }

        public IEnumerable<DrillCard> Find(Func<DrillCard, Boolean> predicate)
        {
            return db.DrillCards.Where(predicate).ToList();
        }

        public DrillCard Get(int id)
        {
            return db.DrillCards.Find(id);
        }

        public IEnumerable<DrillCard> GetAll()
        {
            return db.DrillCards;
        }

        public void Update(DrillCard drillCard)
        {
            db.Entry(drillCard).State = EntityState.Modified;
        }
    }
}
