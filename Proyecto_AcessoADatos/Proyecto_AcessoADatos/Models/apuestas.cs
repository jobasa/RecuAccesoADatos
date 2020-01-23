﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_AcessoADatos.Models
{
    public class apuestas
    {
        public apuestas(int Id, decimal Dinero_apostado, decimal Cuota, string Tipo_apuesta, int ID_MERCADO, int ID_USUARIOS)
        {
            this.Id = Id;
            this.Dinero_apostado = Dinero_apostado;
            this.Cuota = Cuota;
            this.Tipo_apuesta = Tipo_apuesta;
            this.ID_MERCADO = ID_MERCADO;
            this.ID_USUARIOS = ID_USUARIOS;
        }

        public int Id { get; set; }
        public decimal Dinero_apostado { get; set; }
        public decimal Cuota { get; set; }
        public string Tipo_apuesta { get; set; }
        public int ID_MERCADO { get; set; }
        public int ID_USUARIOS { get; set; }
    }

    public class apuestasDTO
    {
        public apuestasDTO(decimal Dinero_apostado, decimal Cuota, string Tipo_apuesta)
        {
            this.Dinero_apostado = Dinero_apostado;
            this.Cuota = Cuota;
            this.Tipo_apuesta = Tipo_apuesta;
        }

        public decimal Dinero_apostado { get; set; }
        public decimal Cuota { get; set; }
        public string Tipo_apuesta { get; set; }

    }
}