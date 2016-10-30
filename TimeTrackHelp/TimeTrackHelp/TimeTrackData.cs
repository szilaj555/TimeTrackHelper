using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTrackHelper
{
	class Event
	{
		public string eventName { get; private set; }

		public Event (string eventName = "Idle")
		{
			this.eventName = eventName;
		}

		public static Event idle = new Event ("Idle");
	}
}


namespace TimeTrackHelper
{
	class TimeTrackData
	{
		private SortedList<DateTime, Event> timeTrack;

		public void StartNewEvent (Event startedEvent)
		{
			DateTime now = DateTime.Now;
			if ((!timeTrack.ContainsKey (now)) && (timeTrack.LastOrDefault ().Key < now))
				timeTrack.Add (now, startedEvent);
		}


		// TODO: temlates itsd
		public void TrimSortedList (ref SortedList<DateTime, Event> list, Func<DateTime, bool> rule)
		{
			if (list.Count < 1)
				return;

			bool firstItemState = rule.Invoke (list.First ().Key);
			bool lastItemState = rule.Invoke (list.Last().Key);

			if ((firstItemState == true) && (lastItemState == true))
				return;

			if ((firstItemState == false) && (lastItemState == false))
			{
				list.Clear ();
				return;
			}
/*
			{
				F T T T T T T T
				0 1 2 3 4 5 6 7 8
				S               E

				F T T T T T T T
				0 1 2 3 4 5 6 7
				S       E

				F T T T T T T T
				0 1 2 3 4 5 6 7
				S   E

				F T T T T T T T
				0 1 2 3 4 5 6 7
				S E

				F T T T T T T T
				0 1 2 3 4 5 6 7
				S E

				end < Group 1
				end >= Group 2
			}
*/
			int start = 0;
			int end = list.Count;
			int size = end - start;
			int index = start + ((size % 2 == 0) ? (size / 2) : ((size + 1) / 2));
			bool actState = rule.Invoke (list.ElementAt (index).Key);
			while(true)
			{
				if(actState == firstItemState)
				{
					// Move upper part
					if(start == index)
						break;
					start = index;
				} else
				{
					// Move lower part
					if(end == index)
						break;
					end = index;
				}
				size = end - start;
				index = start + ((size % 2 == 0) ? (size / 2) : ((size + 1) / 2));
				actState = rule.Invoke (list.ElementAt (index).Key);
			}

			System.Diagnostics.Debug.Assert ((end >= list.Count) || ((start - 1) >= list.Count));
			System.Diagnostics.Debug.Assert ((end <= 1) || (start <= 0));
			System.Diagnostics.Debug.Assert ((end - start != 1));

			if (rule.Invoke (list.ElementAt (start).Key))
			{
				start = end;
				end = list.Count;
			} else
			{
				end = start;
				start = 0;
			}

			for(int i = end; i >= start; --i)
			{
				list.RemoveAt (i);
			}
		}


		public SortedList<DateTime, Event> GetTimeTrack (DateTime? startTime = null, DateTime? endTime = null)
		{
			SortedList<DateTime, Event> returnTimeTrack = timeTrack;

			if (startTime != null)
			{
				TrimSortedList (ref timeTrack, (DateTime actDateTime) => actDateTime >= startTime);
			}

			if(endTime != null)
			{
				TrimSortedList (ref timeTrack, (DateTime actDateTime) => actDateTime <= endTime);
			}

			return returnTimeTrack;
		}
	}
}
