using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHousePersistence;
using AnimalHouseEntity;

namespace AnimalHouseTemp
{
    public class ViggoTemp
    {
       public IPersistenceController Daba;
        public ViggoTemp()
        {
            Daba = new DatabaseController();
        }

        public void test()
        {
            Console.WriteLine("hej");
        }
    }
}
