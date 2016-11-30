using System;
using System.Collections.Generic;

namespace Days
{
	public static class CardsData
	{
		public static List<Card> All = new List<Card>
		{
			new Card {
				Date = DateTime.Now.Subtract(TimeSpan.FromDays(3)),
				Title = "Card -3",
				Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat."
			},
			new Card {
				Date = DateTime.Now.Subtract(TimeSpan.FromDays(2)),
				Title = "Card -2",
				Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat."
			},
			new Card {
				Date = DateTime.Now.Subtract(TimeSpan.FromDays(1)),
				Title = "Card -1",
				Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat."
			},
			new Card{
				Date = DateTime.Now,
				Title = "Card",
				Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat."
			},
			new Card{
				Date = DateTime.Now.Add(TimeSpan.FromDays(1)),
				Title = "Card +1",
				Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat."
			},
			new Card {
				Date = DateTime.Now.Add(TimeSpan.FromDays(2)),
				Title = "Card +2",
				Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat."
			},
			new Card{
				Date = DateTime.Now.Add(TimeSpan.FromDays(3)),
				Title = "Card +3",
				Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat."
			},
			new Card {
				Date = DateTime.Now.Add(TimeSpan.FromDays(4)),
				Title = "Card +4",
				Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat."
			}
		};
	}
}
