//uppercase-all and lowercase-all strings using built in function

string str1 = "hello world";

string transformedStringUppercase = str1.ToUpper();

Console.WriteLine(transformedStringUppercase);

string str2 = "HELLO WORLD";

string transformedStringLowercase = str2.ToLower();

Console.WriteLine(transformedStringLowercase);

//['h','e','l','l','o',' ','w','o','r','l','d']
string capitalString1 = char.ToUpper(str1[0]) + str1.Substring(1, 5);
string finalString = char.ToUpper(str1[6]) + str1.Substring(7);
Console.WriteLine(capitalString1 + finalString);