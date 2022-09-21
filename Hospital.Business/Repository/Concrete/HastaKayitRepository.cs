using Hospital.Business.Repository.Abstract;
using Hospital.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Business.Repository.Concrete
{
    public class HastaKayitRepository : IHastaKayitRepository
    {
        public void Add(HastaKayit entity)
        {
            using (HospitalEntities context = new HospitalEntities())
            {
                context.HastaKayit.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (HospitalEntities context = new HospitalEntities())
            {
                HastaKayit hastaKayit = context.HastaKayit.Find(id);
                context.HastaKayit.Remove(hastaKayit);
                context.SaveChanges();
            }
        }

        public void Delete(HastaKayit entity)
        {
            using (HospitalEntities context = new HospitalEntities())
            {
                context.HastaKayit.Remove(entity);
                context.SaveChanges();
            }
        }

        public HastaKayit Get(int id)
        {
            using (HospitalEntities context = new HospitalEntities())
            {
                return context.HastaKayit.Find(id);
            }
        }

        public List<HastaKayit> GetList()
        {
            using (HospitalEntities context = new HospitalEntities())
            {
                return context.HastaKayit.ToList();
            }
        }

        public void Update(HastaKayit entity)
        {
            using (HospitalEntities context = new HospitalEntities())
            {
                context.HastaKayit.Attach(entity);
                context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
