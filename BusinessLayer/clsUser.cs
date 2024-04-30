using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsUser
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public enum enPermissions
        {
            All = -1, ManagePeople = 1, ManagePatient = 2, ManageApplication = 4, ManageUsers = 8
        };
        public int UserID { set; get; }
        public string UserName { set; get; }
        public string Password { set; get; }
        public bool IsActive { set; get; }
        public int Permissions { set; get; }

        public clsUser()
        {
            this.UserID = -1;
            this.UserName = "";
            this.Password = "";
            this.IsActive = true;
            this.Permissions = 0;
            Mode = enMode.AddNew;
        }

        private clsUser(int UserID, string Username, string Password,
            bool IsActive, int Permissions)

        {
            this.UserID = UserID;
            this.UserName = Username;
            this.Password = Password;
            this.IsActive = IsActive;
            this.Permissions = Permissions;
            Mode = enMode.Update;
        }

        private bool _AddNewUser()
        {
            this.UserID = clsUserData.AddNewUser( this.UserName,
                this.Password, this.IsActive, this.Permissions);

            return (this.UserID != -1);
        }
        private bool _UpdateUser()
        {
            return clsUserData.UpdateUser(this.UserID, this.UserName,
                this.Password, this.IsActive, this.Permissions);
        }
        public static clsUser FindByUserID(int UserID)
        {
            string UserName = "", Password = "";
            bool IsActive = false;
            int Permissions = 0;

            bool IsFound = clsUserData.GetUserInfoByUserID
                                (UserID, ref UserName, ref Password, ref IsActive, ref Permissions);

            if (IsFound)
                return new clsUser(UserID, UserName, Password, IsActive, Permissions);
            else
                return null;
        }
        
        public static clsUser FindByUsernameAndPassword(string UserName, string Password)
        {
            int UserID = -1;
            bool IsActive = false;
            int Permissions = 0;

            bool IsFound = clsUserData.GetUserInfoByUsernameAndPassword
                                (UserName, Password, ref UserID, ref IsActive, ref Permissions);

            if (IsFound)
                return new clsUser(UserID, UserName, Password, IsActive, Permissions);
            else
                return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateUser();
            }

            return false;
        }

        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }

        public static bool DeleteUser(int UserID)
        {
            return clsUserData.DeleteUser(UserID);
        }

        public static bool isUserExist(int UserID)
        {
            return clsUserData.IsUserExist(UserID);
        }

        public static bool isUserExist(string UserName)
        {
            return clsUserData.IsUserExist(UserName);
        }

        public bool CheckAccessPermission(int Permission)
        {
            Console.WriteLine(clsGlobal.CurrentUser.UserID);
            if (clsGlobal.CurrentUser.Permissions == Convert.ToInt32(enPermissions.All))
                return true;

            if ((Permission & clsGlobal.CurrentUser.Permissions) == Permission)
                return true;
            else
                return false;
        }
    }
}
