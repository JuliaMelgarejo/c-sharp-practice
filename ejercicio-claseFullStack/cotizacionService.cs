using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ejercicio_claseFullStack.Services
{
	public class CotizacionService
	{
		private readonly HttpClient _client;

		public CotizacionService(HttpClient client)
		{
			_client = client;
			_client.DefaultRequestHeaders.Accept.Clear();
			_client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
		}

		public async Task<string> GetCotizacionAsync(string apiUrl)
		{
			HttpResponseMessage response = await _client.GetAsync(apiUrl);
			response.EnsureSuccessStatusCode();
			return await response.Content.ReadAsStringAsync();
		}
	}
}
