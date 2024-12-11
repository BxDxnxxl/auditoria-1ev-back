using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using models;

namespace back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductoController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<ModeloAutoria>> GetProductos()
        {
            return Ok(DataStore.Productos);
        }

        [HttpGet("{id}")]
        public ActionResult<ModeloAutoria> GetProducto(int id)
        {
            var producto = DataStore.Productos.FirstOrDefault(p => p.Id == id);
            if (producto == null)
            {
                return NotFound($"Producto con ID {id} no encontrado.");
            }
            return Ok(producto);
        }

        [HttpPut("{id}")]
        public ActionResult<ModeloAutoria> UpdateProducto(int id, ModeloAutoria updatedProducto)
        {
            var producto = DataStore.Productos.FirstOrDefault(p => p.Id == id);
            if (producto == null)
            {
                return NotFound($"Producto con ID {id} no encontrado.");
            }

            producto.Nombre = updatedProducto.Nombre;
            producto.Descripcion = updatedProducto.Descripcion;
            producto.TipoProducto = updatedProducto.TipoProducto;
            producto.CantidadEnInventario = updatedProducto.CantidadEnInventario;
            producto.Precio = updatedProducto.Precio;
            producto.FechaIngreso = updatedProducto.FechaIngreso;
            producto.Disponible = updatedProducto.Disponible;

            return Ok(producto);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteProducto(int id)
        {
            var producto = DataStore.Productos.FirstOrDefault(p => p.Id == id);
            if (producto == null)
            {
                return NotFound($"Producto con ID {id} no encontrado.");
            }

            DataStore.Productos.Remove(producto);
            return Ok($"Producto con ID {id} eliminado correctamente.");
        }
    }
}
