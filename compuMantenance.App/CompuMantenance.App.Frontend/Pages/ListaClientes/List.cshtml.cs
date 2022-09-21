using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CompuMantenance.App.Persistencia.AppRepositorios;
using CompuMantenance.App.Dominio.Entidades;
using Microsoft.AspNetCore.Authorization;

namespace CompuMantenance.App.Frontend.Pages
{
    public class ListModelListaClientes : PageModel
    {
        
        private readonly IRepositorioClientes repositorioClientes;
        public IEnumerable<Cliente> clientes {get; set; }

        public ListModelListaClientes(IRepositorioClientes repositorioClientes)
        {
            
            //this.repositorioClientes = repositorioClientes;
            this.repositorioClientes = new RepositorioClientesMemoria(new CompuMantenance.App.Persistencia.AppRepositorios.AppContext3());
        }

        public void OnGet()
        {
            //clientes = repositorioClientes.GetAll();
            clientes = repositorioClientes.GetAllPacientes();

        }
    }
}
