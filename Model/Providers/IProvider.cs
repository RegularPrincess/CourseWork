using ModelForCourseWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelForCourseWorc.Providers
{
    interface IProvider
    {
        Dialog getDialog(String source);
        void saveDialog(String store);
    }
}
