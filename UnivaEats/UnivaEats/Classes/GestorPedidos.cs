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
    class GestorPedidos
    {
        public Pedidos instancia;
        public Tabla tabla;
        Operaciones operaciones;

        public GestorPedidos(Pedidos pedido)
        {
            instancia = pedido;
            operaciones = new Operaciones("bdtest");
            tabla = new Tabla();
            tabla.Nombre = "Pedidos";

            tabla.Campos = new List<Campo>()

            {
                new Campo()
                {
                    Nombre = "Pedidos_Matricula",
                    Valor = instancia.matricula,
                },
                 new Campo()
                {
                    Nombre = "Pedidos_Pedido",
                    Valor = instancia.pedido,
                },
                new Campo()
                {
                    Nombre = "Pedidos_Total",
                    Valor = instancia.total,
                },
                new Campo()
                {
                    Nombre = "Pedidos_Fecha",
                    Valor = instancia.fecha,
                }
            };
            operaciones.Entidad = tabla;
        }
        public bool insertarPedidos()
        {
            return operaciones.Insertar();
        }
        public DataTable SeleccionarPedidos()
        {
            
            return operaciones.Seleccionar();
        }
    }

}
