using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zapateria.Model;

namespace Zapateria.Service
{
    public static class ShoeService 
    {
        private static string urlLocal = ConfigurationManager.AppSettings["urllocal"].ToString();

        #region C O N S T A N T E S
        const string urlgetAlmacen = "api/almacen/get";
        const string urlpostAlmacen = "api/almacen/post";
        const string urlgetArticulo = "api/shoe/get";
        const string urlpostArticuloPorId = "api/shoe/getPorId";
        const string urlpostArticulo= "api/shoe/post";
        #endregion

        #region F U N C I O N E S   P U B L I C A S
        public static async Task<reponseAlmacen> get()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(urlLocal + urlgetAlmacen);
                //response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    var customerJsonString = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<reponseAlmacen>(custome‌​rJsonString);
                }
                else
                    return new reponseAlmacen { success = false, error_msg = "Error" };
            }
        }

        public static async Task<reponseAlmacen> post(Store stores)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.PostAsJsonAsync(urlLocal + urlpostAlmacen, stores);
                if (response.IsSuccessStatusCode)
                {
                    var customerJsonString = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<reponseAlmacen>(custome‌​rJsonString);
                }
                else
                    return new reponseAlmacen { success = false, error_msg = "Error" };
            }
        }

        public static async Task<reponseArticulo> getArticulo()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(urlLocal + urlgetArticulo);
                //response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    var customerJsonString = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<reponseArticulo>(custome‌​rJsonString);
                }
                else
                    return new reponseArticulo { success = false, error_msg = "Error" };
            }
        }

        public static async Task<reponseArticulo> postArticulo(article art)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.PostAsJsonAsync(urlLocal + urlpostArticulo, art);
                if (response.IsSuccessStatusCode)
                {
                    var customerJsonString = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<reponseArticulo>(custome‌​rJsonString);
                }
                else
                    return new reponseArticulo { success = false, error_msg = "Error" };
            }
        }

        #endregion
    }
}
