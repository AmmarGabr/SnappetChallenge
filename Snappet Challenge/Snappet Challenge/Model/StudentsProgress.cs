using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snappet_Challenge.Model
{
    class StudentsProgress
    {

        ReadJsonFile jsonFile = new ReadJsonFile();
        List<string> SubjectsList = new List<string>();
        List<int> userIdsList = new List<int>();

        public StudentsProgress()
        {
            jsonFile.GetJsonFile();
            SetAllStudentsToUserIdsList();
            SetAllSubjects();
        }

        //returns a list with todays date information
        public List<ChilderenResults> GetOnlyTodayQuestions()
        {
            return jsonFile.GetOnlyTodayQuestions();
        }

        //Set all students id to the userids list
        public void SetAllStudentsToUserIdsList()
        {
            bool isExist;
            foreach (ChilderenResults i in jsonFile.GetOnlyTodayQuestions())
            {
                isExist = false;
                foreach (int x in userIdsList)
                {
                    if (i.userId == x)
                    {
                        isExist = true;
                        break;
                    }
                }
                if (!isExist)
                {
                    userIdsList.Add(i.userId);
                }
            }
        }

        //Returns the userids list
        public List<int> GetUsersIds()
        {
            return userIdsList;
        }

        //Set all Subjects the subjects List
        public void SetAllSubjects()
        {
            bool isSubjectExist;
            foreach (ChilderenResults i in jsonFile.GetOnlyTodayQuestions())
            {
                isSubjectExist = false;
                foreach (var x in SubjectsList)
                {
                    if (i.subject == x)
                    {
                        isSubjectExist = true;
                    }
                }
                if (!isSubjectExist)
                {
                    SubjectsList.Add(i.subject);
                }
            }
        }

        //returns the Subjects List
        public List<string> GetAllSubjects()
        {
            return SubjectsList;
        }

        //Returns all learning Objectives Of A Specific Subject
        public List<string> GetLearningObjectivesOfASpecificSubject(string subject)
        {
            List<string> LearningObjectivesOfASpecificSubject = new List<string>();
            bool isLearningObjectiveExist;

            foreach (ChilderenResults i in GetOnlyTodayQuestions())
            {
                if (subject == i.subject)
                {
                    isLearningObjectiveExist = false;
                    foreach (string x in LearningObjectivesOfASpecificSubject)
                    {
                        if (i.learningObjective == x)
                        {
                            isLearningObjectiveExist = true;
                            break;
                        }
                    }
                    if (!isLearningObjectiveExist)
                    {
                        LearningObjectivesOfASpecificSubject.Add(i.learningObjective);
                    }
                }
            }
            return LearningObjectivesOfASpecificSubject;
        }

        //Return a list with the latest Progress Of All students based on the selected Learning Objective by the user
        public List<ChilderenResults> GetLatestProgressBasedOnLastSubmition(string selectedLo)
        {
            List<ChilderenResults> StudentsLatestProgress = new List<ChilderenResults>();

            DateTime MaxDateTimeOfSubmition = new DateTime(2015, 03, 23, 00, 00, 00);
            int Finalprogress = 0;
            string learningObjective = "";
            //get the maximum progress of each learning objective for each student
            foreach (int x in GetUsersIds())
            {
                foreach (ChilderenResults i in GetOnlyTodayQuestions())
                {
                    if (i.userId == x && i.learningObjective == selectedLo)
                    {
                        if (i.submitDateTime > MaxDateTimeOfSubmition)
                        {
                            MaxDateTimeOfSubmition = i.submitDateTime;
                            Finalprogress = i.progress;
                            learningObjective = i.learningObjective;
                        }
                    }
                }
                if (learningObjective != "")
                {
                    StudentsLatestProgress.Add(new ChilderenResults(0, MaxDateTimeOfSubmition, false, Finalprogress, x, 0, "", "", "", learningObjective));
                }
                learningObjective = "";
                MaxDateTimeOfSubmition = new DateTime(2015, 03, 23, 00, 00, 00);
                Finalprogress = 0;
            }
            return StudentsLatestProgress;
        }
    }
}
