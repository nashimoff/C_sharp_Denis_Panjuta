// See https://aka.ms/new-console-template for more information

string question1 = "What is the capital of Germany";
string answer1 = "Berlin";

string question2 = "What is 2+2";
string answer2 = "4";

string question3 = "What color do you get by mixing blue and yellow";
string answer3 = "Green";

int score = 0;

Console.WriteLine("question1");
string userAnswer1 = Console.ReadLine();
if(userAnswer1 == answer1)
{
    Console.WriteLine("Correct");
    score = score+1;
}
else
{
    Console.WriteLine("Wrong, the correct answer is: " + answer1);
}