﻿namespace HRBackend.Dtos
{
    public class ExperienciaLaboralDto
    {
        public int Id { get; set; }
        public string Empresa { get; set; }
        public string PuestoOcupado { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public decimal Salario { get; set; }
    }
}