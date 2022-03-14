using System.Linq;
using System.Collections.Generic;

namespace UC_08_PI_ATV_06.Models
{
    public class ClienteService
    {
        public void incluirCliente(Cliente clien){

           using (UC_08_PI_ATV_06Context uc = new UC_08_PI_ATV_06Context()){
              
               uc.Clientes.Add(clien);
               uc.SaveChanges();
           }
       } 

        public void editarCliente(Cliente clien){

            using(UC_08_PI_ATV_06Context uc = new UC_08_PI_ATV_06Context()){

            Cliente c = uc.Clientes.Find(clien.Id);

            c.Login = clien.Login;
            c.Nome = clien.Nome;
            c.Senha = clien.Senha;
            c.Tipo = clien.Tipo;
            uc.SaveChanges();
            }
        }

        public void excluircliente(int id){

            using(UC_08_PI_ATV_06Context uc = new UC_08_PI_ATV_06Context()){

                uc.Remove(uc.Clientes.Find(id));
                uc.SaveChanges();
            }
         }

        public Cliente Listar (int id)
        {
            using(UC_08_PI_ATV_06Context uc = new UC_08_PI_ATV_06Context()){
                return uc.Clientes.Find(id);
            }
        }

        public List<Cliente> Listar (){
        
            using(UC_08_PI_ATV_06Context uc = new UC_08_PI_ATV_06Context()){
                return uc.Clientes.ToList();
            }
        }
    }
}