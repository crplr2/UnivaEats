using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnivaEats.Classes;

namespace UnivaEats
{
    public partial class Cocina : Form
    {
        Form instanciador;
        Pedidos pedido;
        GestorPedidos gestor;
        public Cocina(Form instancia)
        {
            InitializeComponent();
            instanciador = instancia;
            pedido = new Pedidos();
            gestor = new GestorPedidos(pedido);
            tmrTiempo.Start();
        }

        private void Cocina_FormClosed(object sender, FormClosedEventArgs e)
        {
            instanciador.Show();
        }

        private void Timer1_Tick(object sender, EventArgs e) //Tiene un timer para que se este actualizando la consulta en de la base de datos 
        {
            dgvPedidos.DataSource = gestor.SeleccionarPedidos();
        }
    }
}
