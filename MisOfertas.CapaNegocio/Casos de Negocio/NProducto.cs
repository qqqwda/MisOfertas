using MisOfertas.CapaDatos;
using MisOfertas.CapaDatos.JModels;
using MisOfertas.CapaDatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisOfertas.CapaNegocio.Casos_de_Negocio
{
    public class NProducto : IMaintanable<Producto>
    {
        CommonContext Bd;

        public NProducto()
        {
            Bd = new CommonContext();
        }



        public Response<Producto> Create(Producto producto)
        {
            //if (producto. == 0)
            //{
            //    return new Response<Producto> { IsSuccess = false, Answer = null, Message = "No pertenece a empresa" };
            //}
            if (string.IsNullOrEmpty(producto.Marca))
            {
                return new Response<Producto> { IsSuccess = false, Answer = null, Message = "Campo 'marca' vacio" };
            }
            if (string.IsNullOrEmpty(producto.Modelo))
            {
                return new Response<Producto> { IsSuccess = true, Answer = null, Message = "Campo 'modelo' vacio" };
            }
            if (string.IsNullOrEmpty(producto.Nombre))
            {
                return new Response<Producto> { IsSuccess = true, Answer = null, Message = "Campo 'nombre' vacio" };
            }
            if (producto.PrecioNormal <= 0)
            {
                return new Response<Producto> { IsSuccess = true, Answer = null, Message = "El precio debe ser mayor a 0" };
            }
            if (string.IsNullOrEmpty(producto.Temporada))
            {
                return new Response<Producto> { IsSuccess = true, Answer = null, Message = "Campo 'Temporada' vacio" };
            }
            if (producto.Categoria.IdCategoria == 0)
            {
                return new Response<Producto> { IsSuccess = true, Answer = null, Message = "Seleccione categoría" };
            }
            if (producto.Stock <= 0)
            {
                return new Response<Producto> { IsSuccess = true, Answer = null, Message = "Stock debe ser mayor a 0" };
            }

            Bd.Productos.Add(producto);
            Bd.SaveChanges();

            return new Response<Producto> { IsSuccess = true, Answer = producto, Message = "Producto creado" };

        }

        public string AgregarImagen(string nombreImagen, int id)
        {
            try
            {

                Bd.Database.ExecuteSqlCommand($"UPDATE productoes SET Imagen='{nombreImagen}'  WHERE IdProducto = {id}");
                Bd.SaveChanges();
                return "Registrado en la bd con éxito";
            }
            catch (Exception ex)
            {



                return ex.Message;
            }
        }
        public Response<Producto> Create(ProductoModel producto)
        {
            if (producto.IdEmpresa == 0)
            {
                return new Response<Producto> { IsSuccess = false, Answer = null, Message = "No pertenece a empresa" };
            }
            if (string.IsNullOrEmpty(producto.Marca))
            {
                return new Response<Producto> { IsSuccess = false, Answer = null, Message = "Campo 'marca' vacio" };
            }
            if (string.IsNullOrEmpty(producto.Modelo))
            {
                return new Response<Producto> { IsSuccess = true, Answer = null, Message = "Campo 'modelo' vacio" };
            }
            if (string.IsNullOrEmpty(producto.Nombre))
            {
                return new Response<Producto> { IsSuccess = true, Answer = null, Message = "Campo 'nombre' vacio" };
            }
            if (producto.PrecioNormal <= 0)
            {
                return new Response<Producto> { IsSuccess = true, Answer = null, Message = "El precio debe ser mayor a 0" };
            }
            if (string.IsNullOrEmpty(producto.Temporada))
            {
                return new Response<Producto> { IsSuccess = true, Answer = null, Message = "Campo 'Temporada' vacio" };
            }
            if (producto.IdCategoria == 0)
            {
                return new Response<Producto> { IsSuccess = true, Answer = null, Message = "Seleccione categoría" };
            }
            if (producto.Stock <= 0)
            {
                return new Response<Producto> { IsSuccess = true, Answer = null, Message = "Stock debe ser mayor a 0" };
            }

            Producto prod = new Producto
            {
                Categoria = null,
                Descripcion = producto.Descripcion,
                Empresa = null,
                FechaVencimiento = producto.FechaVencimiento,
                Imagen = producto.Imagen,
                Stock = producto.Stock,
                Marca = producto.Marca,
                Modelo = producto.Modelo,
                Nombre = producto.Nombre,
                Temporada = producto.Temporada,
                PrecioNormal = producto.PrecioNormal

            };
            Bd.Database.ExecuteSqlCommand("INSERT INTO productoes(PrecioNormal, Descripcion, Marca, Modelo, Stock, Categoria_IdCategoria, Empresa_IdEmpresa, Nombre, FechaVencimiento, Imagen, Temporada) VALUES ({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10})",
                producto.PrecioNormal, producto.Descripcion, producto.Marca, producto.Modelo, producto.Stock, producto.IdCategoria, producto.IdEmpresa, producto.Nombre, producto.FechaVencimiento, producto.Imagen, producto.Temporada);
            
            Bd.SaveChanges();

            return new Response<Producto> { IsSuccess = true, Answer = prod, Message = "Producto creado" };

        }

        public Response<Producto> Delete(int id)
        {
            try
            {
                var producto = Bd.Productos.First(c => c.IdProducto.Equals(id));

                if (producto != null)
                {
                    Bd.Productos.Remove(producto);
                    Bd.SaveChanges();

                    return new Response<Producto> { Answer = producto, IsSuccess= true, Message="Producto eliminado"};
                }
                else
                {
                    return new Response<Producto> { Answer = null, IsSuccess = false, Message = "No se pudo eliminar, producto no existe" };
                }
            }
            catch (Exception ex)
            {

                return new Response<Producto> { Answer = null, IsSuccess = false, Message = "No se pudo eliminar :"+ex.ToString() };
            }
        }

        public List<Producto> ToList()
        {
            return Bd.Productos.ToList();
        }
        public List<ProductoModel> ToListModel()
        {
            List <ProductoModel> listaProducto = new List<ProductoModel>();
            List<Producto> productos = new List<Producto>();
            productos = Bd.Productos.ToList();
            foreach (var item in productos)
            {
                try
                {
                    listaProducto.Add(new ProductoModel
                    {
                        Descripcion = item.Descripcion,
                        FechaVencimiento = item.FechaVencimiento,
                        IdCategoria = item.Categoria.IdCategoria,
                        IdEmpresa = item.Empresa.IdEmpresa,
                        IdProducto = item.IdProducto,
                        Imagen = item.Imagen,
                        Marca = item.Marca,
                        Modelo = item.Modelo,
                        Nombre = item.Nombre,
                        PrecioNormal = item.PrecioNormal,
                        Stock = item.Stock,
                        Temporada = item.Temporada,
                        
                    });
                }
                catch (Exception)
                {

                    throw;
                }
                
            }

            return listaProducto;
        }



        public Response<Producto> Update(int id, Producto obj)
        {
            throw new NotImplementedException();
        }
        public Response<Producto> UpdateModel(int id, ProductoModel producto)
        {
            if (producto.IdEmpresa == 0)
            {
                return new Response<Producto> { IsSuccess = false, Answer = null, Message = "No pertenece a empresa" };
            }
            if (string.IsNullOrEmpty(producto.Marca))
            {
                return new Response<Producto> { IsSuccess = false, Answer = null, Message = "Campo 'marca' vacio" };
            }
            if (string.IsNullOrEmpty(producto.Modelo))
            {
                return new Response<Producto> { IsSuccess = true, Answer = null, Message = "Campo 'modelo' vacio" };
            }
            if (string.IsNullOrEmpty(producto.Nombre))
            {
                return new Response<Producto> { IsSuccess = true, Answer = null, Message = "Campo 'nombre' vacio" };
            }
            if (producto.PrecioNormal <= 0)
            {
                return new Response<Producto> { IsSuccess = true, Answer = null, Message = "El precio debe ser mayor a 0" };
            }
            if (string.IsNullOrEmpty(producto.Temporada))
            {
                return new Response<Producto> { IsSuccess = true, Answer = null, Message = "Campo 'Temporada' vacio" };
            }
            if (producto.IdCategoria == 0)
            {
                return new Response<Producto> { IsSuccess = true, Answer = null, Message = "Seleccione categoría" };
            }
            if (producto.Stock <= 0)
            {
                return new Response<Producto> { IsSuccess = true, Answer = null, Message = "Stock debe ser mayor a 0" };
            }

            Producto prod = new Producto
            {
                Categoria = null,
                Descripcion = producto.Descripcion,
                Empresa = null,
                FechaVencimiento = producto.FechaVencimiento,
                Imagen = producto.Imagen,
                Stock = producto.Stock,
                Marca = producto.Marca,
                Modelo = producto.Modelo,
                Nombre = producto.Nombre,
                Temporada = producto.Temporada,
                PrecioNormal = producto.PrecioNormal

            };
            Bd.Database.ExecuteSqlCommand(string.Format("UPDATE productoes SET PrecioNormal = '{0}', Descripcion = '{1}', Marca = '{2}', Modelo = '{3}', Stock = '{4}', Categoria_IdCategoria = '{5}', Empresa_IdEmpresa='{6}', Nombre='{7}', FechaVencimiento='{8}', Imagen='{9}', Temporada='{10}' WHERE IdProducto = '{11}'  ", producto.PrecioNormal, producto.Descripcion, producto.Marca, producto.Modelo, producto.Stock, producto.IdCategoria, producto.IdEmpresa, producto.Nombre, producto.FechaVencimiento, producto.Imagen, producto.Temporada, id));
            Bd.SaveChanges();

            return new Response<Producto> { IsSuccess = true, Answer = prod, Message = "Producto actualizado" };
        }
    }
}
