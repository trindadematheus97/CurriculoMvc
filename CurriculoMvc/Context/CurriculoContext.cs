﻿using Microsoft.EntityFrameworkCore;
using CurriculoMvc.Mapeamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CurriculoMvc.Models;

namespace CurriculoMvc.Context
{
    public class CurriculoContext : DbContext
    {
        public DbSet<Curriculo> Curriculos { get; set; }
        public DbSet<Idioma> Idiomas { get; set; }
        public DbSet<TipoCurso> TiposCursos { get; set; }
        public DbSet<FormacaoAcademica> FormacoesAcademicas { get; set; }
        public DbSet<ExperienciaProfissional> ExperienciasProfissionais { get; set; }
        public DbSet<Objetivo> Objetivos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<InformacaoLogin> InformacoesLogin { get; set; }

        public CurriculoContext(DbContextOptions<CurriculoContext> opcoes) : base(opcoes) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CurriculoMap());
            modelBuilder.ApplyConfiguration(new ExperienciaProfissionalMap());
            modelBuilder.ApplyConfiguration(new FormacaoAcademicaMap());
            modelBuilder.ApplyConfiguration(new IdiomaMap());
            modelBuilder.ApplyConfiguration(new InformacaoLoginMap());
            modelBuilder.ApplyConfiguration(new ObjetivoMap());
            modelBuilder.ApplyConfiguration(new TipoCursoMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());
        }
    }
}
