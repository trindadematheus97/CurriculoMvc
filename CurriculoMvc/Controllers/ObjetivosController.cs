﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CurriculoMvc.Models;
using CurriculoMvc.Context;

namespace CurriculoMvc.Controllers
{
    public class ObjetivosController : Controller
    {
        private readonly CurriculoContext _context;

        public ObjetivosController(CurriculoContext context)
        {
            _context = context;
        }
       
        public IActionResult Create(int id)
        {
            Objetivo objetivo = new Objetivo();
            objetivo.CurriculoId = id;
            return View(objetivo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ObjetivoId,Descrição,CurriculoId")] Objetivo objetivo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(objetivo);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "Curriculos", new { id = objetivo.CurriculoId });
            }
           
            return View(objetivo);
        }
       
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var objetivo = await _context.Objetivos.FindAsync(id);
            if (objetivo == null)
            {
                return NotFound();
            }           
            return View(objetivo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ObjetivoId,Descrição,CurriculoId")] Objetivo objetivo)
        {
            if (id != objetivo.ObjetivoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(objetivo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ObjetivoExists(objetivo.ObjetivoId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", "Curriculos", new { id = objetivo.CurriculoId });
            }
            
            return View(objetivo);
        }

        [HttpPost]
        public async Task<JsonResult> Delete(int id)
        {
            var objetivo = await _context.Objetivos.FindAsync(id);
            _context.Objetivos.Remove(objetivo);
            await _context.SaveChangesAsync();
            return Json("Objetivo excluído");
        }

        private bool ObjetivoExists(int id)
        {
            return _context.Objetivos.Any(e => e.ObjetivoId == id);
        }
    }
}
