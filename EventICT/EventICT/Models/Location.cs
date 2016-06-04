using System;

namespace EventICT
{
	public class Location
	{
		public int id { get; set; }
		public string name { get; set; }
		public string slug { get; set; }
		public string street { get; set; }
		public string city { get; set; }
		public string state { get; set; }
		public string zip { get; set; }
		public string longitude { get; set; }
		public string latitude { get; set; }
		public object image { get; set; }
		public string facebook { get; set; }
		public string twitter { get; set; }
		public string website { get; set; }
		public string email { get; set; }
		public string phone { get; set; }
		public object description { get; set; }
		public string created_at { get; set; }
		public string updated_at { get; set; }
		public object deleted_at { get; set; }
	}
}

