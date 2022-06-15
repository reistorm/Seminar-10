// // // В некотором машинном алфавите имеются четыре буквы
// «а», «и», «с» и «в». Покажите все слова, состоящие из 
// n букв, которые можно построить из букв этого алфавита.
// n = 2 -> аа, ии, сс, вв, аи, иа, ис, си, ас, са,
// ав, ва, ви, ив, св, вс

string charWords = "аисв";
int countCharsInWords = 3;
PrintAllWords(charWords, countCharsInWords, "");
void PrintAllWords(string letters, int length, string prefix)
{
    if (length == 0) Console.Write(prefix + " ");
    else 
    {
        foreach (char c in letters ) // перебирает по порядку аисв. каждому с присваивает а или и или с или в 
// char - символ строки и перебор. с - переменная
        {
            PrintAllWords(letters, length - 1, prefix + c);
        }
    }
}
