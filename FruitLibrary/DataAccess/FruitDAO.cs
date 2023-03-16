using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitLibrary.DataAccess
{
    public class FruitDAO
    {
        private static FruitDAO instance = null;
        private static readonly object instanceLock = new object();
        public static FruitDAO Instance
        {
            get { 
                lock(instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new FruitDAO();
                    }
                }
                return instance; }
        }

        public IEnumerable<Fruit> GetAll()
        {
            var fr = new List<Fruit>();
            try
            {
                using var context = new FruitDbContext();
                fr = context.Fruits.ToList();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return fr;
        }

        public Fruit GetFruitbyID(int id) {
        Fruit fr = null;
            try
            {
                using var context = new FruitDbContext();
                fr = context.Fruits.SingleOrDefault(c=>c.Id== id);
            }catch(Exception ex) { throw new Exception(ex.Message); }

            return fr;
        }

        public void AddFr(Fruit fr)
        {
            try
            {
                Fruit fruit = GetFruitbyID(fr.Id);
                if (fruit == null)
                {
                    using var context = new FruitDbContext();
                    context.Fruits.Add(fr);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The fruit is already exist.");
                }
            }catch(Exception ex) { throw new Exception(ex.Message); }
        }

        public void UpdateFr(Fruit fr)
        {
            try
            {
                Fruit fruit = GetFruitbyID(fr.Id);
                if (fruit != null)
                {
                    using var context = new FruitDbContext();
                    context.Fruits.Update(fr);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The fruit is already exist.");
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public void Remove(int id)
        {
            try
            {

                Fruit fruit = GetFruitbyID(id);
                if (fruit != null)
                {
                    using var context = new FruitDbContext();
                    context.Fruits.Remove(fruit);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The fruit does not already exist.");
                }
            }catch(Exception ex) { throw new Exception(ex.Message); }
        }


    }
}
