using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompuMantenance.App.Dominio.Entidades;


namespace CompuMantenance.App.Persistencia.AppRepositorios
{
    public interface IRepositorioClientes
    {
        IEnumerable<Cliente> GetAll();
        
    }
}