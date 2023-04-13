#nullable disable

/*
Application Description:

In a school course, 3 exams (each marked out of 100) are carried out during the school term. 
The average of the exam marks is calculated for a student at the end of the term.
The student passes the course if the average mark is more than or equal to 50.
A user will use this C# Console application to :
(i) 	Enter a student name
(ii) 	Enter the student's exam marks
(iii)   Calculate the student's average mark at the end of the term
(iv) 	Send a message in the output window to state if the student passes or fails the course and state the average mark
 */

// Initialize variables

string studentName = string.Empty;
int[] examMarks = new int[3];
int sumExamMarks = 0;
int avg = 0;
string message = string.Empty;

// Accept user inputs and set variables

Console.WriteLine("Enter a Student Name: ");
studentName = Console.ReadLine();

for (int i = 0; i < examMarks.Length; i++)
{
    Console.WriteLine($"Enter Exam Mark {i + 1} : ");
    examMarks[i] = Convert.ToInt32(Console.ReadLine());
}

// Calculate average exam mark

foreach (int examMark in examMarks)
{
    sumExamMarks = sumExamMarks + examMark;
}

avg = sumExamMarks / examMarks.Length;

// Set user message

if (avg >= 50)
{
    message = $"{studentName} has PASSED the course with an average mark of : {avg}";
}
else
{
    message = $"{studentName} has FAILED the course with an average mark of : {avg}";
}

// Display user message

Console.WriteLine(message);