using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_02_quiz_application
{
    internal class Exam 
    {
        public int Time_of_exam { get; set; }
        public int Number_of_Questions { get; set; }

        public void show_exam(Question q1, MCQ mcq, T_OR_F true_or_false, int t_or_false1, int mcq1)
        {
                int counter_question = 0;
                int counter_answer = 0;
            if (t_or_false1 > 0 && mcq1 > 0)
            {
            Console.WriteLine("mcq questions");
            Console.WriteLine("---------------");
                Console.WriteLine("choose the right answer by number");
                while (counter_question < mcq1)
                {
                    Console.WriteLine(mcq.Body[counter_question]);
                    Console.WriteLine($"{1} - {mcq.answer_list[counter_answer]}");
                    counter_answer++;
                    Console.WriteLine($"{2} -{mcq.answer_list[counter_answer]}");
                    counter_answer++;
                    Console.WriteLine($"{3} -{mcq.answer_list[counter_answer]}");
                    counter_answer++;
                    q1.answer_id[counter_question] = int.Parse(Console.ReadLine());
                    counter_question++;

                }
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("True or False questions");
                Console.WriteLine("--------------------------");
                counter_answer = 0;
                Console.WriteLine("choose the right answer by number");
                for (int x = 0; x < t_or_false1; x++)
                {
                    Console.WriteLine(true_or_false.Body[x]);
                    Console.WriteLine($"{1} - {true_or_false.answer_list[counter_answer]}");
                    counter_answer++;
                    Console.WriteLine($"{2} -{true_or_false.answer_list[counter_answer]}");
                    counter_answer++;
                    q1.answer_id[counter_question] = int.Parse(Console.ReadLine());
                    counter_question++;

                }
                
            }
            else if (t_or_false1 > 0 && mcq1 == 0)
            {
                Console.WriteLine("True or False questions");
                Console.WriteLine("--------------------------");
                counter_answer = 0;
                Console.WriteLine("choose the right answer by number");
                for (int x = 0; x < t_or_false1; x++)
                {
                    Console.WriteLine(true_or_false.Body[x]);
                    Console.WriteLine($"{1} - {true_or_false.answer_list[counter_answer]}");
                    counter_answer++;
                    Console.WriteLine($"{2} -{true_or_false.answer_list[counter_answer]}");
                    counter_answer++;
                    q1.answer_id[counter_question] = int.Parse(Console.ReadLine());
                    counter_question++;

                }
            }
            else 
            {
             
                while (counter_question < mcq1)
                {
                    Console.WriteLine("choose the right answer by number");
                    Console.WriteLine(mcq.Body[counter_question]);
                    Console.WriteLine($"{1} - {mcq.answer_list[counter_answer]}");
                    counter_answer++;
                    Console.WriteLine($"{2} -{mcq.answer_list[counter_answer]}");
                    counter_answer++;
                    Console.WriteLine($"{3} -{mcq.answer_list[counter_answer]}");
                    counter_answer++;
                    q1.answer_id[counter_question] = int.Parse(Console.ReadLine());
                    counter_question++;
                }
            }

        }
        public void grade_final(Question q1)
        {
            Console.WriteLine(" Model answer by number of question");
            Console.WriteLine("------------------------------------");
            int g = 0;
            int counter = 0;
            while (counter < Number_of_Questions)
            {
                if (q1.answer_text[counter] == q1.answer_id[counter])
                {
                    g += q1.Mark[counter];
                }
                Console.WriteLine($" q1 -> {q1.answer_text[counter]} ");
                counter++;
            }
            Console.WriteLine($"Grade = {g} ");
        }
        public void grade_practical(Question q1)
        {
            Console.WriteLine(" Model answer by number of question");
            Console.WriteLine("------------------------------------");
            int counter = 0;
            while (counter < Number_of_Questions)
            {
                Console.WriteLine($" q1 -> {q1.answer_text[counter]} ");
                counter++;
            }
        }
    }


        class subject 
    {
        public int Subject_id { get; set; }
        public string Subject_name { get; set; }
         
    }

}

