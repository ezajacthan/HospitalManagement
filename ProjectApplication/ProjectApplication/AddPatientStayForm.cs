/* Author: Ethan Zajac
 * AddPatientStayForm.cs
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
    /// Contains field to add a patient stay to the database
    /// </summary>
    public partial class AddPatientStayForm : Form
    {
        /// <summary>
        /// Constructs the form
        /// </summary>
        public AddPatientStayForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adds the patient stay to the database based on the given info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxAddPatientStayToDatabaseButton_Click(object sender, EventArgs e)
        {
            if (uxConditionBox.Text != "" && uxDoctorIDBox.Text != "" && uxPatientIDBox.Text != "" && uxRoomNumberBox.Text != "" && uxTreatmentBox.Text != "" && uxUnitBox.Text != "" )
            {
                //get the data from the GUI
                string patientId = uxPatientIDBox.Text;
                DateTime addmittanceDate = dateTimePicker1.Value;
                string DoctorId = uxDoctorIDBox.Text;
                DateTime dischargeDate = dateTimePicker2.Value;
                string room = uxRoomNumberBox.Text;
                string unit = uxUnitBox.Text;
                int condition = -1;
                int treatment = -1;

                try
                {
                    condition = Convert.ToInt32(uxConditionBox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                try
                {
                    treatment= Convert.ToInt32(uxTreatmentBox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                //set up SQL connection
                string connectionString = @"Server=localhost\MSSQLSERVER01;Database=CIS560_FINAL_PROJECT;User ID=Ethan;
                                        Integrated Security=SSPI";
                var cnn = new SqlConnection(connectionString);

                var cmd = new SqlCommand("EXEC Hospital.AddPatientStay @PatientID, @AdmittanceDate, @DischargeDate, @Unit, @RoomNumber, @ConditionID, @DoctorID, @TreatmentID;", cnn);

                cmd.Parameters.AddWithValue("@PatientId", patientId);
                cmd.Parameters.AddWithValue("@AdmittanceDate", addmittanceDate);
                cmd.Parameters.AddWithValue("@DischargeDate", dischargeDate);
                cmd.Parameters.AddWithValue("@Unit", unit);
                cmd.Parameters.AddWithValue("@RoomNumber", room);
                cmd.Parameters.AddWithValue("@ConditionID", condition);
                cmd.Parameters.AddWithValue("@DoctorID", DoctorId);
                cmd.Parameters.AddWithValue("@TreatmentID", treatment);


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
        }

        private void uxConditionLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
