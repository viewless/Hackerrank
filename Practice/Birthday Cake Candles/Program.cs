using System;
using System.Collections.Generic;
using System.Globalization;

namespace Universe
{
    class Life
    {
        static void Main(string[] args)
        {
            var emotions = new List<string>() { "Anger", "Fear", "Sadness", "Happiness",
                "Disgust", "Surprise", "Aggression", "Apathy", "Anxiety", "Boredom", "Contempt",
                "Depression", "Doubt", "Empathy", "Envy", "EmbarrassmentEuphoria", "Frustration",
                "Gratitude", "Grief", "Guilt", "Hatred", "Hope", "Horror", "Hostility", "Hunger",
                "Hysteria", "Loneliness", "Love", "Paranoia", "Pity", "Pleasure", "Pride", "Rage",
                "Regret", "Remorse", "Shame", "Shock", "Suffering", "Sympathy" };


            var human = new Homo_Sapiens();
            var random = new Random();
            var viewless = new Homo_Sapiens.Viewless();
            var skilldeliver = new Homo_Sapiens.Skilldeliver();

            while (human.alive)
            {
                if (viewless.alive == false && skilldeliver.alive == false)
                {
                    break;
                }

                string name = Console.ReadLine();
                if (name.ToLower() == "viewless")
                {
                    while (viewless.alive == true)
                    {
                        int randomEmotion = random.Next(emotions.Count);
                        var age = Age(viewless.birthDay);
                        

                        if (age > 100)
                        {
                            viewless.alive = false;
                        }

                        if (viewless.alive == false)
                        {
                            Console.WriteLine("Viewless does not exist anymore");
                            continue;
                        }
                        Console.WriteLine(emotions[randomEmotion]);
                    }
                }
                else if (name.ToLower() == "skilldeliver")
                {
                    while (skilldeliver.alive == true)
                    {

                        int randomEmotion = random.Next(emotions.Count);
                        var age = Age(skilldeliver.birthDay);
                       

                        if (age > 100)
                        {
                            skilldeliver.alive = false;
                        }

                        if (skilldeliver.alive == false)
                        {
                            Console.WriteLine("Skilldeliver does not exist anymore");
                            continue;
                        }
                        Console.WriteLine(emotions[randomEmotion]);
                    }
                }


            }
        }

        public static int Age(DateTime date)
        {
            var now = DateTime.Today;
            var age = now.Year - date.Year;

            if (now.Month < date.Month)
            {
                age--;
            }
            else if (now.Month == date.Month)
            {
                if (now.Day < date.Day)
                {
                    age--;
                }
            }

            return age;
        }
    }

    class Homo_Sapiens
    {
        public bool alive = true;

        public class Viewless
        {
            public bool alive = true;
            public List<string> emotions { get; set; }
            public DateTime birthDay = DateTime.Parse("02.01.1995", CultureInfo.InvariantCulture);
        }
        public class Skilldeliver
        {
            public List<string> emotions { get; set; }
            public DateTime birthDay = DateTime.Parse("04.29.2000", CultureInfo.InvariantCulture);
            public bool alive = true;
        }

    }
}