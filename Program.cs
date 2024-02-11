Console.Clear();
// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.
// char[,] array = new char[,] { { 'a', 'b', '2', 'd', 'e' }, { '!', 'g', 'h', '1', 'j' } };

// string GetStringFromCharArray(char[,] array)
// {
//     string result = string.Empty;
//     foreach (char symbol in array)
//     {
//         result += symbol; // result = result + symbol
//     }
//     return result;
// }
// Console.WriteLine(GetStringFromCharArray(array));



// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.

// string myString = "giubIUBUpbi";
// string lowerCaseString = myString.ToLower();
// Console.WriteLine(lowerCaseString);



// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

// bool IsPalindrome(string str)
// {
//     string strLower = str.ToLower(); // перевод строки в нижний регистр
//     for (int i = 0, j = strLower.Length - 1; i < strLower.Length; i++, j--)
//     {
//         if (strLower[i] != strLower[j])
//         {
//             return false;
//         }
//     }
//     return true;
// }

// string str = Console.ReadLine();
// Console.WriteLine(IsPalindrome(str) ? "Yes" : "No"); // это тернарный операто: Условие ? значение если истина : значение если лож сокращение от IF



// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку, в которой слова расположены в обратном порядке. В полученной строке слова должны быть также разделены пробелами.

// string ReverseWords(string str)
// {
//     string[] words = str.Split(' ');
//     Array.Reverse(words);
//     return string.Join(" ", words);
// }

// // Пример использования
// string input = "Hello my world!";
// string reversedWords = ReverseWords(input);
// Console.WriteLine($"Исходная строка: {input}");
// Console.WriteLine($"Реверсированные слова: {reversedWords}");