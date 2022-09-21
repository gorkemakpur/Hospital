using Hospital.Business.Repository.Abstract;
using Hospital.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Business.Repository.Concrete
{
    public class CinsiyetRepository : ICinsiyetRepository
    {
        public void Add(Cinsiyet entity)
        {
            using (HospitalEntities context = new HospitalEntities())
            {
                context.Cinsiyet.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (HospitalEntities context = new HospitalEntities())
            {
                Cinsiyet cinsiyet = context.Cinsiyet.Find(id);
                context.Cinsiyet.Remove(cinsiyet);
                context.SaveChanges();
            }
        }

        public void Delete(Cinsiyet entity)
        {
            using (HospitalEntities context = new HospitalEntities())
            {
                context.Cinsiyet.Remove(entity);
                context.SaveChanges();
            }
        }

        public Cinsiyet Get(int id)
        {
            using (HospitalEntities context = new HospitalEntities())
            {
                return context.Cinsiyet.Find(id);
            }
        }

        public List<Cinsiyet> GetList()
        {
            using (HospitalEntities context = new HospitalEntities())
            {
                return context.Cinsiyet.ToList();
            }
        }

        public void Update(Cinsiyet entity)
        {
            using (HospitalEntities context = new HospitalEntities())
            {
                context.Cinsiyet.Attach(entity);
                context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
