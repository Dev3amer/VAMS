using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsVaccineTypeData
    {
        public static bool GetVaccineInfoByID(int ID, ref string VaccineName, ref string VaccineDescription, ref int MinimumAllowedAge,
            ref float TypeFees)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM VaccineTypes WHERE VaccineTypeID = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    VaccineName = (string)reader["VaccineName"];
                    VaccineDescription = (string)reader["VaccineDescription"];
                    MinimumAllowedAge = Convert.ToInt32(reader["MinimumAllowedAge"]);
                    TypeFees = Convert.ToSingle(reader["TypeFees"]);

                }
                else
                {
                    isFound = false;
                }
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
        public static bool GetVaccineInfoByName(string VaccineName, ref int ID, ref string VaccineDescription, ref int MinimumAllowedAge,
            ref float TypeFees)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM VaccineTypes WHERE VaccineName = @VaccineName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@VaccineName", VaccineName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    ID = Convert.ToInt32(reader["VaccineTypeID"]);
                    VaccineDescription = (string)reader["VaccineDescription"];
                    MinimumAllowedAge = (int)reader["MinimumAllowedAge"];
                    TypeFees = Convert.ToSingle(reader["TypeFees"]);
                }
                else
                {
                    isFound = false;
                }
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
        public static DataTable GetAllVaccines()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM VaccineTypes order by VaccineTypeID";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();
            }
            catch (Exception ex){}
            finally
            {
                connection.Close();
            }
            return dt;
        }
        public static int AddNewVaccine(string VaccineName, string VaccineDescription,
             int MinimumAllowedAge, float TypeFees)
        {
            int VaccineTypeID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO VaccineTypes (VaccineName,VaccineDescription,MinimumAllowedAge,TypeFees)
                             VALUES (@VaccineName, @VaccineDescription,@MinimumAllowedAge,@TypeFees);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@VaccineName", VaccineName);
            command.Parameters.AddWithValue("@VaccineDescription", VaccineDescription);
            command.Parameters.AddWithValue("@MinimumAllowedAge", MinimumAllowedAge);
            command.Parameters.AddWithValue("@TypeFees", TypeFees);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    VaccineTypeID = insertedID;
                }
            }

            catch (Exception ex) { }

            finally
            {
                connection.Close();
            }

            return VaccineTypeID;
        }
        public static bool UpdateVaccine(int VaccineTypeID, string VaccineName, string VaccineDescription,
             int MinimumAllowedAge, float TypeFees)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update VaccineTypes  
                            set VaccineName = @VaccineName,
                                VaccineDescription = @VaccineDescription,
                                MinimumAllowedAge = @MinimumAllowedAge,
                                TypeFees = @TypeFees
                                where VaccineTypeID = @VaccineTypeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@VaccineName", VaccineName);
            command.Parameters.AddWithValue("@VaccineDescription", VaccineDescription);
            command.Parameters.AddWithValue("@MinimumAllowedAge", MinimumAllowedAge);
            command.Parameters.AddWithValue("@TypeFees", TypeFees);
            command.Parameters.AddWithValue("@VaccineTypeID", VaccineTypeID);


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
        public static bool DeleteVaccine(int VaccineTypeID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete VaccineTypes 
                                where VaccineTypeID = @VaccineTypeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@VaccineTypeID", VaccineTypeID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return (rowsAffected > 0);
        }
        public static bool IsVaccineExist(int VaccineID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM VaccineTypes WHERE VaccineID = @VaccineID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@VaccineID", VaccineID);

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
