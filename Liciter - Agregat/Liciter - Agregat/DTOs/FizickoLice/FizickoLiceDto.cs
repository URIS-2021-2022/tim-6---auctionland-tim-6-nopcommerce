﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Liciter___Agregat.DTOs.FizickoLice
{
    public class FizickoLiceDto
    {
        public string Ime_Prezime { get; set; }
        public string JMBG { get; set; }
        public string Adresa { get; set; } //adresa je entitet
        public string BrojeviTelefona { get; set; }
        public string Email { get; set; }
        public string BrojRacuna { get; set; }
    }
}
