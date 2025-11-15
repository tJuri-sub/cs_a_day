//Continuation: capitalize(uppercase first letter of each word) strings using built in function

string str1 = "minecraft world";

Console.WriteLine("Before Capitalization: " + str1);

string string1 = char.ToUpper(str1[0]) + str1.Substring(1, 9);
string string2 = char.ToUpper(str1[10]) + str1.Substring(11); 

string stringCapitalized = string1 + string2;

Console.WriteLine("After Capitalization: " + stringCapitalized);