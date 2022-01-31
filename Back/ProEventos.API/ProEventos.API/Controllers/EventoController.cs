﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : Controller
    {
        public IEnumerable<Evento> evento = new Evento[]{
            new Evento()
        {
            EventoId = 1,
            Tema = "Angular 11 e .NET 5",
            Local = "Belo Horizonte",
            Lote = "1 Lote",
            QtdPessoas = 250,
            DataEvento = DateTime.Now.AddDays(2).ToString(),
            ImagemURL = "foto.png"
            },
            new Evento()
        {
            EventoId = 2,
            Tema = "Novidades",
            Local = "SP",
            Lote = "2 Lote",
            QtdPessoas = 350,
            DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
            ImagemURL = "foto.png"
            }
        };
        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return evento.Where(evento => evento.EventoId == id);
        }
        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete com id = {id}";
        }

    }
}
