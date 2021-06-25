/* Author: Ethan Zajac
 * AddUpdatePage.cs
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

namespace ProjectApplication
{
    /// <summary>
    /// Contains all the forms to write to the database
    /// </summary>
    public partial class AddUpdatePage : Form
    {
        /// <summary>
        /// Constructs the form
        /// </summary>
        public AddUpdatePage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Opens the form to add a patient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxAddPatientButton_Click(object sender, EventArgs e)
        {
            AddPatientForm addPatient = new AddPatientForm();
            addPatient.Show();
        }

        /// <summary>
        /// Opens the form to add a doctor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxAddDoctorButton_Click(object sender, EventArgs e)
        {
            AddDoctorForm addDoctor = new AddDoctorForm();
            addDoctor.Show();
        }

        /// <summary>
        /// Opens the form to add a patient stay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxAddPatientStay_Click(object sender, EventArgs e)
        {
            AddPatientStayForm addPatientStay = new AddPatientStayForm();
            addPatientStay.Show();
        }

        /// <summary>
        /// Opens the form to add a contact
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxAddContactButton_Click(object sender, EventArgs e)
        {
            AddContactForm addContact = new AddContactForm();
            addContact.Show();
        }

        /// <summary>
        /// Opens the form to add a condition
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxAddConditionButton_Click(object sender, EventArgs e)
        {
            AddConditionForm addCondition = new AddConditionForm();
            addCondition.Show();
        }

        /// <summary>
        /// Opens the form to add a treatment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxAddTreatmentButton_Click(object sender, EventArgs e)
        {
            AddTreatementForm addTreatment = new AddTreatementForm();
            addTreatment.Show();
        }
    }
}
