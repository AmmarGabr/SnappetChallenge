using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snappet_Challenge.Model
{
    public class ReadJsonFile
    {

        List<ChilderenResults> fullList = new List<ChilderenResults>();
        List<ChilderenResults> todaysList = new List<ChilderenResults>();

        DateTime dateTimeNow = new DateTime(2015, 03, 24, 11, 30, 00);
        DateTime dateTimeTodayMidNight = new DateTime(2015, 03, 24, 00, 00, 00);

        //Reads Json File and save it to a list
        public void GetJsonFile()
        {
            using (StreamReader r = new StreamReader(@"..\..\..\..\Data\work.json"))
            {
                string json = r.ReadToEnd();
                fullList = JsonConvert.DeserializeObject<List<ChilderenResults>>(json);
            }
            SetOnlyTodayQuestions();
        }

        //Make a new list with today's date to use less time when looping through the list
        public void SetOnlyTodayQuestions()
        {
            foreach (ChilderenResults i in fullList)
            {
                if (i.submitDateTime < dateTimeNow && i.submitDateTime > dateTimeTodayMidNight)
                {
                    todaysList.Add(i);
                }
            }
        }

        //Returns the list with only today's questions
        public List<ChilderenResults> GetOnlyTodayQuestions()
        {
            return todaysList;
        }


    }
}
