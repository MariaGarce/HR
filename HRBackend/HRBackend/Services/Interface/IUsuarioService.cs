﻿using HRBackend.Dtos;
using HRBackend.Models.Empleado;

namespace HRBackend.Services.Interface
{
    public interface IUsuarioService
    {
        Task<UsuarioDto> Login(UsuarioDto usuarioDto);
        Task<UsuarioDto> Register(UsuarioDto usuarioDto);
    }
}