using PinturasEverest.Datos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PinturasEverest.Conexiones
{
    class Repositorio
    {
        public Colores[] getColores()
        {
            try
            {
                Colores[] productos;
                var URLWebAPI = "https://pinturaseverest.somee.com/api/api/Colores";
                using (var Client = new System.Net.Http.HttpClient())
                {
                    var JSON = Client.GetStringAsync(URLWebAPI);
                    productos = JsonConvert.DeserializeObject<Colores[]>(JSON.Result);
                }

                return productos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
    }

}
