using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentadeBebidas.Context;
using VentadeBebidas.Entities;

namespace VentadeBebidas.Services
{
    public class ProductoServices
    {
        public void AddProducto(Productos producto)
        {
            try
            {
                using (var _context = new AplicationDbContext())
                {
                    _context.productos.Add(producto);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error al agregar el producto: " + ex.Message);
            }
        }

        public List<Productos> GetProductos()
        {
            try
            {
                using (var _context = new AplicationDbContext())
                {
                    return _context.productos.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error al obtener los productos: " + ex.Message);
            }
        }

        public void EditProducto(Productos producto)
        {
            try
            {
                using (var _context = new AplicationDbContext())
                {
                    var existingProducto = _context.productos.Find(producto.PkIdArticulo);

                    if (existingProducto != null)
                    {
                        existingProducto.NombreProd = producto.NombreProd;
                        existingProducto.Cantidad = producto.Cantidad;
                        existingProducto.Sabor = producto.Sabor;
                        existingProducto.Tamaño = producto.Tamaño;
                        existingProducto.Lote = producto.Lote;
                        existingProducto.PrecioUnitario = producto.PrecioUnitario;

                        _context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error al editar el producto: " + ex.Message);
            }
        }

        public void DeleteProducto(Productos producto)
        {
            try
            {
                using (var _context = new AplicationDbContext())
                {
                    var existingProducto = _context.productos.Find(producto.PkIdArticulo);

                    if (existingProducto != null)
                    {
                        _context.productos.Remove(existingProducto);
                        _context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error al eliminar el producto: " + ex.Message);
            }
        }
    }
}
