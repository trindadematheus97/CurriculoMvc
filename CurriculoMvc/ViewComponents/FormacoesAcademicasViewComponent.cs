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
    public class FormacoesAcademicasViewComponent : ViewComponent
    {
        private readonly CurriculoContext _contexto;

        public FormacoesAcademicasViewComponent(CurriculoContext contexto)
        {
            _contexto = contexto;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            return View(await _contexto.FormacoesAcademicas.Include(f => f.TipoCurso).Where(f => f.CurriculoId == id).ToListAsync());
        }
    }
}
