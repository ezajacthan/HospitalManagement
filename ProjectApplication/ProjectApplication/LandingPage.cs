/* Author: Justin Schieber
 * LandingPage.cs
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
    /// The landing page to select an action
    /// </summary>
    public partial class LandingPage : Form
    {
        /// <summary>
        /// Contructs the landing page
        /// </summary>
        public LandingPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Directs the user to the search page to read from the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSearch_Click(object sender, EventArgs e)
        {
            SearchPage searchPage = new SearchPage();
            searchPage.Show();
        }

        /// <summary>
        /// Directs the user to the add/update page to write to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxAddUpdate_Click(object sender, EventArgs e)
        {
            AddUpdatePage addUpdatePage = new AddUpdatePage();
            addUpdatePage.Show();
        }
    }
}
