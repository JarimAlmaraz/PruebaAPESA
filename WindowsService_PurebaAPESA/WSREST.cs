using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace WindowsService_PurebaAPESA
{
    [ServiceContract]
    public class MiServicioREST
    {
        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, UriTemplate = "Sumar")]
        public int SumarNumeros(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
    }
}
