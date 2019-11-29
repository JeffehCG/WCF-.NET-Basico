using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

//Projeto Passagens do tipo Biblioteca de serviço WCF
//Classe Cliente
namespace Passagens
{
    //Definindo que a classe cliente ira trafegar no serviço
    [DataContract]
    public class Cliente
    {
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public string Cpf { get; set; }
    }
}
