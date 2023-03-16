using FruitLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitLibrary.Repository
{
    public interface  IFruitRepository
    {
        IEnumerable<Fruit> GetFruits();
        Fruit GetFruitbyID(int id);

        void InsertFruit(Fruit fruit);
        void UpdateFruit(Fruit fruit);
        void DeleteFruit(int id);

    }
}
