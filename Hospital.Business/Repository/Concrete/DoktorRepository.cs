using Hospital.Business.Repository.Abstract;
using Hospital.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Business.Repository.Concrete
{
    public class DoktorRepository : IDoktorRepository
    {
        HospitalEntities context = new HospitalEntities();
        public void Add(Doktor entity)
        {
            using (HospitalEntities context = new HospitalEntities())
            {
                context.Doktor.Add(entity);
                context.SaveChanges();
            }

        }

        public void Delete(int id)
        {
            using (HospitalEntities context = new HospitalEntities())
            {
                Doktor doktor = context.Doktor.Find(id);
                context.Doktor.Remove(doktor);
                context.SaveChanges();
            }
        }

        public void Delete(Doktor entity)
        {
            using (HospitalEntities context = new HospitalEntities())
            {
                context.Doktor.Remove(entity);
                context.SaveChanges();
            }
        }

        public Doktor Get(int id)
        {
            using (HospitalEntities context = new HospitalEntities())
            {
                return context.Doktor.Find(id);
            }
        }

        public List<Doktor> GetList()
        {
            using (HospitalEntities context = new HospitalEntities())
            {
                return context.Doktor.ToList();
            }
        }

        public void Update(Doktor entity)
        {
            using (HospitalEntities context = new HospitalEntities())
            {
                context.Doktor.Attach(entity);
                context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }

        }
    }
}
