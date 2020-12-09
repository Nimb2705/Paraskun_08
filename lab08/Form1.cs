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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {

        }

        private void btnAddAircraft_Click(object sender, EventArgs e)
        {
            Aircraft aircraft = new Aircraft();
            fAircraft ft = new fAircraft(aircraft); 

            if (ft.ShowDialog() == DialogResult.OK)
            {
                tbAircraftInfo.Text += string.Format("Назва літака: {0}. Кількість місць: {1}. Рік випуску: {2}. Ціна на білет: {3} грн. Країна виготовлення: {4}. {5}\r\n",

                    aircraft.AircraftName, aircraft.NumberSeats, aircraft.Age, aircraft.Price, aircraft.Country,aircraft.Autopilot ? "Цей літак має автопілот" : "Цей літак не має автопілоту") ;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Припинити роботу застосунку?",
            "Припинити роботу", MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question) == DialogResult.OK)
            Application.Exit();
        }
    }
}
