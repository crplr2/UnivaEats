using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnivaEats
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
             Registrar Registrarform = new Registrar(this);
            Registrarform.Show();
            this.Hide();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            Entrar Entrarform = new Entrar(this);
            Entrarform.Show();
            this.Hide();
        }

    }
}
