using System.Linq;
using System.Collections.Generic;

namespace UC_08_PI_ATV_06.Models
{
    public class FuncionarioService
    {
        public void incluirFuncionario(Funcionario func){

           using (UC_08_PI_ATV_06Context uc = new UC_08_PI_ATV_06Context()){
              
               uc.Funcionarios.Add(func);
               uc.SaveChanges();
           }
       } 

        public void editarFuncionario(Funcionario func){

            using(UC_08_PI_ATV_06Context uc = new UC_08_PI_ATV_06Context()){

            Funcionario f = uc.Funcionarios.Find(func.Id);

            f.Login = func.Login;
            f.Nome = func.Nome;
            f.Senha = func.Senha;
            f.Tipo = func.Tipo;
            uc.SaveChanges();
            }
        }

        public void excluirFuncionario(int id){

            using(UC_08_PI_ATV_06Context uc = new UC_08_PI_ATV_06Context()){

                uc.Remove(uc.Funcionarios.Find(id));
                uc.SaveChanges();
            }
         }

        public Funcionario Listar (int id)
        {
            using(UC_08_PI_ATV_06Context uc = new UC_08_PI_ATV_06Context()){
                return uc.Funcionarios.Find(id);
            }
        }

        public List<Funcionario> Listar (){
        
            using(UC_08_PI_ATV_06Context uc = new UC_08_PI_ATV_06Context()){
                return uc.Funcionarios.ToList();
            }
        }
    }
}