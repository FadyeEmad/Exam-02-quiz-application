using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_02_quiz_application
{
    internal class Question : answer
    {
        public string Header { get; set; }
        public string[] Body = new string[1000];
        public int[] Mark = new int[1000];
    }
    class MCQ : Question
    {

    }
      class T_OR_F : Question
      { 

      }
    class answer
    {
        public int [] answer_text = new int[1000]; 

        public int [] answer_id  = new int[1000]; 

        public string[] answer_list = new string[3000]; 
    }
}

