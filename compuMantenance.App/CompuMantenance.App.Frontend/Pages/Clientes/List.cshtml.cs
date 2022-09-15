using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CompuMantenance.App.Frontend.Pages
{
    public class ListModelClientes : PageModel
    {
    private string[] contactos = {"Fernanda Gaviria", "Marcela Franco", "Alba Nelly Cataño", "German Gaviria", "Jhomaro Gaviria"};
        public List<string> ListaContactos { get; set; }
        public void OnGet()
        {
            ListaContactos = new List<string>();
            ListaContactos.AddRange(contactos);
        }
    }
}
