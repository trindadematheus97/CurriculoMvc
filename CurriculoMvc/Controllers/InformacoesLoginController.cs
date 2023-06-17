﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CurriculoMvc.Models;
using CurriculoMvc.Context;

namespace CurriculoMvc.Controllers
{
    public class InformacoesLoginController : Controller
    {
        private readonly CurriculoContext _contexto;

        public InformacoesLoginController(CurriculoContext contexto)
        {
            _contexto = contexto;
        }

        public async Task<IActionResult> Index()
        {
            var usuarioId = HttpContext.Session.GetInt32("UsuarioId");           

            return View(await _contexto.InformacoesLogin.Include(u => u.Usuario).Where(i => i.UsuarioId == usuarioId).ToListAsync());
        }

        public IActionResult DownloadDados()
        {
            var usuarioId = HttpContext.Session.GetInt32("UsuarioId");
            var dados = _contexto.InformacoesLogin.Include(u => u.Usuario).Where(i => i.UsuarioId == usuarioId).ToList();
            StringBuilder arquivo = new StringBuilder();

            arquivo.AppendLine("EnderecoIP;Data;Horario");

            foreach(var item in dados)
            {
                arquivo.AppendLine(item.EnderecoIP + ";" + item.Data + ";" + item.Horario);
            }

            return File(Encoding.ASCII.GetBytes(arquivo.ToString()), "text/csv", "dados.csv");

        }
    }
}