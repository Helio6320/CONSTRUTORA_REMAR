using UC_08_PI_ATV_06.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic; 


namespace UC_08_PI_ATV_06.Controllers
{
    public class FuncionarioController : Controller
    {
       public IActionResult ListaDeFuncionarios()
       {
           Autenticacao.CheckLogin(this);
           Autenticacao.verificaSeFuncionarioEAdmin(this);

           List<Funcionario> listagem = new FuncionarioService().Listar();
           return View(listagem);
       } 

       public IActionResult editarFuncionario(int id)
       {
           Autenticacao.CheckLogin(this);
           Autenticacao.verificaSeFuncionarioEAdmin(this);

           Funcionario fun = new FuncionarioService().Listar(id);
           return View(fun);
       }

       [HttpPost]
       public IActionResult editarFuncionario(Funcionario funEditado)
       {
           funEditado.Senha = Criptografo.TextoCriptografado(funEditado.Senha);

           FuncionarioService fu = new FuncionarioService();
           fu.editarFuncionario(funEditado);
           

           return RedirectToAction ("ListaDeFuncionarios");

       }
        public IActionResult RegistrarFuncionario()
        {
           Autenticacao.CheckLogin(this);
           Autenticacao.verificaSeFuncionarioEAdmin(this);
           return View();
        }

       [HttpPost]
       public IActionResult RegistrarFuncionarios(Funcionario novoFunc){

           novoFunc.Senha = Criptografo.TextoCriptografado(novoFunc.Senha);
           
           Autenticacao.CheckLogin(this);
           Autenticacao.verificaSeFuncionarioEAdmin(this);

           FuncionarioService fu = new FuncionarioService();
           fu.incluirFuncionario(novoFunc);

        return RedirectToAction ("ListaDeFuncionario");

       }

       public IActionResult ExcluirFuncionario(int id)
       {

           FuncionarioService fu = new FuncionarioService();
           fu.excluirFuncionario(id);
           return RedirectToAction("ListaDeFuncionarios");

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