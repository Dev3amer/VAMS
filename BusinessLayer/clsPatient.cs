using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsPatient
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int PatientID { set; get; }
        public int PersonID { set; get; }
        public clsPerson PersonInfo;
        public int VaccineTypeID { set; get; }
        public DateTime IssueDate { set; get; }
        public string Notes { set; get; }

        public clsPatient()
        {
            this.PatientID = -1;
            this.VaccineTypeID = -1;
            this.IssueDate = DateTime.MinValue;
            this.Notes = "";
            Mode = enMode.AddNew;
        }

        private clsPatient(int PatientID, int PersonID, int VaccineTypeID, DateTime IssueDate,
            string Notes)
        {
            this.PatientID = PatientID;
            this.PersonID = PersonID;
            this.PersonInfo = clsPerson.Find(PersonID);
            this.VaccineTypeID = VaccineTypeID;
            this.IssueDate = IssueDate;
            this.Notes = Notes;

            Mode = enMode.Update;
        }

        private bool _AddNewPatient()
        {
            this.PatientID = clsPatientData.AddNewPatient(this.PersonID, this.VaccineTypeID,
                this.IssueDate, this.Notes);

            return (this.PatientID != -1);
        }
        private bool _UpdatePatient()
        {
            return clsPatientData.UpdatePatient(this.PatientID, this.PersonID, this.VaccineTypeID,
                this.IssueDate, this.Notes);
        }
        public static clsPatient FindByPatientID(int PatientID)
        {
            int PersonID = -1;
            int VaccineTypeID = -1;
            DateTime IssueDate = DateTime.MinValue;
            string Notes = "";

            bool IsFound = clsPatientData.GetPatientInfoByPatientID
                                (PatientID, ref PersonID, ref VaccineTypeID, ref IssueDate, ref Notes);

            if (IsFound)
                return new clsPatient(PatientID, PersonID, VaccineTypeID, IssueDate, Notes);
            else
                return null;
        }
        public static clsPatient FindByPersonID(int PersonID)
        {
            int PatientID = -1;
            int VaccineTypeID = -1;
            DateTime IssueDate = DateTime.MinValue;
            string Notes = "";

            bool IsFound = clsPatientData.GetPatientInfoByPersonID
                                (PersonID, ref PatientID, ref VaccineTypeID, ref IssueDate, ref Notes);

            if (IsFound)
                return new clsPatient(PersonID, PatientID, VaccineTypeID, IssueDate, Notes);
            else
                return null;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPatient())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdatePatient();
            }

            return false;
        }

        public static DataTable GetAllPatients()
        {
            return clsPatientData.GetAllPatients();
        }

        public static bool DeletePatient(int PatientID)
        {
            return clsPatientData.DeletePatient(PatientID);
        }

        public static bool isPatientExist(int PatientID)
        {
            return clsPatientData.IsPatientExist(PatientID);
        }
        public static bool isPatientExistForPersonID(int PersonID)
        {
            return clsPatientData.isPatientExistForPersonID(PersonID);
        }
    }
}
