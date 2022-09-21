using Hospital.Business.Repository.Abstract;
using Hospital.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Business.Repository.Concrete
{
    public class HastaRepository : IHastaRepository
    {

        HospitalEntities context = new HospitalEntities();
        public void Add(Hasta entity)
        {
            using (HospitalEntities context = new HospitalEntities())
            {
                context.Hasta.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (HospitalEntities context = new HospitalEntities())
            {
                Hasta hasta = context.Hasta.Find(id);
                context.Hasta.Remove(hasta);
                context.SaveChanges();
            }

        }

        public void Delete(Hasta entity)
        {
            using (HospitalEntities context = new HospitalEntities())
            {
                context.Hasta.Remove(entity);
                context.SaveChanges();
            }
        }

        public Hasta Get(int id)
        {
            using (HospitalEntities context = new HospitalEntities())
            {
                return context.Hasta.Find(id);
            }
        }

        public List<Hasta> GetList()
        {
            using (HospitalEntities context = new HospitalEntities())
            {
                return context.Hasta.ToList();
            }
        }

        public void Update(Hasta entity)
        {
            using (HospitalEntities context = new HospitalEntities())
            {
                context.Hasta.Attach(entity);
                context.Entry(entity).State= System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
