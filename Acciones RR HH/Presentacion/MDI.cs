using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Acciones_RR_HH.Presentacion;

namespace Acciones_RR_HH
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void controlDePagosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reg_Entr_Sal fRegEntSal = new Reg_Entr_Sal();
            fRegEntSal.MdiParent = this;
            fRegEntSal.Show();
        }

        private void marcarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reg_Entr_Sal_Ingr fRegEmpEntSal = new Reg_Entr_Sal_Ingr();
            fRegEmpEntSal.MdiParent = this;
            fRegEmpEntSal.Show();
        }   
    }
}
