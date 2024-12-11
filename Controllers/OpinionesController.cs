using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using models;
using System.Reflection;

namespace back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OpinionController : ControllerBase
    {

    //metodo que devuelve todas las peliculas
    [HttpGet]
    public ActionResult<IEnumerable<Opinion>> GetOpiniones()
    {
        return Ok(DataStore.Opiniones);
    }

[HttpGet("{id}")]
        public ActionResult<Compra> GetOpinion(int id)
        {
            var opinion = DataStore.Opiniones.FirstOrDefault(c => c.Id == id);
            if (opinion == null)
            {
                return NotFound();
            }
            return Ok(opinion);
        }

    //metodo para insertar una pelicula a la lista de peliculas
    [HttpPost]
    public ActionResult<Opinion> CreateOpinion(Opinion opinion)
    {
        DataStore.Opiniones.Add(opinion);
        return CreatedAtAction(nameof(GetOpinion), new { id = opinion.Id }, opinion);
    }

     [HttpGet("Pelicula/{IdPelicula}/Opiniones")]
        public ActionResult<Compra> GetOpinionesDePelicula(int IdPelicula)
        {
            var opiniones = DataStore.Opiniones.Where(o => o.PeliculaId == IdPelicula).ToList();
            if (opiniones == null)
            {
                return NotFound();
            }
            return Ok(opiniones);
        }

    }


    
}