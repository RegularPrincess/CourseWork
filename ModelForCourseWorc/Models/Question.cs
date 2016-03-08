using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelForCourseWork.Models
{
    public class Question
    {
        public Question(string question, Dictionary<string, Question> answers)
        {
            questionStr = question;
            this.answers = answers; 
        }
        public Question(string question)
        {
            questionStr = question;
            answers = new Dictionary<string, Question>();
        }

        private string questionStr;
        Dictionary<string, Question> answers;

        public string QuestionStr
        {
            get { return questionStr; }
        }
                
        public Dictionary<string, Question> Answers
        {
            get { return answers; }
        }

        public bool addAnswer(string answer, Question question)
        {
            if (!answers.ContainsKey(answer))
            {
                answers.Add(answer, question);
                return true;
            }
            return false;
        }
    }
}
