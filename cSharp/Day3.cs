//Trim whitespace from strings using built in function

string str1 = " Hello ";
string trimmedString = str1.Trim();

Console.WriteLine(trimmedString + "World");

string leftTrimmedString = str1.TrimStart();

Console.WriteLine(leftTrimmedString + "World");

string rightTrimmedString = str1.TrimEnd();

Console.WriteLine(rightTrimmedString + "World");