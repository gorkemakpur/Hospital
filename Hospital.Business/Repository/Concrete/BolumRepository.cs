using Hospital.Business.Repository.Abstract;
using Hospital.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Business.Repository.Concrete
{
    public class BolumRepository : IBolumRepository
    {
        public void Add(Bolum entity)
        {
            using (HospitalEntities context = new HospitalEntities())
            {
                context.Bolum.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (HospitalEntities context = new HospitalEntities())
            {
                Bolum bolum = context.Bolum.Find(id);
                context.Bolum.Remove(bolum);
                context.SaveChanges();
            }
        }

        public void Delete(Bolum entity)
        {
            using (HospitalEntities context = new HospitalEntities())
            {
                context.Bolum.Remove(entity);
                context.SaveChanges();
            }
        }

        public Bolum Get(int id)
        {
            using (HospitalEntities context = new HospitalEntities())
            {
                return context.Bolum.Find(id);
            }
        }

        public List<Bolum> GetList()
        {
            using (HospitalEntities context = new HospitalEntities())
            {
                return context.Bolum.ToList();
            }
        }

        public void Update(Bolum entity)
        {
            using (HospitalEntities context = new HospitalEntities())
            {
                context.Bolum.Attach(entity);
                context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
