using System;
using System.Collections.Generic;

namespace EventICT
{
	public class Event
	{
		public int id { get; set; }
		public string name { get; set; }
		public string start_time { get; set; }
		public string end_time { get; set; }
		public string facebook { get; set; }
		public object meetup { get; set; }
		public string description { get; set; }
		public string created_at { get; set; }
		public string updated_at { get; set; }
		public object deleted_at { get; set; }
		public Location location { get; set; }
		public List<object> tags { get; set; }
		public object user { get; set; }
	}
}

