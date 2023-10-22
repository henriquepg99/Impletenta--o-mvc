using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // instancias do tipo cliente
        Cliente cliente1 = new Cliente(01, "Henrique Gasque", "042.923.640-95", "henriquepprog@gmail.com", "Bonnie");
        Cliente cliente2 = new Cliente(02, "Artthur Silva", "425.654.855.78", "arthurs@gmail.com", "Pitty");
        Cliente cliente3 = new Cliente(03, "Bernardo Souza", "871.548.473-34", "bernardos@gmail.com", "Pata");
        
        // lista de clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);

        ViewBag.listaClientes = listaClientes;


        // instancias do tipo fornecedor
        Fornecedor fornecedor1 = new Fornecedor(01, "Primeiro", "62.478.544/0001-10", "primeiro@gmail.com")
        Fornecedor fornecedor2 = new Fornecedor(02, "Segundo", "69.319.230/0001-14", "segundp@gmail.com")
        Fornecedor fornecedor3 = new Fornecedor(03, "Terceiro", "83.314.261/0001-03", "terceiro@gmail.com")

        // lista de fornecedor
        List<Fornecedor> listaFornecedor= new List<Fornecedor>();
        listaFornecedor.Add(fornecedor1);
        listaFornecedor.Add(fornecedor2);
        listaFornecedor.Add(fornecedor3);

        ViewBag.listaFornecedor = listaFornecedor;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
