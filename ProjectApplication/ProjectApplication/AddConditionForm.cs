/* Author: Ethan Zajac
 * AddConditionForm.cs
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
    /// Contains the fields to add a condition to the database
    /// </summary>
    public partial class AddConditionForm : Form
    {
        /// <summary>
        /// Constructs the form
        /// </summary>
        public AddConditionForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adds the condition to the database based on the given info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxAddConditionToDatabaseButton_Click(object sender, EventArgs e)
        {
            if(uxCommonBox.Text != "" && uxTechnicalBox.Text != "")
            {

                //get the data from the GUI
                string commonName = uxCommonBox.Text;
                string tech = uxTechnicalBox.Text;

                //set up SQL connection
                string connectionString = @"Server=localhost\MSSQLSERVER01;Database=CIS560_FINAL_PROJECT;User ID=Ethan;
                                        Integrated Security=SSPI";
                var cnn = new SqlConnection(connectionString);

                var cmd = new SqlCommand("EXEC Hospital.AddCondition @CommonName, @TechnicalName;", cnn);

                cmd.Parameters.AddWithValue("@CommonName", commonName);
                cmd.Parameters.AddWithValue("@TechnicalName", tech);


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
