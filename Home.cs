using System;
using System.Drawing;
using System.Windows.Forms;

namespace CinemaBookingSystem
{
    public partial class Home : Form
    {
        // Constructor.
        public Home()
        {
            InitializeComponent();
        }

        // Click handler for Normal Mode.
        private void normalModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Checks if there are any open child forms.
            if (ActiveMdiChild != null)
            {
                // Closes active child form.
                ActiveMdiChild.Close();
            }

            // Creates new Normal Mode form.
            NormalMode newMDIChild = new NormalMode();

            // Set current window as parent window.
            newMDIChild.MdiParent = this;

            // Display the new form.
            newMDIChild.Show();

            // Set position of form.
            newMDIChild.Location = new Point(10, 10);
        }

        // Click handler for Safe Distancing Mode.
        private void safeDistancingModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Checks if there are any open child forms.
            if (ActiveMdiChild != null)
            {
                // Closes active child form.
                ActiveMdiChild.Close();
            }

            // Create new Safe Distancing Mode form.
            SafeDistancing newMDIChild = new SafeDistancing();

            // Set current window as parent window.
            newMDIChild.MdiParent = this;

            // Display the new form.
            newMDIChild.Show();

            // Set position of form.
            newMDIChild.Location = new Point(10, 10);
        }

        // Click handler for Smart Mode.
        private void smartModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Checks if there are any open child forms.
            if (ActiveMdiChild != null)
            {
                // Closes active child form.
                ActiveMdiChild.Close();
            }

            // Create new Smart Mode form.
            SmartMode newMDIChild = new SmartMode();

            // Set current window as parent window.
            newMDIChild.MdiParent = this;

            // Display the new form.
            newMDIChild.Show();

            // Set position of form.
            newMDIChild.Location = new Point(10, 10);
        }
    }
}
