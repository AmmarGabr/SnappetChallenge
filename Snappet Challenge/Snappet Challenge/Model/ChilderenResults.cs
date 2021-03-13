using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snappet_Challenge
{
    public class ChilderenResults
    {
        //all the variables that are in the Data JSON File 

        public int submittedAnswerId { get; set; }
        public DateTime submitDateTime { get; set; }
        public bool correct { get; set; }
        public int progress { get; set; }
        public int userId { get; set; }
        public int exerciseId { get; set; }
        public string difficulty { get; set; }
        public string subject { get; set; }
        public string domain { get; set; }
        public string learningObjective { get; set; }

        public ChilderenResults(int SubmittedAnswerId, DateTime SubmitDateTime, bool Correct, int Progress, int UserId, int ExerciseId, string Difficulty, string Subject, string Domain, string LearningObjective)
        {
            this.submittedAnswerId = SubmittedAnswerId;
            this.submitDateTime = SubmitDateTime;
            this.correct = Correct;
            this.progress = Progress;
            this.userId = UserId;
            this.exerciseId = ExerciseId;
            this.difficulty = Difficulty;
            this.subject = Subject;
            this.domain = Domain;
            this.learningObjective = LearningObjective;
        }

    }
}
