﻿using CurriculoMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurriculoMvc.ViewModels
{
    public class CurriculoViewModel
    {
        public IEnumerable<Objetivo> Objetivos { get; set; }

        public IEnumerable<FormacaoAcademica> FormacoesAcademicas { get; set; }

        public IEnumerable<ExperienciaProfissional> ExperienciasProfissionais { get; set; }

        public IEnumerable<Idioma> Idiomas { get; set; }
    }
}
