using System;
using System.Collections.Generic;
using sleekadthancsharp;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;

namespace sleekadthancsharp
{
    internal class AdthanPlayer
    {

        private List<string> phrases = new List<string>();
        private List<string> basePrayerQuotes = new List<string>()
            {
                "“And to establish prayer and fear Him.” And it is He to whom you will be gathered.” (Quran 6:72)",
                "“And establish prayer and give zakah and bow with those who bow [in worship and obedience.” (Quran 2:43)",
                "Sins Take you away from Allah. Salah takes you back to Allah."


            };

        private List<string> Fajr = new List<string>()
            {
                "“Prayer is better than sleep.” Ibn Majah",
                "The prophet Muhammad Peace be upon Said: if people knew about the reward for the isha and fajar prayer, they would come (to the mosques) even if they had to crawl.",
                "The beauty of Fajr, is knowing that Allah (S.W.T) chose you to be amongst those who worship him While the rest of the world sleeps."

            };

        private List<string> Dhuhr = new List<string>()
            {
                "Take time to make time for the one who made time.",
                "Strange! how sensitive our ears are to the beep of our phones, Yet deaf to the Call of Salah."

            };

        private List<string> Asr = new List<string>()
            {
                "\"Whoever misses the 'Asr prayer (intentionally) then it is as if he lost his family and property.\""
            };

        private List<string> Maghrib = new List<string>()
            {
                "Delay anything but Prayer"

            };

        private List<string> Isha = new List<string>()
            {
                "The prophet Muhammad Peace be upon Said: if people knew about the reward for the isha and fajar prayer, they would come (to the mosques) even if they had to crawl.",

            };


        public virtual List<string> SelectPhrases(string prayer)
        {

            switch (prayer)
            {
                case "Fajr":
                    phrases.Add(Fajr.PickRandom());
                    break;
                case "Dhuhr":
                    phrases.Add(Dhuhr.PickRandom());
                    break;
                case "Asr":
                    phrases.Add(Asr.PickRandom());
                    break;
                case "Maghrib":
                    phrases.Add(Maghrib.PickRandom());
                    break;
                case "Isha":
                    phrases.Add(Isha.PickRandom());
                    break;
                default:
                    phrases.Add("");
                    break;
            }
            //phrases.Add(basePrayerQuotes.PickRandom());
            return phrases;
        }

        string path = @"C:\Users\Nasir\source\repos\sleekadthancsharp\sleekadthancsharp";
        private System.Media.SoundPlayer player;
        public void PlayAdthan(bool fajr)
        {
            if (fajr) 
            {
                player = new System.Media.SoundPlayer(path + @"\fajr adthan.wav");
                //play fajr adthan
            }
            else
            {
                //play normal adthan
                player = new System.Media.SoundPlayer(path + @"\normal adthan.wav");
            }
            player.Play();
        }

        public void StopAdthan()
        {
            if (player != null)
            {
                player.Stop();
            }
        }

    }
}
