using UC_08_PI_ATV_06.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic; 


namespace UC_08_PI_ATV_06.Controllers
{
    public class ClienteController : Controller
    {
       public IActionResult ListaDeCliente()
       {
           Autenticacao.CheckLogin(this);
           AutenticacaoCliente.verificaSeClienteEAdmin(this);

           List<Cliente> listagem = new ClienteService().Listar();
           return View(listagem);
       } 

       public IActionResult editarCliente(int id)
       {
           AutenticacaoCliente.CheckLogin(this);
           AutenticacaoCliente.verificaSeClienteEAdmin(this);

           Cliente cli = new ClienteService().Listar(id);
           return View(cli);
       }

       [HttpPost]
       public IActionResult editarCliente(Cliente cliEditado)
       {
           cliEditado.Senha = Criptografo.TextoCriptografado(cliEditado.Senha);

           ClienteService cl = new ClienteService();
           cl.editarCliente(cliEditado);
          

           return RedirectToAction ("ListaDeClientes");
       }
        public IActionResult RegistrarCliente()
        {
           AutenticacaoCliente.CheckLogin(this);
           AutenticacaoCliente.verificaSeClienteEAdmin(this);
           return View();
        }

       [HttpPost]
       public IActionResult RegistrarClientes(Cliente novoClien){

           novoClien.Senha = Criptografo.TextoCriptografado(novoClien.Senha);
           
           AutenticacaoCliente.CheckLogin(this);
           AutenticacaoCliente.verificaSeClienteEAdmin(this);

           ClienteService cl = new ClienteService();
           cl.incluirCliente(novoClien);

        return RedirectToAction ("ListaDeCliente");

       }

       public IActionResult ExcluirCliente(int id)
       {

           ClienteService cli = new ClienteService();
           cli.excluircliente(id);
           return RedirectToAction("ListaDeClientes");

       }
              
       public IActionResult Sair(){
           HttpContext.Session.Clear();
           return RedirectToAction("Index","Home");
       }

       public IActionResult NeedAdmin(){
           Autenticacao.CheckLogin(this);
           
           return View();
       }
    
    }
}