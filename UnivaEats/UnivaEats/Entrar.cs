using GestorBD;
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
    public partial class Entrar : Form
    {
        Form instanciador;
        int intentos = 0;
        public int matriculamenu;
        public Entrar(Form instancia)
        {
            InitializeComponent();
            instanciador = instancia;
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            GestorUsuarios gestor = new GestorUsuarios(usuario);

            //Verificamos que los campos no esten vacios
            if (txtMatricula.Text == "" || txtPassword.Text == "" || cbTipo.SelectedItem == null)
            {
                MessageBox.Show("Error en Usuario y/o contraseña");
                intentos = intentos + 1;
                lblIntentos.Text = intentos.ToString();
                if (intentos == 3)
                {
                    this.Close();
                    instanciador.Show();
                }
            }
            else //comprobamos los datos sean correctos en la bse de datos 
            {
                var campos = new List<Campo>()

            {
                new Campo()
                {
                    Nombre = "Matricula",
                    Valor = txtMatricula.Text,
                },
                new Campo()
                {
                    Nombre = "Password",
                    Valor = txtPassword.Text,
                },
                new Campo()
                {
                    Nombre = "Tipo",
                    Valor = cbTipo.SelectedItem.ToString(),
                }
           };

                var login = gestor.EjecutarFuncion("Login", campos);
                if (login == 1)
                {
                    //si el usuario esta como cocinero manda al form cocina
                    if (cbTipo.SelectedItem.ToString() == "Cocinero")
                    {
                        Cocina Cocinaform = new Cocina(this);
                        Cocinaform.Show();
                        this.Hide();
                        matriculamenu = int.Parse(txtMatricula.Text.ToString());
                        

                    } // Si el usuario esta como usuario manda al formulario menu
                    if (cbTipo.SelectedItem.ToString() == "Usuario")
                    {
                        Menu Menuform = new Menu(this);
                        Menuform.lblUsuario.Text = txtMatricula.Text.ToString(); //MAnda la matricula al formulario Menu para que lo muestre en la parte de arriba
                        Menuform.Show();
                        this.Hide();
                        limpiar();
                    }

                }
                else //si existe un error en matricula, password o tipo de usuario marca un error 
                {
                    MessageBox.Show("Error en Usuario y/o contraseña");
                    intentos = intentos + 1;
                    lblIntentos.Text = intentos.ToString();
                    if (intentos == 3) //si existen 3 intentos erroneos te saca del formulario y te regresa al formulario anterior 
                    {
                        this.Close();
                        instanciador.Show();
                    }
                }
            }
        }

        private void Entrar_FormClosed(object sender, FormClosedEventArgs e)
        {
            instanciador.Show();
        }
        private void limpiar()
        {
            txtMatricula.Clear();
            txtPassword.Clear();
            cbTipo.ResetText();
            lblIntentos.Text = "0";

        }
    }
}
