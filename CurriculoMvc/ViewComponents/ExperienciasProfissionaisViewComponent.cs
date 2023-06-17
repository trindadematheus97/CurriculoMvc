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
    public class ExperienciasProfissionaisViewComponent : ViewComponent
    {
        private readonly CurriculoContext _contexto;

        public ExperienciasProfissionaisViewComponent(CurriculoContext contexto)
        {
            _contexto = contexto;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            return View(await _contexto.ExperienciasProfissionais.Where(ep => ep.CurriculoId == id).ToListAsync());
        }
    }
}
