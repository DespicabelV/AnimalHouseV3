using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        public void ExtractDataFromDokument(string ImportString)
        {
            // Afgrænser
            Char delimiter = ',';
            String[] SubString = ImportString.Split(delimiter);
            string TempID = SubString[0];
            string TempPrice = SubString[1];

        }

        public List<string> TextDocumentReader()
        {
            List<string> Lines = new List<string>();
            string Line;
            System.IO.StreamReader File = new System.IO.StreamReader(AnimalHouseEntity.Properties.Resources.MedicinData);
            while ((Line=File.ReadLine())!= null)
            {
                Lines.Add(Line);
            }
            File.Close();
            return Lines;
        }
    }
}
