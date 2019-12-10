using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using AnimalHousePersistence;

namespace AnimalHouseEntity
{
   public class Medicin : Ressource
   {
        private string Name;
        private int Amount;
        public Medicin(int ID, double Price, int ProductCategoryID, string Name, int Amount) : base(ID, Price, ProductCategoryID)
        {
            this.Name = Name;
            this.Amount = Amount;
        }

        public static void ChangePriceFromDocument(string ImportString)
        {
            // Afgrænser
            IPersistenceController DBC = new DatabaseController();
            Char delimiter = '#';
            String[] SubString = ImportString.Split(delimiter);
            string TempID = SubString[0];
            string TempPrice = SubString[1];
            DBC.DBCUpdateRessource(Convert.ToInt32(TempID), Convert.ToInt32(TempPrice));

        }

        public static List<string> TextDocumentReader()
        {
            List<string> Lines = new List<string>();
            string Line;
            StreamReader File = new StreamReader(AnimalHouseEntity.Properties.Resources.MedicinData);
            while ((Line=File.ReadLine())!= null)
            {
                Lines.Add(Line);
            }
            File.Close();
            return Lines;
        }
        public static void UpdatePriceForMedicin()
        {
            foreach (string Line in TextDocumentReader())
            {
                ChangePriceFromDocument(Line);
            }
        }
   }
}
