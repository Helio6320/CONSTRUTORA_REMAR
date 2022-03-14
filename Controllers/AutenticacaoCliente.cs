using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UC_08_PI_ATV_06.Models;
using System.Linq;
using System.Collections.Generic;

namespace UC_08_PI_ATV_06.Controllers
{
    public class AutenticacaoCliente
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
                verificaSeClienteAdminExiste(uc);

                senha = Criptografo.TextoCriptografado(senha);

                IQueryable<Cliente> ClienteEncontrado = uc.Clientes.Where(clien=> clien.Login==login && clien.Senha==senha);
                List<Cliente> ListaClienteEncontrado = ClienteEncontrado.ToList();

                if (ListaClienteEncontrado.Count==0)
                {
                    return false;
                }
                else
                {
                    controller.HttpContext.Session.SetString("login", ListaClienteEncontrado[0].Login);
                    controller.HttpContext.Session.SetString("Nome", ListaClienteEncontrado[0].Nome);
                    controller.HttpContext.Session.SetInt32("tipo", ListaClienteEncontrado[0].Tipo);
                    return true;
                }
            }
        }

        public static void verificaSeClienteAdminExiste(UC_08_PI_ATV_06Context uc)
        {
            IQueryable<Cliente> clienEncontrado = uc.Clientes.Where(c => c.Login=="admin");

            if (clienEncontrado.ToList().Count==0)
            {
                Cliente admin = new Cliente();
                admin.Login = "admin";
                admin.Senha = Criptografo.TextoCriptografado("123");
                admin.Tipo = Cliente.ADMIN;
                admin.Nome = "Administrador";

                uc.Clientes.Add(admin);
                uc.SaveChanges();
            }
        }

        public static void verificaSeClienteEAdmin(Controller controller)
        {
            if (!(controller.HttpContext.Session.GetInt32("tipo") == Cliente.ADMIN))
            {
                controller.Request.HttpContext.Response.Redirect("/Cliente/NeedAdmin");
            }
        }
    }
}