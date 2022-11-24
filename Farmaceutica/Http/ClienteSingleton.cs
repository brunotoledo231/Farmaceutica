using Farmaceutica.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Farmaceutica.Http
{
    internal class ClienteSingleton
    {
        private static ClienteSingleton instancia;
        private HttpClient client;
        private ClienteSingleton()
        {
            client = new HttpClient();
        }
        public static ClienteSingleton GetInstancia()
        {
            if (instancia == null)
                instancia = new ClienteSingleton();
            return instancia;
        }
        public async Task<string> GetAsincrono(string url)
        {
            var resultado = await client.GetAsync(url);
            var contenido = String.Empty;
            if (resultado.IsSuccessStatusCode)
                contenido = await resultado.Content.ReadAsStringAsync();
            return contenido;
        }
        public async Task<string> PostAsincrono2(string url,string data )
        {
            StringContent contenido = new StringContent(data, Encoding.UTF8,
            "application/json");
            var resultado = await client.PostAsync(url, contenido);
            var respuesta = String.Empty;
            if (resultado.IsSuccessStatusCode)
                respuesta = await resultado.Content.ReadAsStringAsync();
            return respuesta;
        }


        public async Task<string> PostAsincrono(string url, string data)
        {
            StringContent contenido = new StringContent(data, Encoding.UTF8,
            "application/json");
            var resultado = await client.PostAsync(url, contenido);
            var respuesta = String.Empty;
            if (resultado.IsSuccessStatusCode)
                respuesta = await resultado.Content.ReadAsStringAsync();
            return respuesta;
        }
        public async Task<string> PutAsincrono(string url, string data)
        {
            StringContent contenido = new StringContent(data, Encoding.UTF8,
            "application/json");
            var resultado = await client.PutAsync(url, contenido);
            var respuesta = String.Empty;
            if (resultado.IsSuccessStatusCode)
                respuesta = await resultado.Content.ReadAsStringAsync();
            return respuesta;
        }
    }
}
