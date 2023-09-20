using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ServiceTest.Services
{
    public class TriviaService
    {
        private HttpClient client;
        public JsonSerializerOptions option;
        public static string URL = @"https://zr8z94hw-44376.euw.devtunnels.ms/AmericanQuestions/";
        public TriviaService()
        {
            client = new HttpClient();
            option = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true, WriteIndented = true };
        }
        public async Task<string> CheckConectionAsync()
        {
            try
            {
                var response = await client.GetAsync($"{URL}GetQuestions");
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    return content;
                }
                else { return null; }
            }
            catch { }
            return null;
            
        }

    }
}
