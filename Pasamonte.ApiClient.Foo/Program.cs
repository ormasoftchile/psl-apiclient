using Pasamonte.ApiClient.Core.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasamonte.ApiClient.Foo
{
    class Program
    {
        static void Main(string[] args)
        {
            //var url = "http://54.191.151.49";
            var url = "http://localhost:22658/";
            var query = string.Empty;
            //query = @"$filter=Id eq (guid'08bb5553-6747-45d1-a2bb-db5872c4c3fb')";
            var apiClient = new ApiClient();
            var resultado = apiClient.PslGetNodos(
                url,
                null,
                query
            ).Result;
            Console.ReadKey();
            //var identificacionUsuario = new IdentificacionUsuario()
            //{
            //    Canal = Core.CanalIdentificacion.Teclado,
            //    Clave = "123456",
            //    Identificador = "141377523",
            //    Tipo = Core.TipoIdentificacion.Cedula
            //};
            //var identificacionTerminal = new IdentificacionTerminal()
            //{
            //    Codigo = "ac151216-1be5-4073-99a6-a3f8a359fe4f",
            //    CodigoTipoTerminal = Core.CodigoTipoTerminal.DispensadorFarmacos
            //};
            //var identificacionSistemaRemoto = new IdentificacionSistemaRemoto()
            //{
            //    Codigo = "RAYEN"
            //};
            //var taskAutenticar = apiClient.RceAutenticar
            //    (
            //        "http://localhost:22658/",
            //        null,
            //        identificacionUsuario,
            //        identificacionTerminal,
            //        identificacionSistemaRemoto
            //    );
            //taskAutenticar.Wait();
            //var taskObtenerEntregas = apiClient.RceObtenerEntregas
            //    (
            //        "http://localhost:22658/",
            //        null,
            //        identificacionUsuario,
            //        identificacionTerminal,
            //        identificacionSistemaRemoto
            //    );
            //taskObtenerEntregas.Wait();
            //var task = apiClient.RceNotificarEntrega
            //    (
            //        "http://localhost:22658/",
            //        null,
            //        identificacionUsuario,
            //        identificacionTerminal,
            //        identificacionSistemaRemoto,
            //        new Entrega()
            //        {
            //            IdEnSistemaExterno = "123456"
            //        }
            //    );
           Console.ReadKey();
        }
    }
}
