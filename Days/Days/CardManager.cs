using System;
using System.Collections.Generic;
using System.Linq;

namespace Days
{
	public static class CardManager
	{
		public static Card CurrentCard { get; set; } = CardsData.All.FirstOrDefault();
		//this is just setting the Current Card to equal either the first indexed card

		public static List<Card> Cards { get; set; } = CardsData.All;
		//why do we have to add this list of cards here? 

		public static void AddCard(Card card)
		{
			Cards.Add(card);
		}
		//don't get why we do the above... I get that it's adding a card, but why void and why all the different "card"

		public static Card GetNextCard(Card refCard)
		{
			var index = Cards.IndexOf(refCard);

			if (index < Cards.Count - 1)
			{
				return Cards[index + 1];
			}
			else
			{
				return null;
			}
		}

		public static Card GetPreviousCard(Card refCard)
		{
			var index = Cards.IndexOf(refCard);

			if (index > 0)
			{
				return Cards[index - 1];
			}
			else
			{
				return null;
			}
		}
	}
}