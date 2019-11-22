using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHousePersistence;
using AnimalHouseEntity;

namespace AnimalHouseTemp
{
    class JacobTempAui
    {
        //kode til create-knappen
        JacobTempAHC Controller = new JacobTempAHC();
        
    }
    class JacobTempAHC 
    {
        //the data will go through 4 steps. 1. getting read from the ui and converted to proper variable. 2. controller making new object with these variable, maybe added to list?
        
        
        
      
        
        public void callAddOwner(JacobTempEntity owner)
        {
            owner.AddToDatabase();
        }
        
        
    }
    class JacobTempEntity
    {
        public IPersistenceController OwnerController;
        public JacobTempEntity()
        {
            OwnerController = new DatabaseController();
        }

        private void AddToDatabase()
        {
            
            OwnerController.DBCInsertOwner(;
            OwnerController.DBCUpdateOwner();
            
        }
         
        
    }


    
}
