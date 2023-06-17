﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CurriculoMvc.Models
{
    public class Objetivo
    {
        public int ObjetivoId { get; set; }

        [Required(ErrorMessage = "Descrição obrigatória")]
        [StringLength(1000, ErrorMessage = "Descrição muito longa")]
        [DataType(DataType.MultilineText)]
        public string Descrição { get; set; }

        public int CurriculoId { get; set; }
        public Curriculo Curriculo { get; set; }
    }
}
