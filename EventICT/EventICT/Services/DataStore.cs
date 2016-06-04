using System;
using ModernHttpClient;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;


namespace EventICT
{
	public class DataStore
	{
		public DataStore ()
		{
		}

		public async Task<List<Event>> GetData()
		{
			var httpClient = new HttpClient(new NativeMessageHandler());

			var response = await httpClient.GetAsync ("https://api.wichitaweso.me/events?start=2016-06-04+16%3A49%3A13&end=2016-06-10+16%3A49%3A13");

			string message = await response.Content.ReadAsStringAsync ();

			List<Event> events = JsonConvert.DeserializeObject<List<Event>> (message);
			return events;
		}
	}
}

