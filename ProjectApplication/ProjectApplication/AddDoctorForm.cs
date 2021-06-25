/* Author: Ethan Zajac
 * AddDoctorForm.cs
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectApplication
{
    /// <summary>
    /// Contains field to add a doctor to the database
    /// </summary>
    public partial class AddDoctorForm : Form
    {
        /// <summary>
        /// Constructs the form
        /// </summary>
        public AddDoctorForm()
        {
            InitializeComponent();
        }

        private void uxPhoneLabel_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Adds the doctor to the database based on the given info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxAddDoctorToDatabaseButton_Click(object sender, EventArgs e)
        {
            if (uxFirstBox.Text != "" && uxLastBox.Text != "" && uxPhoneBox.Text != "" && uxEmailBox.Text != "" && uxAddressBox.Text != "" && uxCountryBox.Text != "" && uxStateBox.Text != "" && uxCityBox.Text != "" && uxZipBox.Text != "" && uxUnitBox.Text !="" && uxDegreeBox.Text != "")
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
                DateTime startdate = uxStartDatePicker.Value;
                string degree = uxDegreeBox.Text;
                string unit = uxUnitBox.Text;

                //set up SQL connection
                string connectionString = @"Server=localhost\MSSQLSERVER01;Database=CIS560_FINAL_PROJECT;User ID=Ethan;
                                        Integrated Security=SSPI";
                var cnn = new SqlConnection(connectionString);

                var cmd = new SqlCommand("EXEC Hospital.AddDoctor @First, @Last, @Phone, @Email, @Address, @City, @State, @Zip, @Country, @Startdate, @Degree, @Unit;", cnn);

                cmd.Parameters.AddWithValue("@First", first);
                cmd.Parameters.AddWithValue("@Last", last);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@City", city);
                cmd.Parameters.AddWithValue("@State", state);
                cmd.Parameters.AddWithValue("@Zip", zip);
                cmd.Parameters.AddWithValue("@Country", country);
                cmd.Parameters.AddWithValue("@Startdate", startdate);
                cmd.Parameters.AddWithValue("@Degree", degree);
                cmd.Parameters.AddWithValue("@Unit", unit);

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
                MessageBox.Show("All data fields must be entered!");
            }
        }
    }
}
