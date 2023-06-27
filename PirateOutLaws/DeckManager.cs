using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    public class DeckManager
    {
        public List<Card> CardDeck { get; set; }
        public List<Card> MyDeck { get; set; }
        public List<Card> MyHand { get; set; }
        public List<Card> DiscardDeck { get; set; }

        // 전체 카드 덱 
        public void InitCardDeck()
        {
            Card slash = new Card();
            slash.Init("베기", 0, 8, 0);
            Card fist = new Card();
            fist.Init("주먹", 0, 6, 0);
            Card shot = new Card();
            shot.Init("사격", 1, 7, 1);
            Card accuShot = new Card();
            accuShot.Init("속사", 2, 10, 1);
            Card WholeShot = new Card();
            WholeShot.Init("난사", 3, 15, 2);

            CardDeck = new List<Card>();

            CardDeck.Add(slash);
            CardDeck.Add(fist);
            CardDeck.Add(shot);
            CardDeck.Add(accuShot);

        }
        // 플레이어 초기 덱
        public void InitMyDeck()
        {
            MyDeck = new List<Card>();

            for (int i = 0; i < 2; i++)
            {
                Card fist = new Card();
                fist.Init("주먹", 0, 6, 0);
                MyDeck.Add(fist);
            }

            for (int i = 0; i < 2; i++)
            {
                Card slash = new Card();
                slash.Init("베기", 0, 8, 0);
                MyDeck.Add(slash);

            }

            for (int i = 0; i < 2; i++)
            {
                Card shot = new Card();
                shot.Init("사격", 1, 8, 1);
                MyDeck.Add(shot);

            }


            Card food = new Card();
            food.Init("식량", 0, 6, 2);


            MyDeck.Add(food);

        }

        public void InitMyHand()
        {
            MyHand = new List<Card>();
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                int randIndex = rand.Next(1, MyDeck.Count);
                MyHand.Add(MyDeck[randIndex - 1]);
                MyDeck.RemoveAt(randIndex - 1);
            }
        }

        public void InitDiscardDeck()
        {
            DiscardDeck = new List<Card>();
        }

        public void ShuffleDeck()
        {
            for(int i = 0; i < DiscardDeck.Count;i++)
            {
                MyDeck.Add(DiscardDeck[i]);
            }
        }
    }
}
