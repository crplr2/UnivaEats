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
    public partial class Menu : Form
    {
        Form instanciador;
        int Total = 0;
        Pedidos pedido;
        GestorPedidos gestor;




        public Menu(Form instancia) 
        {
            InitializeComponent();
            instanciador = instancia;
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            instanciador.Show();
        }

        private void CbxCafes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Al seleccionar cualquier articulo del combobox de los cafes, muestra en el label precio el precio del articulo que seleecionaste
             switch (cbxCafes.SelectedItem.ToString())
            {
                case "Americano":
                    lblPrecio.Text = "18";
                    break;

                case "Capuchino":
                    lblPrecio.Text = "25";
                    break;

                case "Expresso":
                    lblPrecio.Text = "18";
                    break;

                case "Expresso Doble":
                    lblPrecio.Text = "25";
                    break;

                case "Frappe":
                    lblPrecio.Text = "29";
                    break;

                case "Mocka Frappe":
                    lblPrecio.Text = "29";
                    break;
            }
        }

        private void CbxPanes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //igual que el combo box de cafe
            switch (cbxPanes.SelectedItem.ToString())
            {
                case "Minbon":
                    lblPrecio.Text = "25";
                    break;

                case "Mini Peackabon":
                    lblPrecio.Text = "29";
                    break;

                case "Cinnabon":
                    lblPrecio.Text = "33";
                    break;

                case "Peackabon":
                    lblPrecio.Text = "29";
                    break;
            }
        }

        private void CbxRefrescos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //igual que el combo box de cafe
            switch (cbxRefrescos.SelectedItem.ToString())
            {
                case "Lata":
                    lblPrecio.Text = "12";
                    break;

                case "600 ml":
                    lblPrecio.Text = "15";
                    break;

                case "Agua 500 ml":
                    lblPrecio.Text = "10";
                    break;
            }

        }

        private void CbxHelados_SelectedIndexChanged(object sender, EventArgs e)
        {
            //igual que el combo box de cafe
            switch (cbxHelados.SelectedItem.ToString())
            {
                case "Chocolate Sencillo":
                    lblPrecio.Text = "17";
                    break;

                case "Chocolate Doble":
                    lblPrecio.Text = "25";
                    break;

                case "Vainilla Sencillo":
                    lblPrecio.Text = "17";
                    break;

                case "Vainilla Doble":
                    lblPrecio.Text = "25";
                    break;

                case "Chocochips Sencillo":
                    lblPrecio.Text = "17";
                    break;

                case "Chocochips Doble":
                    lblPrecio.Text = "25";
                    break;

                case "Galleta Oreo Sencillo":
                    lblPrecio.Text = "17";
                    break;

                case "Galleta Oreo Doble":
                    lblPrecio.Text = "25";
                    break;
            }
        }

        private void BtnAgregarCafes_Click(object sender, EventArgs e)
        {
            //Agrega los items a la lista del pedido y va sumando los precios para sacar un total 
            lstPedido.Items.Add(cbxCafes.SelectedItem.ToString());
            lstPrecio.Items.Add(lblPrecio.Text);
            Total = Total + int.Parse(lblPrecio.Text.ToString());
            lblTotal.Text = Total.ToString();
            cbxCafes.ResetText();
        }

        private void BtnAgregarPanes_Click(object sender, EventArgs e)
        {
            //Lo mismo que en boton agregar Cafes
            lstPedido.Items.Add(cbxPanes.SelectedItem.ToString());
            lstPrecio.Items.Add(lblPrecio.Text);
            Total = Total + int.Parse(lblPrecio.Text.ToString());
            lblTotal.Text = Total.ToString();
            cbxPanes.ResetText();
        }

        private void BtnAgregarRefrescos_Click(object sender, EventArgs e)
        {
            //Lo mismo que en boton agregar Cafes
            lstPedido.Items.Add(cbxRefrescos.SelectedItem.ToString());
            lstPrecio.Items.Add(lblPrecio.Text);
            Total = Total + int.Parse(lblPrecio.Text.ToString());
            lblTotal.Text = Total.ToString();
            cbxRefrescos.ResetText();
        }

        private void BtnAgregarHelados_Click(object sender, EventArgs e)
        {
            //Lo mismo que en boton agregar Cafes
            lstPedido.Items.Add(cbxHelados.SelectedItem.ToString());
            lstPrecio.Items.Add(lblPrecio.Text);
            Total = Total + int.Parse(lblPrecio.Text.ToString());
            lblTotal.Text = Total.ToString();
            cbxHelados.ResetText();
        }

        private void BtnOrdenar_Click(object sender, EventArgs e) //Este boton genera la orden en la base de datos 
        {
            string cadpedido = "";
            pedido = new Pedidos();
            pedido.matricula = int.Parse(lblUsuario.Text.ToString());// se toma la matricula del label usuario
            for(int i=0; lstPedido.Items.Count> i; i++) //se lee toda la lista del pedido
            {
                cadpedido = cadpedido + lstPedido.Items[i].ToString() + ", ";
            }
            pedido.pedido = cadpedido;// se envia la cadena del pedido 
            pedido.total = lblTotal.Text;
            pedido.fecha = DateTime.Now;
            gestor = new GestorPedidos(pedido);
            if (gestor.insertarPedidos()) //Verifica que los datos sean inserados de manera correcta en BD
            {
                MessageBox.Show("El Pedido se envio correctamente", "Mensaje");
                limpiar();

            }

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void limpiar()
        {
            cbxCafes.ResetText();
            cbxPanes.ResetText();
            cbxRefrescos.ResetText();
            cbxHelados.ResetText();
            lblPrecio.Text = "";
            lblTotal.Text = "";
            lstPedido.Items.Clear();
            lstPrecio.Items.Clear();

        }
    }
}
