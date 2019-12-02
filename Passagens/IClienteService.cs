using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.IO;

//Arquivo de contrato do WCF, que define o que o pode ser feito no serviço
//Para adicionar o serviço clique com o botão direito em App.config/Editar Configurações do WCF
//Em services Selecione name depois bin/debug/passagem.dll/Passagens.ClienteService
//Depois abra e va em Endpoints, defina o Address, binding como basicHttpBinding e em contract seleciona Passagens.IClienteService

//Para definir o localhost:8080 como endereço pricipal para exibir detalhes do serviço va em Editar Configurações WCF/ Host e altere o BaseAddress

//Para que o serviço seja utilizado no browser é preciso adicionar a anotação [WebInvoke]
//É preciso marca-la como referencia (Botão direito Referencias/Adicionar Referencia) System.ServiceModel.Web

namespace Passagens
{
    [ServiceContract]
    public interface IClienteService
    {
        [OperationContract]
        //Primeiro Parametro - Tipo do metodo
        //Segundo - Tipo da resposta (XML ou Json)
        //Terceiro - Padrão da URL
        [WebInvoke( Method = "GET", ResponseFormat = WebMessageFormat.Xml, UriTemplate = "searchCliente/{nome}")]
        Cliente Buscar(string nome);

        [OperationContract]
        // É preciso configurar em App.config os parametros que seram recebidos pela url ({nome};{cpf})
        //Botão direito em App.config/ Editar configurações WCF/ Advanced/ Endpoint Behaviors/ New endpoint Behaviors
        //Altere o nome do comportamento, click em Add, e webHttp
        //Depois é preciso associar ao endpoint criado em Services/ (NomeServico) / Endpoints e alterar em behaviorConfiguration
        //Alterar tambem o Binding para webHttpBinding
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, UriTemplate = "addCliente/")]
        bool Add(Cliente cliente);

        //Listando Clientes
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Xml, UriTemplate = "getClientes/")]
        List<Cliente> GetClientes();
    }
}
