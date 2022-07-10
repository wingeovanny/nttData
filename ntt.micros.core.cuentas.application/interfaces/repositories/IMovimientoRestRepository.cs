﻿using ntt.micros.core.cuentas.domain.entities.movimiento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntt.micros.core.cuentas.application.interfaces.repositories
{
    public interface IMovimientoRestRepository
    {
        Task<List<MovimientoResponse>> ConsultaMovimientos(string numeroCuenta);
        Task<MovimientoResponse> CrearMovimiento(MovimientoRequest request);
        Task<MovimientoResponse> EliminarMovimiento(string numeroCuenta, int idMovimiento);
        Task<MovimientoResponse> ActualizarMovimiento(MovimientoResponse request);

        Task<List<MovimientoResponse>> ConsultaMovimientoUsuario(string codigoUsuario);

        Task<List<MovimientoResponse>> ConsultaMovimientoFecha(DateTime fechaInicio);

    }
}
