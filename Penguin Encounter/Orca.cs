using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penguin_Encounter
{
    public class Orca
    {

        public int HitPoints { get; set; }
        public int Length { get; set; }
        public int Weight { get; set; }
        public int UserResponse 
        {
            get; set;
         
        }
        public List<string> MarxistOrca = new List<string>();

        public Orca (int hitPoints, int length, int weight, int userResponse, List<string> comradeOrca)
        {
            HitPoints = hitPoints;
            Length = length;
            Weight = weight;
            UserResponse= userResponse;
            MarxistOrca = comradeOrca;
            comradeOrca.Add("\"Welcome to the revolution mate!\"");
            comradeOrca.Add("\"We are nothing but animals doing it like we do on the Discovery Channel\"");
            comradeOrca.Add("\"We don't eat each other here, we must leave room to eat the rich!\"");
            comradeOrca.Add("\"After years of training and hard work, you might be able to fly if you put your mind to it!\"");
            

        }
        public void SpeakToCharacter(Penguin maverick)
        {
            int answer = maverick.SpeakToOrca();
            if (answer == 1)
            {
                Console.WriteLine(MarxistOrca[0]);
            }
            else if (answer == 2)
            {
                Console.WriteLine(MarxistOrca[1]);
            }
            else if (answer == 3)
            {
                Console.WriteLine(MarxistOrca[2]);
            }
            else if (answer == 4)
            {
                Console.WriteLine(MarxistOrca[3]);
            }
            else
            {
                Console.WriteLine("\" OY!, I don't know what you are saying mate! \"");
            }
        }
    }
}
