using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotto
{
    public partial class Form1 : Form
    {
        Logic oLogic = new Logic();
        public Form1()
        {
            InitializeComponent();        
        
        }

        private void losuj1_Click(object sender, EventArgs e)
        {
            oLogic.Losuj();
            label1.Text = oLogic.Wynik;
            label1.Visible = true;
        }
    }
}
