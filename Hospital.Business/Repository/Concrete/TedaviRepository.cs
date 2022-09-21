using Hospital.Business.Repository.Abstract;
using Hospital.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Business.Repository.Concrete
{

    public class TedaviRepository : ITedaviRepository
    {
        HospitalEntities context = new HospitalEntities();
        public void Add(Tedavi entity)
        {
            using (HospitalEntities context = new HospitalEntities())
            {
                context.Tedavi.Add(entity);
                context.SaveChanges();
            }

        }

        public void Delete(int id)
        {
            using (HospitalEntities context = new HospitalEntities())
            {
                Tedavi tedavi = context.Tedavi.Find(id);
                context.Tedavi.Remove(tedavi);
                context.SaveChanges();
            }

        }

        public void Delete(Tedavi entity)
        {
            using (HospitalEntities context = new HospitalEntities())
            {
                context.Tedavi.Remove(entity);
                context.SaveChanges();
            }

        }

        public Tedavi Get(int id)
        {
            using (HospitalEntities context = new HospitalEntities())
            {
                return context.Tedavi.Find(id);
            }

        }

        public List<Tedavi> GetList()
        {
            using (HospitalEntities context = new HospitalEntities())
            {
                return context.Tedavi.ToList();
            }

        }

        public void Update(Tedavi entity)
        {
            using (HospitalEntities context = new HospitalEntities())
            {
                context.Tedavi.Attach(entity);
                context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }


        }
    }
}
