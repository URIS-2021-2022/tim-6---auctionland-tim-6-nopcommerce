﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdlukaODavanjuUZakup.Models
{
    public class UgovoroZakupuConfirmationDto
    {
        public Guid UgovoroZakupuID { get; set; }
        public string zavodni_Broj { get; set; }
        public DateTime datum_potpisa { get; set; }
    }
}
