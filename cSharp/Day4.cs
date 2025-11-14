//uppercase-all and lowercase-all strings using built in function

string str1 = "hello world";

string transformedStringUppercase = str1.ToUpper();

Console.WriteLine(transformedStringUppercase);

string str2 = "HELLO WORLD";

string transformedStringLowercase = str2.ToLower();

Console.WriteLine(transformedStringLowercase);

string capitalString1 = char.ToUpper(str1[0]) + str1.Substring(1);


Console.WriteLine(capitalString1);