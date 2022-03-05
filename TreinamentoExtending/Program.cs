using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Description;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Discovery;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using System.Net;
using Microsoft.Xrm.Tooling.Connector;
//using ConexaoAlternativaExtending;

namespace TreinamentoExtending {
    class Program {
        static void Main(string[] args) {
            //Descoberta();
            // Conexao conexao = new Conexao();
            var serviceProxy = new Conexao().Obter();
            MeuCreate(serviceProxy);
            Console.ReadKey();
        }

        #region Create

        static void MeuCreate(CrmServiceClient ServiceProxy)
        {
            for (int i = 0; i < 10; i++)
            {
                var entidade = new Entity("account");
                Guid registro = new Guid();

                entidade.Attributes.Add("name", "Treinamento " + i.ToString());
                //Criei no Dynamics

                registro = ServiceProxy.Create(entidade);
            }
        }
        #endregion
    }
}