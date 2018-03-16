using System.Collections.Generic;
using TravelCardsSortingLibrary;
using Xunit;

namespace TravelCardsSortingTest
{
    public class TravelCardsSortingTest
    {
        [Fact]
        public void TravelSortingTest()
        {
            // arrange
            List<TravelCard> travelCards = new List<TravelCard>()
            {
                new TravelCard("Кельн", "Бангкок"),
                new TravelCard("Москва", "Петушки"),
                new TravelCard("Патайя", "Париж"),
                new TravelCard("Бангкок", "Патайя"),
                new TravelCard("Петушки", "Кельн")
            };

            int travelCardsCount = travelCards.Count;

            List<TravelCard> expectedCardsOrder = new List<TravelCard>()
            {
                new TravelCard("Москва", "Петушки"),
                new TravelCard("Петушки", "Кельн"),
                new TravelCard("Кельн", "Бангкок"),
                new TravelCard("Бангкок", "Патайя"),
                new TravelCard("Патайя", "Париж")
            };

            // act
            List<TravelCard> sortedCards = TravelCardsSortingUtils.SortTravelCards(travelCards);

            // assert
            Assert.Equal(travelCardsCount, travelCards.Count);
            Assert.Equal(expectedCardsOrder.Count, sortedCards.Count);
            for (int i = 0; i < sortedCards.Count; i++)
            {
                Assert.Equal(expectedCardsOrder[i].DestinationPoint, sortedCards[i].DestinationPoint);
                Assert.Equal(expectedCardsOrder[i].DeparturePoint, sortedCards[i].DeparturePoint);
            }
        }
    }
}
