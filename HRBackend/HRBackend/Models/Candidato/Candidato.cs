﻿namespace HRBackend.Models.Candidatos
{
    public class Candidato : Usuario
    {
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string PuestoAspira { get; set; }
        public string Departamento { get; set; }
        public decimal SalarioAspira { get; set; }
        public string PrincipalesCompetencias { get; set; } // Organizaciones, Técnicas-Operativas, etc.
        public string PrincipalesCapacitaciones { get; set; } // Post-grado, Grado, Técnicas, etc.
        public List<ExperienciaLaboral> ExperienciaLaboral { get; set; }
        public string RecomendadoPor { get; set; }
    }
}