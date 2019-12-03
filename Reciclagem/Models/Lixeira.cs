using System;
using System.Collections.Generic;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class Lixeira
    {
        public static Dictionary<int, Lixo> lixos = new Dictionary<int, Lixo> {
            {1, new Papelao()}    
        };
    }
}