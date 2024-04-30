using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsPatientData
    {
        public static bool GetPatientInfoByPatientID(int PatientID, ref int PersonID, ref int VaccineTypeID,
            ref DateTime IssueDate, ref string Notes)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Patients WHERE PatientID = @PatientID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PatientID", PatientID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    PersonID = (int)reader["PersonID"];
                    VaccineTypeID = (int)reader["VaccineTypeID"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    Notes = reader["Notes"].ToString();
                }
                else
                    isFound = false;
                reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }

        public static bool GetPatientInfoByPersonID(int PersonID, ref int PatientID, ref int VaccineTypeID,
            ref DateTime IssueDate, ref string Notes)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Patients WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    PatientID = (int)reader["PatientID"];
                    VaccineTypeID = (int)reader["VaccineTypeID"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    Notes = reader["Notes"].ToString();
                }
                else
                    isFound = false;

                reader.Close();


            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
        public static int AddNewPatient(int PersonID, int VaccineTypeID,
             DateTime IssueDate, string Notes)
        {
            int UserID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Patients (PersonID,VaccineTypeID,IssueDate,Notes)
                             VALUES (@PersonID, @VaccineTypeID,@IssueDate,@Notes);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@VaccineTypeID", VaccineTypeID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            if(Notes != "")
                command.Parameters.AddWithValue("@Notes", Notes);
            else
                command.Parameters.AddWithValue("@Notes", DBNull.Value);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    UserID = insertedID;
            }
            catch (Exception ex){}

            finally
            {
                connection.Close();
            }
            return UserID;
        }

        public static bool UpdatePatient(int PatientID, int PersonID, int VaccineTypeID,
             DateTime IssueDate, string Notes)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update Patients  
                            set PersonID = @PersonID,
                                VaccineTypeID = @VaccineTypeID,
                                IssueDate = @IssueDate,
                                Notes = @Notes
                                where PatientID = @PatientID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@VaccineTypeID", VaccineTypeID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@Notes", Notes);
            command.Parameters.AddWithValue("@PatientID", PatientID);


            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return false;
            }

            finally
            {
                connection.Close();
            }
            return (rowsAffected > 0);
        }
        public static DataTable GetAllPatients()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT Patients.PatientID, People.NationalNo, People.FirstName+ ' ' + People.SecondName + ' ' +
		                            People.LastName AS 'Full Name', VaccineTypes.VaccineName, Patients.IssueDate, VaccineTypes.TypeFees
                            FROM   Patients INNER JOIN
						                        People ON Patients.PersonID = People.PersonID
						                        INNER JOIN
						                        VaccineTypes ON Patients.VaccineTypeID = VaccineTypes.VaccineTypeID;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    dt.Load(reader);
               
                reader.Close();
            }
            catch (Exception ex){}
            finally
            {
                connection.Close();
            }
            return dt;
        }
        public static bool DeletePatient(int PatientID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete Patients 
                                where PatientID = @PatientID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PatientID", PatientID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex){}
            finally{connection.Close();}
            return (rowsAffected > 0);
        }
        public static bool IsPatientExist(int PaitentID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Patients WHERE PaitentID = @PaitentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PaitentID", PaitentID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
        public static bool isPatientExistForPersonID(int PersonID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Patients WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
    }
}
