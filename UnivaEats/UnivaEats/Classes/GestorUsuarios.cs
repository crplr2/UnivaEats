using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnivaEats.Classes;
using System.Data;
using GestorBD;

namespace UnivaEats.Classes
{
    class GestorUsuarios
    { 
         public Usuario instancia;
         public Tabla tabla;
         Operaciones operaciones;
        public GestorUsuarios(Usuario usuario)
        {
            instancia = usuario;
            operaciones = new Operaciones("bdtest");
            tabla = new Tabla();
            tabla.Nombre = "Usuarios";
            tabla.Campos = new List<Campo>()

            {
                new Campo()
                {
                    Nombre = "Usuario_Matricula",
                    Valor = instancia.matricula,
                },
                new Campo()
                {
                    Nombre = "Usuario_Nombre",
                    Valor = instancia.nombre,
                },
                new Campo()
                {
                    Nombre = "Usuario_ApellidoPaterno",
                    Valor = instancia.apellidopaterno,
                },
                new Campo()
                {
                    Nombre = "Usuario_ApellidoMaterno",
                    Valor = instancia.apellidomaterno,
                },
                new Campo()
                {
                    Nombre = "Usuario_Password",
                    Valor = instancia.password,
                },
                new Campo()
                {
                    Nombre = "Usuario_Tipo",
                    Valor = instancia.tipo,
                }
            };
            operaciones.Entidad = tabla;
        }
        public bool insertarUsuario()
        {
            LimpiarFiltros();
            return operaciones.Insertar();
        }

        public bool ActualizarUsuario()
        {
            LimpiarFiltros();
            tabla.Campos.FirstOrDefault(x => x.Nombre == "Usuario_Password").Filtro = true;
            var actualizable = new string[1] { "Usuario_Password"};
           
            foreach (var campo in actualizable)
            {
                tabla.Campos.FirstOrDefault(x => x.Nombre == campo).Actualizable = true;
            }
            return operaciones.Actualizar();
        }
        public DataTable SeleccionarUsuarios()
        {
            LimpiarFiltros();
            return operaciones.Seleccionar();
        }

        private void LimpiarFiltros()
        {
            foreach (var campo in tabla.Campos)
            {
                campo.Filtro = false;
                campo.Actualizable = false;
            }
        }
        public int EjecutarFuncion(string Nombre, List<Campo> Parametros)
        {
            return (int)operaciones.Ejecutar(Nombre, Parametros);
        }
    }
}


