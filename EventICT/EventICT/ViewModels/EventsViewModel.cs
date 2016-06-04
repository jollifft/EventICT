using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace EventICT
{
	public class EventsViewModel : BaseViewModel
	{
		private ObservableCollection<Event> _events;
		public ObservableCollection<Event> EventList
		{
			get
			{
				return _events;
			}
			set
			{
				_events = value;
				base.OnPropertyChanged();
			}
		}

		public EventsViewModel ()
		{
			EventList = new ObservableCollection<Event> ();
		}

		public async Task GetEvents()
		{
			List<Event> events = await App.Store.GetData ();
			EventList = new ObservableCollection<Event> (events);
		}
	}
}

