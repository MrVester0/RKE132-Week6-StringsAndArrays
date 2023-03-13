//string hello = " hello, world! Here i am! ";

string hello = " we are here? ";

int stringLength = hello.Length;

//string trimmedString = hello.Trim();

hello = hello.Trim();

char firstLetter = hello[0];
Console.WriteLine(firstLetter);

hello = hello.Replace(hello[0], char.ToUpper(hello[0])).Replace('?', '!');

firstLetter = hello[0];
Console.WriteLine(firstLetter);

Console.WriteLine(hello);

//int wordCounter = 1;
//for (int i = 0; i < hello.Length; i++)
//{
//Console.WriteLine($"{i} symbol in string: {hello[i]}");
//if (hello[i] == ' ') { wordCounter++;}
//if (char.IsWhiteSpace(hello[i]))
//{
//    wordCounter++;
//}
//}

//Console.WriteLine($"Word count in {hello}: {wordCounter} words.");

