using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança_de_Classe
{
    public class Pessoa
    {
        public string nome;
        public string telefone;
        protected string endereço;
        public Pessoa()
        {
            nome = "";
            telefone = "";
            endereço = "";
        }
    }
    public class PF : Pessoa
    {
        string RG;
        string CPF;
        public PF()
        {
            //Super();
            RG = "";
            CPF = "";
        }
    }
    public class Amigos : PF
    {
        string blog;
        public Amigos()
        {
            //Super();
            blog = "";
        }
    }
    public class Parentes : PF
    {
        string email;
        public Parentes()
        {
            //Super();
            email = "";
        }
    }
    public class PJ : Pessoa
    { 
        string CNPJ;
        string IE;
        
        public PJ()
        {
            PJ text = new PJ();
            text.endereço = "SadaRS";
            //Super();
            CNPJ = "";
            IE = "";
        }
    }
}
