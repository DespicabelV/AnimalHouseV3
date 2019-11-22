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
        IPersistenceController Daba;

        //Todo
        //Check if the owner is there
        //Lav inset journal til dyr

        public ViggoTemp()
        {
            Daba = new DatabaseController();
        }

        public void test()
        {
            List<string> ListOwn;
            Console.WriteLine("hej");
            ListOwn = PrivateFetch("1874865");
            foreach (string item in ListOwn)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }

        //Controler
        public List<string> ControllerGetOwner(string TelefonNr)
        {
            List<string> ControllerGetOwner = new List<string>();

            ControllerGetOwner = PrivateFetch(TelefonNr);

            return ControllerGetOwner;
        }

        //Entity
        static List<string> PrivateFetch(string TelefonNr)
        {
            IPersistenceController Daba = new DatabaseController();
            List<string> ListOwn;

            ListOwn = Daba.DBCSelectFromWhere("Ejer", "TelefonNr", TelefonNr);
          
            return ListOwn;
        }
    }
}
