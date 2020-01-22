using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ControleEstudos.Models;

namespace COntroleEstudos.WebAPI
{
    [ApiController]
    [Route("[controller]")]
    public class EstudoController: ControllerBase
    {
        [HttpGet]
        public IEnumerable<Estudo> GetEnumerable()
        {
            return new List<Estudo>() { new Estudo(){Id = 0, Nome = "C#", Descricao = "Estuda c# ai"}};
        }



    }
}