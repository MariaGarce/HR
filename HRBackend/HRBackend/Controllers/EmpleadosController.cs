﻿using HRBackend.Context;
using HRBackend.Dtos;
using HRBackend.Services.Interface;
using HRBackend.Services.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HRBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadosController : Controller
    {
        private readonly IEmpleadoService _empleadoService;
        private readonly IAuthService _authService;
        private readonly ICandidatoService _candidatoService;
        public EmpleadosController(IEmpleadoService empleadoService, IAuthService authService, ICandidatoService candidatoService)
        {
            _empleadoService = empleadoService;
            _authService = authService;
            _candidatoService = candidatoService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmpleadoDto>>> GetAllEmpleados()
        {
            var empleados = await _empleadoService.GetAllEmpleadosAsync();
            return Ok(empleados);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            try
            {
                var empleado = await _authService.LoginEmpleado(loginDto);
                return Ok(empleado);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("convertir")]
        public async Task<IActionResult> ConvertirCandidatoAEmpleado(CandidatoDto candidatoDto, EmpleadoDto empleadoDto)
        {
            if (candidatoDto == null || empleadoDto == null)
            {
                return BadRequest("Datos incompletos.");
            }

            try
            {
                await ConvertirCandidatoAEmpleado(candidatoDto, empleadoDto);
                return Ok("Candidato convertido a empleado exitosamente.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al convertir candidato a empleado: {ex.Message}");
            }
        }


    }
}
