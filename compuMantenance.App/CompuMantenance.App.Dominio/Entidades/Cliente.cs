using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompuMantenance.App.Dominio.Entidades
{
    public class Cliente: Persona
    {
        public int IdCliente { get; set; }
        public string Direccion { get; set; }
    }
}