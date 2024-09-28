﻿using HRBackend.Dtos;
using HRBackend.Models.Empleado;

namespace HRBackend.Services.Interface
{
    public interface IEmpleadoService
    {
        Task<EmpleadoDto> GetEmpleadoByIdAsync(int id);
        Task<IEnumerable<EmpleadoDto>> GetAllEmpleadosAsync();
        Task<Empleado> ConvertirCandidatoAEmpleado(CandidatoDto candidatoDto, EmpleadoDto empleadoDto);
        Task AddEmpleadoAsync(EmpleadoDto empleadoDto);
        Task UpdateEmpleadoAsync(int id, EmpleadoDto empleadoDto);
        Task DeleteEmpleadoAsync(int id);
        Task AddEmpleadoNewAsync(Empleado empleado);
    }
}
