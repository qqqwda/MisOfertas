using MisOfertas.CapaNegocio.Casos_de_Negocio;
using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace MisOfertas.API.Controllers
{
    public class SubirBoletaController : ApiController
    {
        NOpinionOferta negocio;
        public SubirBoletaController()
        {
            negocio = new NOpinionOferta();
        }
        [HttpPut]
        public async Task<string> SubirBoleta(int id)
        {
            var ctx = HttpContext.Current;
            var root = ctx.Server.MapPath("~/imagesBoleta");
            var provider = new MultipartFormDataStreamProvider(root);

            try
            {
                await Request.Content.
                    ReadAsMultipartAsync(provider);

                foreach (var file in provider.FileData)
                {
                    var name = file.Headers.ContentDisposition.FileName;

                    name = name.Trim('"');

                    var localFileName = file.LocalFileName;
                    var filePath = Path.Combine(root, name);
                    File.Move(localFileName, filePath);
                }
                Uri baseUri = new Uri("http://ofertasportafoli-001-site1.dtempurl.com/imagesBoleta/");
                var nombreImagen = provider.FileData[0].Headers.ContentDisposition.FileName.ToString().Replace("\"", string.Empty);
                Uri myUri = new Uri(baseUri, nombreImagen);
                var response = negocio.AgregarImagen(myUri.AbsoluteUri, id);

                return "Archivo" + provider.FileData.First().Headers.ContentDisposition.FileName.ToString() + " agregado y " + response;
            }
            catch (Exception ex)
            {

                return $"Error:{ex.Message }";
            }

        }
    }
}
