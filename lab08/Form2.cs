using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab08
{
    
    public partial class fAircraft : Form
    {
        public Aircraft TheAircraft;
        public fAircraft( Aircraft t)
        {
            TheAircraft = t;
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        
        {
            

            TheAircraft.AircraftName = tbAircraftName.Text.Trim();
            TheAircraft.NumberSeats = tbNumberSeats.Text.Trim();
            TheAircraft.Age = tbAge.Text.Trim();
            
            TheAircraft.Price = int.Parse(tbPrice.Text.Trim());
            TheAircraft.Country = tbCountry.Text.Trim();
            TheAircraft.Autopilot = cbhAutopilot.Checked;
            DialogResult = DialogResult.OK;

            AcceptButton = btnOk;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            CancelButton = btnCancel;
        }

        private void ManufacturerCountry_TextChanged(object sender, EventArgs e)
        {

        }

        private void fAircraft_Load(object sender, EventArgs e)
        {
            if (TheAircraft != null)
            {
                tbAircraftName.Text = TheAircraft.AircraftName;
                tbNumberSeats.Text = TheAircraft.NumberSeats;
                tbAge.Text = TheAircraft.Age;
                
                tbPrice.Text = TheAircraft.Price.ToString();
                tbCountry.Text = TheAircraft.Country;
                cbhAutopilot.Checked = TheAircraft.Autopilot;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbAirlineName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
