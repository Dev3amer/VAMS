using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class clsVaccineType
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int ID { set; get; }
        public string VaccineName { set; get; }
        public string VaccineDescription { set; get; }
        public int MinimumAllowedAge { set; get; }
        public float TypeFees { set; get; }
        clsVaccineType(int iD, string vaccineName, string vaccineDescription, int minimumAllowedAge, float typeFees)
        {
            ID = iD;
            VaccineName = vaccineName;
            VaccineDescription = vaccineDescription;
            MinimumAllowedAge = minimumAllowedAge;
            TypeFees = typeFees;
            Mode = enMode.Update;
        }
        public clsVaccineType()
        {
            this.ID = -1;
            this.VaccineName = string.Empty;
            this.VaccineDescription = string.Empty;
            this.MinimumAllowedAge = -1;
            this.TypeFees = -1;
            Mode = enMode.AddNew;
        }
        public static clsVaccineType Find(int ID)
        {
            string VaccineName = "", VaccineDescription ="";
            int MinimumAllowedAge = -1;
            float TypeFees = -1;

            if (clsVaccineTypeData.GetVaccineInfoByID(ID, ref VaccineName, ref VaccineDescription, ref MinimumAllowedAge, ref TypeFees))

                return new clsVaccineType(ID, VaccineName, VaccineDescription, MinimumAllowedAge, TypeFees);
            else
                return null;

        }
        public static clsVaccineType Find(string VaccineName)
        {
            int ID = -1;
            string VaccineDescription = "";
            int MinimumAllowedAge = -1;
            float TypeFees = -1;

            if (clsVaccineTypeData.GetVaccineInfoByName(VaccineName, ref ID, ref VaccineDescription, ref MinimumAllowedAge, ref TypeFees))

                return new clsVaccineType(ID, VaccineDescription, VaccineDescription, MinimumAllowedAge, TypeFees);
            else
                return null;

        }
        public static DataTable GetAllVaccines()
        {
            return clsVaccineTypeData.GetAllVaccines();
        }
        private bool _AddNewVaccine()
        {
            //call DataAccess Layer 
            this.ID = clsVaccineTypeData.AddNewVaccine(this.VaccineName,
                this.VaccineDescription, this.MinimumAllowedAge, this.TypeFees);

            return (this.ID != -1);
        }
        private bool _UpdateVaccine()
        {
            return clsVaccineTypeData.UpdateVaccine(this.ID, this.VaccineName,
                this.VaccineDescription, this.MinimumAllowedAge, this.TypeFees);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewVaccine())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    return false;

                case enMode.Update:
                    return _UpdateVaccine();
            }
            return false;
        }
        public static bool DeleteVaccine(int ID)
        {
            return clsVaccineTypeData.DeleteVaccine(ID);
        }
    }
}
