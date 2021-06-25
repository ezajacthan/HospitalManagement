/* Author: Ethan Zajac
 * AddPatientForm.cs
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
    /// Contains the fields to add a patient the the database
    /// </summary>
    public partial class AddPatientForm : Form
    {
        /// <summary>
        /// Constructs the form
        /// </summary>
        public AddPatientForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adds the patient to the database based on the given info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxAddPatientToDatabaseButton_Click(object sender, EventArgs e)
        {
            if (uxFirstBox.Text != "" && uxLastBox.Text != "" && uxPhoneBox.Text != "" && uxEmailBox.Text != "" && uxAddressBox.Text != "" && uxCountryBox.Text != "" && uxStateBox.Text != "" && uxCityBox.Text != "" && uxZipBox.Text != "" && uxEmergencyIDBox.Text != "" && uxAddSexBox.Text != "")
            {
                //get the data from the GUI
                string first = uxFirstBox.Text;
                string last = uxLastBox.Text;
                string phone = uxPhoneBox.Text;
                string email = uxEmailBox.Text;
                string address = uxAddressBox.Text;
                string city = uxCityBox.Text;
                string state = uxStateBox.Text;
                string zip = uxZipBox.Text;
                string country = uxCountryBox.Text;
                DateTime birthdate = uxBirthdatePicker.Value;
                int sex=-1;
                int emergencyId = -1;
                try
                {
                    sex = Convert.ToInt32(uxAddSexBox.Text);
                }
                catch(Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }
                try
                {
                    emergencyId = Convert.ToInt32(uxEmergencyIDBox.Text);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }
                //set up SQL connection
                string connectionString = @"Server=localhost\MSSQLSERVER01;Database=CIS560_FINAL_PROJECT;User ID=Ethan;
                                        Integrated Security=SSPI";
                var cnn = new SqlConnection(connectionString);

                var cmd = new SqlCommand("EXEC Hospital.AddPatient @First, @Last, @Phone, @Email, @Address, @City, @State, @Zip, @Country, @EmergencyID, @Birthdate, @Sex;", cnn);

                cmd.Parameters.AddWithValue("@First", first);
                cmd.Parameters.AddWithValue("@Last", last);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@City", city);
                cmd.Parameters.AddWithValue("@State", state);
                cmd.Parameters.AddWithValue("@Zip", zip);
                cmd.Parameters.AddWithValue("@Country", country);
                cmd.Parameters.AddWithValue("@Birthdate", birthdate);
                cmd.Parameters.AddWithValue("@EmergencyID", emergencyId);
                cmd.Parameters.AddWithValue("@Sex", sex);

                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data added");
                    cnn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("All data must be entered!");
            }
        }//end of add patient button click
    }
}
