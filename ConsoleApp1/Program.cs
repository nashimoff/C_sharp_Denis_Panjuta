// See https://aka.ms/new-console-template for more information


int month = 5;
string monthName;

if (month == 1)
{
    monthName = "January";
}

else if  (month == 2)
    monthName = "February";
else if  (month == 3)
    monthName = "March";
else 
    monthName = "Unknown";


switch (month)
{
    case 1:
        monthName = "January";
        break;
    case 2:
        monthName = "February";
        break;
    case 3:
        monthName = "March";
        break;
    default:
        monthName = "Unknown";
        break;
}

Console.WriteLine($" Then month is {monthName}");



























