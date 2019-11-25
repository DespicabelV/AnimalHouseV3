﻿using System;
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
        public List<string> ControllerGetOwner(string PhoneNum)
        {
            List<string> ControllerGetOwner = new List<string>();

            ControllerGetOwner = PrivateFetch(PhoneNum);

            return ControllerGetOwner;
        }


        public List<string> ControllerGetRelation(string OwnerID)
        {
            List<string> ControllerGetRelation = new List<string>();

            ControllerGetRelation = RelationFetch(OwnerID);

            return ControllerGetRelation;
        }


        public bool ControllerOwnerExist(string COParam)
        {
            bool TempBool;
            TempBool = PrivateExist(COParam);
            return TempBool;
        }

        //Entity
        static bool PrivateExist(string PEParam)
        {
            IPersistenceController Daba = new DatabaseController();
            bool TempBool;
            return TempBool = Daba.CheckIfExist("Ejer", "TelefonNr", PEParam);
        }

        static List<string> PrivateFetch(string PFParam)
        {
            IPersistenceController Daba = new DatabaseController();
            List<string> ListOwn;

            ListOwn = Daba.DBCSelectFromWhere("Ejer", "TelefonNr", PFParam);
          
            return ListOwn;
        }

        static List<string> RelationFetch(string RFparam)
        {
            IPersistenceController Daba = new DatabaseController();
            List<string> ListRela;

            ListRela = Daba.DBCSelectFromWhere("Relation", "Ejer", RFparam);

            return ListRela;
        }
    }
}
