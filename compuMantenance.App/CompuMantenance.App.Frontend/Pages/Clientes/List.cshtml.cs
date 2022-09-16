using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CompuMantenance.App.Persistencia.AppRepositorios;
using CompuMantenance.App.Dominio.Entidades;

namespace CompuMantenance.App.Frontend.Pages
{
    public class ListModelClientes : PageModel
    {
        //private string[] contactos = {"Fernanda Gaviria", "Marcela Franco", "Alba Nelly Cataño", "German Gaviria", "Jhomaro Gaviria"};
        //public List<string> ListaContactos { get; set; }
        
        private readonly IRepositorioClientes repositorioClientes;
        public IEnumerable<Cliente> clientes {get; set; }

        public ListModelClientes(IRepositorioClientes repositorioClientes)
        {
            this.repositorioClientes = repositorioClientes;
        }

        public void OnGet()
        {
            //ListaContactos = new List<string>();
            //ListaContactos.AddRange(contactos);
            clientes = repositorioClientes.GetAll();
        }
    }
}
