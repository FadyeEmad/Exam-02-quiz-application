using Exam_02_quiz_application;
using System.Diagnostics;
subject s1= new subject();
Console.WriteLine("Please enter  subject id ");
s1.Subject_id= int.Parse(Console.ReadLine());
Console.WriteLine("Please enter  subject name");
s1.Subject_name= Console.ReadLine() ;
Console.WriteLine("Please Enter The Type Of Exam (1 For Practical | 2 For final)"); 
int type=int.Parse(Console.ReadLine());
if (type!=1 && type != 2)
{
    while (type != 2 && type != 1)
        Console.WriteLine("enter 1 or 2");
    type = int.Parse(Console.ReadLine() );

}
Console.WriteLine("Please Enter the time For Exam From (30 min to 10 min)");
int t = int.Parse(Console.ReadLine());
if (t > 30 || t < 10)
{
    while(t > 30 || t < 10)
    {
        Console.WriteLine("enter time between 10 to 30 min");
        t = int.Parse(Console.ReadLine());
    }
}
int num_of_mcq_question = 0;
int num_of_t_ot_f_question = 0;
if (type == 1)
{
    Console.WriteLine("Please Enter the Number Of mcq question");
     num_of_mcq_question = int.Parse(Console.ReadLine());
}
else if (type == 2){
    Console.WriteLine("Please Enter the Number Of mcq question");
     num_of_mcq_question = int.Parse(Console.ReadLine());
    Console.WriteLine("Please Enter the Number Of true or false question");
    num_of_t_ot_f_question= int.Parse(Console.ReadLine());

}

Question q1 = new Question();
MCQ mCQ1 = new MCQ();
T_OR_F t_OR_F = new T_OR_F();
int counter = 0, counter_mcq = 0, counter_t_f = 0, counter_body_mcq = 0 , counter_body_t_f = 0;
while (counter < (num_of_mcq_question + num_of_t_ot_f_question))
{
    if (type == 2)
    {
        Console.WriteLine("Please Enter Type Of Question (1 for MCQ | 2 For True or False)");
        int qtype = int.Parse(Console.ReadLine());
        if (qtype != 1 && qtype != 2)
        {
            while (qtype != 2 && qtype != 1)
                Console.WriteLine("enter 1 or 2");
            qtype = int.Parse(Console.ReadLine());
        }
        if (qtype == 1)
        {
            Console.WriteLine("MCQ Question \n Please Enter Question Body");
            mCQ1.Body[counter_body_mcq] = Console.ReadLine();
            Console.WriteLine("Choices of Question ");
            Console.WriteLine("Please Enter Choice Number 1");
            mCQ1.answer_list[counter_mcq] = Console.ReadLine();
            counter_mcq++;
            Console.WriteLine("Please Enter Choice Number 2");
            mCQ1.answer_list[counter_mcq] = Console.ReadLine();
            counter_mcq++;
            Console.WriteLine("Please Enter Choice Number 3");
            mCQ1.answer_list[counter_mcq] = Console.ReadLine();
            counter_mcq++;
            Console.WriteLine("Please Enter The Right Answer Id");
            q1.answer_text[counter]=int.Parse(Console.ReadLine()) ;
            while (q1.answer_text[counter] > 3)
            {
                Console.WriteLine("enter number between 1 to 3");
                q1.answer_text[counter] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Please Enter  question mark ");
            q1.Mark[counter]=int.Parse( Console.ReadLine());
            counter++;
            counter_body_mcq++;
        }
        else if (qtype == 2)
        {
            Console.WriteLine("True or False \n Please Enter Question Body");
            t_OR_F.Body[counter_body_t_f] = Console.ReadLine();
            Console.WriteLine("Please Enter The Right Answer Id -> (1 for true | 2 For False");
            t_OR_F.answer_list[counter_t_f] = "True";
            counter_t_f++;
            t_OR_F.answer_list[counter_t_f] = "False";
            counter_t_f++;
            q1.answer_text[counter] = int.Parse(Console.ReadLine());
            while (q1.answer_text[counter] > 2)
            {
                Console.WriteLine("enter number between 1 to 3");
                q1.answer_text[counter] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Please Enter  question mark ");
            q1.Mark[counter] = int.Parse(Console.ReadLine());
            counter++;
            counter_body_t_f++;
        }
    }
    else if (type == 1)
    {

        Console.WriteLine("MCQ Question \n Please Enter Question Body");
        mCQ1.Body[counter_body_mcq] = Console.ReadLine();
        Console.WriteLine("Choices of Question ");
        Console.WriteLine("Please Enter Choice Number 1");
        mCQ1.answer_list[counter_mcq] = Console.ReadLine();
        counter_mcq++;
        Console.WriteLine("Please Enter Choice Number 2");
        mCQ1.answer_list[counter_mcq] = Console.ReadLine();
        counter_mcq++;
        Console.WriteLine("Please Enter Choice Number 3");
        mCQ1.answer_list[counter_mcq] = Console.ReadLine();
        counter_mcq++;
        Console.WriteLine("Please Enter The Right Answer Id");
        q1.answer_text[counter] = int.Parse(Console.ReadLine()); // model answer
        while (q1.answer_text[counter] > 3)
        {
            Console.WriteLine("enter number between 1 to 3");
            q1.answer_text[counter] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Please Enter  question mark ");
        q1.Mark[counter] = int.Parse(Console.ReadLine()); // exam marks
        counter++;
        counter_body_mcq++;
    }
}
    Exam e1 = new Exam();
e1.Number_of_Questions = num_of_mcq_question + num_of_t_ot_f_question;
Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
Console.WriteLine(" 1- start exam  , 2- exit ");
int e = int.Parse(Console.ReadLine());
if (e == 1)
{
    Console.WriteLine($" {s1.Subject_name} exam");
    Console.WriteLine("-------------------------");
    Stopwatch stopwatch = new Stopwatch();
    if (type == 2)
    {
        stopwatch.Start();
        e1.show_exam(q1, mCQ1, t_OR_F, num_of_t_ot_f_question, num_of_mcq_question);
        stopwatch.Stop();
        e1.grade_final(q1);
        Console.WriteLine($"time in exam -> {stopwatch.Elapsed.Seconds} S ");
    }
    else if (type == 1)
    {
        stopwatch.Start();
        e1.show_exam(q1, mCQ1, t_OR_F, 0, num_of_mcq_question);
        stopwatch.Stop();
        e1.grade_practical(q1);
        Console.WriteLine($"time in exam -> {stopwatch.Elapsed.TotalSeconds} S");

    }
}
else
{
    return;
}

