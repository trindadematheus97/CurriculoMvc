using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CurriculoMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CurriculoMvc.Context;

namespace CurriculoMvc.ViewComponents
{
    public class ObjetivosViewComponent : ViewComponent
    {
        private readonly CurriculoContext _contexto;

        public ObjetivosViewComponent(CurriculoContext contexto)
        {
            _contexto = contexto;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            return View(await _contexto.Objetivos.Where(o => o.CurriculoId == id).ToListAsync());
        }
        
    }
}
