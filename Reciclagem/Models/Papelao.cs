using System;
using System.Collections.Generic;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class Papelao : Lixo, IAzul
    {
        public string MensagemReciclagemAzul()
        {
            
            return this.GetType().Name;
        }
    }
}