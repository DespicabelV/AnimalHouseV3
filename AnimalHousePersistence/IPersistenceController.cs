using System;
using System.Collections.Generic;

namespace AnimalHousePersistence
{
    public interface IPersistenceController
    {
        List<string> DBCSelectFrom(string DBCFrom);

        List<string> DBCSelectSpecificFromWhere(string DBCSelect, string DBCFrom, string DBCWhere, string DBCParam);

        bool CheckIfExist(string DBCFrom, string DBCWhere, string DBCParam);

        List<string> DBCSelectAnimal(string DBCName, string DBCDate, string DBCRace, string DBCGender);

        void DBCBeginTrans();

        void DBCCommitTrans();

        void DBCRollbackTrans();

        void DBCDelete(string DBCFrom, string DBCWhere, string DBCParam);

        List<string> DBCSelectFromWhere(string DBCFrom, string DBCWhere, string DBCParam);

        void DBCInsertAnimal(string Navn, char Kon, string Fodselsdag, string Race, int Laege, int Chip);

        void DBCInsertRelation(int Ejer, int Dyr);

        void DBCInsertBooking(int Behandling, int Laege, int Dyr, int Bur, int Burdage, string Dato, int Tid);

        void DBCInsertBusiness(int Ejer, string FirmaNavn, int CVR);

        void DBCInsertRessource(int Pris, int VareKatagoriID);

        void DBCInsertMedicin(int ID, string Navn);

        void DBCInsertOrderLine(int Faktura, int RessourceKatagori, int Ressource, int Pris, int Antal);

        void DBCInsertOwner(int TelefonNr, string Fornavn, string Efternavn, string Adresse, string Email, string By, int Postnr);

        void DBCInsertPrivate(int Ejer);

        void DBCInsertReceipt(int Total, int Bookning, int Ejer);

        void DBCUpdateOwner(int TelefonNr, string Fornavn, string Efternavn, string Adresse, string Email, string By_, int Postnr);

        void DBCUpdateAnimal(int ID, string Navn, char Kon, string Date, string Race, int Laege, int Chip);

        void DBCUpdateMedicin(int ID, string Navn);

        void DBCUpdateRessource(int ID, int Pris, int VareKata);



    }
}