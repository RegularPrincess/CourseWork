using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelForCourseWork.Models;

namespace ModelForCourseWork.Services
{
    interface IService
    {
        Question getFirstQuestion();
        Question getNextQuestion(string answer, Question question);
    }
}
