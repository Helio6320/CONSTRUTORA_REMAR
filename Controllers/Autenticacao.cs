using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UC_08_PI_ATV_06.Models;
using System.Linq;
using System.Collections.Generic;

namespace UC_08_PI_ATV_06.Controllers
{
    public class Autenticacao
    {
        public static void CheckLogin(Controller controller)
        {
            if (string.IsNullOrEmpty(controller.HttpContext.Session.GetString("login")))
            {
                controller.Request.HttpContext.Response.Redirect("/Home/Login");
            }
        }

        public static bool verificaLoginSenha(string login, string senha, Controller controller)
        {
            using (UC_08_PI_ATV_06Context uc = new UC_08_PI_ATV_06Context())
            {
                verificaSeFuncionarioAdminExiste(uc);

                senha = Criptografo.TextoCriptografado(senha);

                IQueryable<Funcionario> FuncionarioEncontrado = uc.Funcionarios.Where(func=> func.Login==login && func.Senha==senha);
                List<Funcionario> ListaFuncionarioEncontrado = FuncionarioEncontrado.ToList();

                if (ListaFuncionarioEncontrado.Count==0)
                {
                    return false;
                }
                else
                {
                    controller.HttpContext.Session.SetString("login", ListaFuncionarioEncontrado[0].Login);
                    controller.HttpContext.Session.SetString("Nome", ListaFuncionarioEncontrado[0].Nome);
                    controller.HttpContext.Session.SetInt32("tipo", ListaFuncionarioEncontrado[0].Tipo);
                    return true;
                }
            }
        }

        public static void verificaSeFuncionarioAdminExiste(UC_08_PI_ATV_06Context uc)
        {
            IQueryable<Funcionario> funcEncontrado = uc.Funcionarios.Where(f => f.Login=="admin");

            if (funcEncontrado.ToList().Count==0)
            {
                Funcionario admin = new Funcionario();
                admin.Login = "admin";
                admin.Senha = Criptografo.TextoCriptografado("123");
                admin.Tipo = Funcionario.ADMIN;
                admin.Nome = "Administrador";

                uc.Funcionarios.Add(admin);
                uc.SaveChanges();
            }
        }

        public static void verificaSeFuncionarioEAdmin(Controller controller)
        {
            if (!(controller.HttpContext.Session.GetInt32("tipo") == Funcionario.ADMIN))
            {
                controller.Request.HttpContext.Response.Redirect("/Funcionario/NeedAdmin");
            }
        }
    }
}