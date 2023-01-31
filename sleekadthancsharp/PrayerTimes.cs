using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

// handle errors...
// add getters and setters for data validation

namespace sleekadthancsharp
{
    internal class PrayerTimes
    {
        private dynamic Data;
        public string curr_prayer;
        private List<string> timings = new List<string>()
        {
           "Fajr",
           "Sunrise",
           "Dhuhr",
           "Asr",
           "Sunset",
           "Maghrib",
           "Isha",
           "Imsak",
           "Midnight"
        };
        private List<string> prayers = new List<string>()
        {
           "Fajr",
           "Sunrise",
           "Dhuhr",
           "Asr",
           "Maghrib",
           "Isha",
        };
        public List<TimeSpan> curr_times= new List<TimeSpan>();
        public List<TimeSpan> CalculateTimes(string city, string country,int day, int month, int year)
        {
            
            List<TimeSpan> times = new List<TimeSpan>();
            string URL = "https://api.aladhan.com/v1/calendarByCity";
            string urlParameters = $"?city={city}&country={country}&method=2&month={month}&year={year}";

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            HttpResponseMessage response = client.GetAsync(urlParameters).Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body.
                var str =  response.Content.ReadAsStringAsync();
                str.Wait();
                Data = JsonConvert.DeserializeObject(str.Result);
            
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }

            // Make any other calls using HttpClient here.

            // Dispose once all HttpClient calls are complete. This is not necessary if the containing object will be disposed of; for example in this case the HttpClient instance will be disposed automatically when the application terminates so the following call is superfluous.
            client.Dispose();
            foreach (string t in Data.data[day].timings)
            {
                string v = t.Substring(0, 5);
                TimeSpan e = TimeSpan.Parse(v);
                times.Add(e);
            }
            return times;
        }

        public bool CheckTime(TimeSpan time, AdthanPlayer player, Dictionary<string, landing.NotificationSetting> play, bool master)
        {
            //ensure to pass a player object
            if(curr_times.Count == 0)
            {
                return false;
            }
            else
            {
                int c = 0;
                foreach (TimeSpan t in curr_times)
                {

                    if (t.Seconds == time.Seconds && t.Minutes == time.Minutes && t.Hours == time.Hours)
                    {
                        curr_prayer = timings[c];
                        if (prayers.Contains(timings[c]) && play[timings[c]] == landing.NotificationSetting.Adthan && master)
                        {
                            if (timings[c] == "Fajr")
                            {
                                player.PlayAdthan(true);
                            }
                            else
                            {
                                player.PlayAdthan(false);
                            }
                        }
                        return true;
                    }
                    c++;
                }
                return false;
            }
        } 

        //contructor for init
        public PrayerTimes(string city, string country, int day ,int month, int year)
        {
            curr_times = CalculateTimes(city, country, day,month, year);
        }

    }
}
