using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace ejercicio_clase_FullStack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET  
        [HttpGet("blue")]
        public async Task<IActionResult> GetBlueDollar()
        {
            string responseBody = string.Empty;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://dolarapi.com/v1/dolares/blue");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
                response.EnsureSuccessStatusCode();
                responseBody = await response.Content.ReadAsStringAsync();
            }

            return Ok(responseBody);

        }
    }
}
