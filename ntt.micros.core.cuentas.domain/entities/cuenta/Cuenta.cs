﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntt.micros.core.cuentas.domain.entities.cuenta
{
    public class Cuenta
    {
        public int Id { get; set; }
        public string? NumeroCuenta { get; set; }
        public string? TipoCuenta { get; set; }
        public double? SaldoInicial { get; set; }
        public string? Estado { get; set; }


    }
}
