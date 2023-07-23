using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentadeBebidas.Context;
using VentadeBebidas.Entities;

namespace VentadeBebidas.Services
{
    public class VendedorServices
    {
        public void AddVendedor(Vendedor vendedor)
        {
            try
            {
                using (var _context = new AplicationDbContext())
                {
                    _context.vendedor.Add(vendedor);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error al agregar el vendedor: " + ex.Message);
            }
        }

        public List<Vendedor> GetVendedores()
        {
            try
            {
                using (var _context = new AplicationDbContext())
                {
                    return _context.vendedor.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error al obtener los vendedores: " + ex.Message);
            }
        }

        public void EditVendedor(Vendedor vendedor)
        {
            try
            {
                using (var _context = new AplicationDbContext())
                {
                    var existingVendedor = _context.vendedor.Find(vendedor.IdVendedor);

                    if (existingVendedor != null)
                    {
                        existingVendedor.NombreVend = vendedor.NombreVend;
                        existingVendedor.ApellidoVend = vendedor.ApellidoVend;
                        existingVendedor.CorreoVend = vendedor.CorreoVend;
                        existingVendedor.ContraseñaVend = vendedor.ContraseñaVend;

                        _context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error al editar el vendedor: " + ex.Message);
            }
        }

        public void DeleteVendedor(Vendedor vendedor)
        {
            try
            {
                using (var _context = new AplicationDbContext())
                {
                    var existingVendedor = _context.vendedor.Find(vendedor.IdVendedor);

                    if (existingVendedor != null)
                    {
                        _context.vendedor.Remove(existingVendedor);
                        _context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error al eliminar el vendedor: " + ex.Message);
            }
        }
    }
}
