//concatenate float and string without getting an error

float grades = 96.80f;
string name = "juri turiano";

Console.WriteLine(grades + " " + name);

string stringedGrades = grades.ToString();
Console.WriteLine(stringedGrades + " " + name);

Console.WriteLine(string.Concat(grades, " ", name));