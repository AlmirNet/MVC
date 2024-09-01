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
        Cliente cliente1 = new Cliente(01, "Arthur A. Ferreira ", "876.983.765-65", "Arthur.Antunes@gmail.com", "Dollar");
        Cliente cliente2 = new Cliente(02, "Ricardo Lima ", "857.548.235-58", "ricardo.lima@gmail.com", "Dollar");
        Cliente cliente3 = new Cliente(03, "Fernanda Souza ", "758.574.325-85", "fernando.souza@gmail.com", "Dollar");
        Cliente cliente4 = new Cliente(04, "Jéssica Ferreira ", "758.857.425-25", "jessica.ferreira@gmail.com", "Dollar");
        Cliente cliente5 = new Cliente(05, "Maria Ameilia ", "752.365.852-45", "Arthur.ameila@gmail.com", "Dollar");

        // lista de cliente
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

        // instancia do tipo fornecedor
        Fornecedor fornecedor1 = new Fornecedor(01, "c# PET S/A", "14.182.102/0001-80", "C-sharp@pet.org");
        Fornecedor fornecedor2 = new Fornecedor(02, "c# PET S/A", "14.182.102/0001-80", "C-sharp@pet.org");
        Fornecedor fornecedor3 = new Fornecedor(03, "c# PET S/A", "14.182.102/0001-80", "C-sharp@pet.org");
        Fornecedor fornecedor4 = new Fornecedor(04, "c# PET S/A", "14.182.102/0001-80", "C-sharp@pet.org");
        Fornecedor fornecedor5 = new Fornecedor(05, "c# PET S/A", "14.182.102/0001-80", "C-sharp@pet.org");

        // lista de fornecedores
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;

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
