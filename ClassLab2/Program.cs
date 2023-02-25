using ClassLab2;
using System.Data;

while (true)
{
    Console.WriteLine("1. Добавить студента");
    Console.WriteLine("2. Добавить преподавателя");
    Console.WriteLine("3. Добавить руководителя");
    Console.WriteLine("4. Добавить помощника");
    Console.WriteLine("-----------------------------------------------------------");
    Console.WriteLine("5. Издать экзамен");
    Console.WriteLine("6. Издать указ");
    Console.WriteLine("-----------------------------------------------------------");
    Console.WriteLine("7. Посмотреть список экзаменов");
    Console.WriteLine("8. Посмотреть список указов");
    Console.WriteLine("-----------------------------------------------------------");
    Console.WriteLine("9. Посмотреть список преподавателей с должниками");
    Console.WriteLine("10.Посмотреть список студентов по долгу");
    Console.WriteLine("11.Посмотреть все долги и какой преподаватель их принимает");
    Console.WriteLine("Выйти");
    int command = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    if (command == 1)
    {
        Students.StudentAdd();
    }
    else if (command == 2)
    {
        Teachers.TeacherAdd();
    }
    else if (command == 3)
    {
        Directors.DirectorsAdd();
    }
    else if (command == 4)
    {
        Helpers.HelpersAdd();
    }
    else if (command == 5)
    {
        Exams.ExamAdd();
    }
    else if (command == 6)
    {
        Rules.RuleAdd();
    }
    else if (command == 7)
    {
        Exams.ExamCount();
    }
    else if (command == 8)
    {
        Rules.RuleCount();
    }
    else if (command == 9)
    {
        Teachers.Dolg();
    }
    else if (command == 10)
    {
        Students.Dolg();
    }
    else if (command == 11)
    {
        Teachers.DolgAll();
    }
    else
    {
        break;
    }
    Console.ReadLine();
    Console.Clear();
}