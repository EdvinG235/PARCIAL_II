using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PARCIAL_II.PL
{
    public partial class FmrInicio : Form
    {
        public FmrInicio()
        {
            InitializeComponent();
        }

        private void btnfarmaciasedes_Click(object sender, EventArgs e)
        {
            FmrInicio fe = new FmrInicio();
            fe.Show();
        }

        private void btnInfoEmpleados_Click(object sender, EventArgs e)
        {
            FrmEmpleados fe = new FrmEmpleados();
            fe.Show();
        }
    }
}
