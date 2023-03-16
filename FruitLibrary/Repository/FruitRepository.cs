using FruitLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitLibrary.Repository
{
    public class FruitRepository : IFruitRepository
    {
        public void DeleteFruit(int id)=>FruitDAO.Instance.Remove(id);
        

        public Fruit GetFruitbyID(int id)=>FruitDAO.Instance.GetFruitbyID(id);


        public IEnumerable<Fruit> GetFruits() => FruitDAO.Instance.GetAll();
       

        public void InsertFruit(Fruit fruit)=>FruitDAO.Instance.AddFr(fruit);
       
        public void UpdateFruit(Fruit fruit)=>FruitDAO.Instance.UpdateFr(fruit);
        
    }
}
