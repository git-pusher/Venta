using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Venta
    {
        private string cliente;
        private DateTime fecha;
        private List<Producto> productos;
        //usando Ctrl + r e para empaquetar
        public List<Producto> Productos
        {
            //usamos sólo get porque será únicamente de lectura
            get { return productos; }            
        }

        public Venta(string cliente)
        {
            this.cliente = cliente;
            this.fecha = DateTime.Now;
            this.productos = new List<Producto>();
        }


        //De la clase Producto paso un producto
        public void AgregarProducto(Producto producto)
        {
            productos.Add(producto);
        }
        public decimal Total()
        {
            decimal total = 0;
            foreach (Producto producto in productos)
            {
                total += producto.Valor;
            }
            return total;
        }
    }
}
