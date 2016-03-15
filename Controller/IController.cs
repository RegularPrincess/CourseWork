using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelForCourseWork.Models;

namespace Controller
{
    interface IController
    {
        /**
            Методы разбора ответов пользователя, поиск подходящего из списка возможных
            answer - текст ответа пользователя
            Возвращает следующий вопрос обернутый в класс Question
        **/
        Question getNextQuestion(String answer);
        
        Question getFirstQuestion(String nameOfDialog);
    }
}
