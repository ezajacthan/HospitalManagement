/* Author: Justin Schieber
 * SearchPage.cs
 */
 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectApplication
{
    /// <summary>
    /// Contains the ability to read from the database
    /// </summary>
    public partial class SearchPage : Form
    {
        /// <summary>
        /// The string to connect to the database
        /// </summary>
        private string connectionString;

        /// <summary>
        /// Contructs the search page
        /// </summary>
        public SearchPage()
        {
            InitializeComponent();
            this.ActiveControl = uxPatientFirstName;
            connectionString = @"Server=localhost\MSSQLSERVER01;Database=CIS560_FINAL_PROJECT;User ID=Ethan;
                                        Integrated Security=SSPI";
        }

        /// <summary>
        /// Displays patient stays in the results grid based on the given info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxGetPatientStays_Click(object sender, EventArgs e)
        {
            string firstName = uxPatientFirstName.Text;
            string lastName = uxPatientLastName.Text;
            DateTime birthDate = uxPatientBirthDate.Value;

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("Hospital.GetPatientStays", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@BirthDate", birthDate);
                  
                    connection.Open();
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        uxResultsGrid.DataSource = dataTable;
                    }
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// Displays patient info in the results grid based on the given info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxGetPatientInfo_Click(object sender, EventArgs e)
        {
            string firstName = uxPatientFirstName.Text;
            string lastName = uxPatientLastName.Text;
            DateTime birthDate = uxPatientBirthDate.Value;

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("Hospital.GetPatientInfo", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@BirthDate", birthDate);

                    connection.Open();
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        uxResultsGrid.DataSource = dataTable;
                    }
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// Displays patient doctors in the results grid based on the given info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxGetPatientDoctors_Click(object sender, EventArgs e)
        {
            string firstName = uxPatientFirstName.Text;
            string lastName = uxPatientLastName.Text;
            DateTime birthDate = uxPatientBirthDate.Value;

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("Hospital.GetDoctorByPatient", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@BirthDate", birthDate);

                    connection.Open();
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        uxResultsGrid.DataSource = dataTable;
                    }
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// Displays patient conditions in the results grid based on the given info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxGetPatientConditions_Click(object sender, EventArgs e)
        {
            string firstName = uxPatientFirstName.Text;
            string lastName = uxPatientLastName.Text;
            DateTime birthDate = uxPatientBirthDate.Value;

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("Hospital.GetConditionByPatientName", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@BirthDate", birthDate);

                    connection.Open();
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        uxResultsGrid.DataSource = dataTable;
                    }
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// Displays patient emergency contact info in the results grid based on the given info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxGetPatientEmergencyContactInfo_Click(object sender, EventArgs e)
        {
            string firstName = uxPatientFirstName.Text;
            string lastName = uxPatientLastName.Text;
            DateTime birthDate = uxPatientBirthDate.Value;

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("Hospital.GetPatientEmergencyContactInfo", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@BirthDate", birthDate);

                    connection.Open();
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        uxResultsGrid.DataSource = dataTable;
                    }
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// Displays patient treatments in the results grid based on the given info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxGetPatientTreatments_Click(object sender, EventArgs e)
        {
            string firstName = uxPatientFirstName.Text;
            string lastName = uxPatientLastName.Text;
            DateTime birthDate = uxPatientBirthDate.Value;

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("Hospital.GetTreatmentByPatientName", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@BirthDate", birthDate);

                    connection.Open();
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        uxResultsGrid.DataSource = dataTable;
                    }
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// Displays doctor info in the results grid based on the given info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxGetDoctorInfo_Click(object sender, EventArgs e)
        {
            string firstName = uxDoctorFirstName.Text;
            string lastName = uxDoctorLastName.Text;
            string unit = uxDoctorUnit.Text;

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("Hospital.GetDoctorInfo", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Unit", unit);

                    connection.Open();
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        uxResultsGrid.DataSource = dataTable;
                    }
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// Displays doctor patients in the results grid based on the given info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxGetDoctorPatients_Click(object sender, EventArgs e)
        {
            string firstName = uxDoctorFirstName.Text;
            string lastName = uxDoctorLastName.Text;
            string unit = uxDoctorUnit.Text;

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("Hospital.GetPatientByDoctor", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Unit", unit);

                    connection.Open();
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        uxResultsGrid.DataSource = dataTable;
                    }
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// Displays doctor condition history in the results grid based on the given info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxGetDoctorConditionHistory_Click(object sender, EventArgs e)
        {
            string firstName = uxDoctorFirstName.Text;
            string lastName = uxDoctorLastName.Text;
            string unit = uxDoctorUnit.Text;

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("Hospital.GetDoctorConditionHistory", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Unit", unit);

                    connection.Open();
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        uxResultsGrid.DataSource = dataTable;
                    }
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// Displays condition doctors in the results grid based on the given info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxGetConditionDoctors_Click(object sender, EventArgs e)
        {
            string commonName = uxConditionCommonName.Text;

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("Hospital.GetDoctorTreatingConditionWithComTreatment", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@ConditionName", commonName);

                    connection.Open();
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        uxResultsGrid.DataSource = dataTable;
                    }
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// Displays condition history in the results grid based on the given info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxGetConditionHistory_Click(object sender, EventArgs e)
        {
            string commonName = uxConditionCommonName.Text;

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("Hospital.GetHospitalConditionHistory", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@ConditionName", commonName);

                    connection.Open();
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        uxResultsGrid.DataSource = dataTable;
                    }
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// Displays condition patients in the results grid based on the given info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxGetConditionPatients_Click(object sender, EventArgs e)
        {
            string commonName = uxConditionCommonName.Text;

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("Hospital.GetPatientsWithConditionByDoctor", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@ConditionName", commonName);

                    connection.Open();
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        uxResultsGrid.DataSource = dataTable;
                    }
                    connection.Close();
                }
            }
        }
    }
}
