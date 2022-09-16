using System.Reflection.Metadata;
using System.CodeDom.Compiler;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompuMantenance.App.Dominio.Entidades;

namespace CompuMantenance.App.Persistencia.AppRepositorios
{
    public class RepositorioClientesMemoria: IRepositorioClientes
    {
        List<Cliente> clientes;
        public RepositorioClientesMemoria()
        {
            clientes = new List<Cliente>()
            {
                new Cliente{Id = 1, Nombre = "Jhomaro Alberto", Apellidos = "Gaviria Cataño", NumeroTelefono = "3175208767", Genero = Genero.Masculino},
                new Cliente{Id = 2, Nombre = "Maria Fernanda", Apellidos = "Gaviria Franco", NumeroTelefono = "3214569878", Genero = Genero.Femenino},
                new Cliente{Id = 3, Nombre = "Viviana Marcela", Apellidos = "Franco Gonzalez", NumeroTelefono = "3127210570", Genero = Genero.Femenino},
            };
        }   

        public IEnumerable<Cliente> GetAll()
        {
            return clientes;
        }    
    }
}