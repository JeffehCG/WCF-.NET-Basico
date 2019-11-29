using Passagens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
//Projeto hosting tipo Console Aplication
//Definir Hosting como Projeto de Iniciação(Botão direito em Hosting)

//Para deixar o serviço online
namespace Hosting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definindo serviço a ser usado
            ServiceHost host = new ServiceHost(typeof(ClienteService));

            //Criando endpoint
            Uri endereco = new Uri("http://localhost:8080/clientes");
            //Primeiro parametro contrato
            //Segundo protocolo da comunicação
            //Terceiro endereço
            host.AddServiceEndpoint(typeof(IClienteService), new BasicHttpBinding(), endereco);
            try
            {
                //Subindo serviço
                host.Open();
                ExibeInformacoesServico(host);
                Console.ReadLine();
                host.Close();
            }
            catch (Exception ex)
            {
                host.Abort();
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        //Exibindo tipo do serviço e endpoints
        public static void ExibeInformacoesServico(ServiceHost sh)
        {
            Console.WriteLine("{0} online", sh.Description.ServiceType);
            foreach(ServiceEndpoint se in sh.Description.Endpoints)
            {
                Console.WriteLine(se.Address);
            }
        }
    }
}

//Adicionar referencias ao projeto WCF para fazer a comunicação

//Referencia ao projeto WCF
//Botão direito em Referencias/Adicionar Referencia
//Ir em projetos e selecionar o nosso projeto Passagens

//Referencia a ServiceHost(Efetuar chamadas http)
//Botão direito em Referencias/Adicionar Referencia
//Ir em Assemblies e selecionar System.ServiceModel