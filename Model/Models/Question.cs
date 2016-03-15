using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelForCourseWork.Models
{
    public class Question
    {
        private string questionStr;
        private int id;
        Dictionary<string, Question> answers;

        public Question(string question, Dictionary<string, Question> answers, int id)
        {
            questionStr = question;
            this.id = id;
            this.answers = answers; 
        }
        public Question(string question, int id)
        {
            this.id = id;
            questionStr = question;
            answers = new Dictionary<string, Question>();
        }
        public string QuestionStr
        {
            get { return questionStr; }
        }
                
        public Question getNextQuestion(string answer)
        {
            return answers[answer];
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
