﻿using System;

namespace Komisija_Agregat.Models
{
    public class PredsednikConfirmation
    {
        public Guid PredsednikId { get; set; }
        public string ImePredsednika { get; set; }
        public string PrezimePredsednika { get; set; }
        public string EmailPredsednika { get; set; }
    }
}