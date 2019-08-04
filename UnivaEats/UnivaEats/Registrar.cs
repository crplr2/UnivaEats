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
    public partial class Registrar : Form
    {
        Usuario usuario;
        GestorUsuarios gestor;
        Form instanciador;
        public Registrar(Form instancia)
        {
            InitializeComponent();
            usuario = new Usuario();
            gestor = new GestorUsuarios(usuario);
            instanciador = instancia;
            
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void BntRegistrar_Click(object sender, EventArgs e)
        {
            //Valida que los campos no esten vacios 
            if (txtMatricula.Text == "" || txtNombre.Text == "" || txtApellidoP.Text == "" || txtApellidoM.Text == "" || txtPassword.Text == ""|| cbTipo.SelectedItem==null)
            {
                MessageBox.Show("Favor de llenar todos los campos", "Mensaje Error");
            }
            else
            {
                //Recolectamos de los txtbox los datos para registrar en base de datos 
                usuario = new Usuario();
                usuario.matricula = Convert.ToInt32(txtMatricula.Text);
                usuario.nombre = txtNombre.Text;
                usuario.apellidopaterno = txtApellidoP.Text;
                usuario.apellidomaterno = txtApellidoM.Text;
                usuario.password = txtPassword.Text;
                usuario.tipo = cbTipo.SelectedItem.ToString();
                gestor = new GestorUsuarios(usuario);
                if (gestor.insertarUsuario()) //Se comprueba que se haya introducido la informacion a la base de datos 
                {
                    MessageBox.Show("Usuario creado correctamente", "Mensaje");
                    limpiar();

                }
            }
        }

        private void Registrar_FormClosed(object sender, FormClosedEventArgs e)
        {
            //regresa al formulario anterior cuando cierras en la X
            instanciador.Show();
        }
        private void limpiar() //Limpia los campos del formulario registrar
        {
            
            txtMatricula.Clear();
            txtNombre.Clear();
            txtApellidoP.Clear();
            txtApellidoM.Clear();
            txtPassword.Clear();
            cbTipo.ResetText();
            
        }

 
    }
}
