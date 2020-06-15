using System;
namespace _06_heran
{
    public class CPF : Pessoa
    {
        public string cpf = "465580058-10";
        public string rg = "373506182";
        public string cnpj = "8930030314";
        public string Tokenn { get; set; }

        public bool Validar(string cpf, string rg, string cnpj){
            if(this.cpf == cpf && this.rg == rg && this.cnpj == cnpj){
                Tokenn = ".";
                return true;
            }else{
                return false;
            }
        }
    }
}