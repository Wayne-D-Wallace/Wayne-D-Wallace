using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penguin_Encounter
{
    public class Penguin
    {
        public int HitPoints { get; set; } = 75;
        public int HeightInInches { get; set; }
        public int WeightInPounds { get; set; }
        public string RockCollection { get; set; }
        public List<string> ConversationResponses = new List<string>();


        public Penguin(int hitPoints, int height, int weight, string rockCollection, List<string> orcaResponses)
        {
            HitPoints = hitPoints;
            HeightInInches = height;
            WeightInPounds = weight;
            RockCollection = rockCollection;
            ConversationResponses = orcaResponses;
            orcaResponses.Add("I'm very confused, how am I here?");
            orcaResponses.Add("Why are we animals????");
            orcaResponses.Add("Please don't eat me");
            orcaResponses.Add("How are you walking without feet?");
        }
        public int  SpeakToOrca()
        {
            Console.WriteLine("Please select number of response");
            for(int i = 0; i < ConversationResponses.Count; i++)
            {
                Console.WriteLine(i+1+" " + ConversationResponses[i]);
            }
            Console.WriteLine();
            string userResponse = Console.ReadLine();
            int characterResponse = int.Parse(userResponse);
            Console.WriteLine();
            Console.WriteLine(ConversationResponses[characterResponse -1]);
            return characterResponse;
            

        }
        public void CheckStats()
        {
            Console.WriteLine("Looking down at a muddy puddle in the streat you take stock of what you are");
            Console.WriteLine("You see that you are " + HeightInInches + "inches tall, and that you are " + WeightInPounds + " lbs" + " and you seem to be carrying a " + RockCollection);
            Console.WriteLine("You also notice that you feel strong and a number on your wing is "+ HitPoints);
        }
        

    }
}
