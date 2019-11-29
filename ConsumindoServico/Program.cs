using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumindoServico
{
    //Para adicionar referencia ao serviço para efetuar o cadastro etc
    //Clique com o botão direito em Referencias/ Adicionar referencia de serviço e descobrir
    //Em seguida clique no serviço desejado e selecione os metodos a referenciar
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
