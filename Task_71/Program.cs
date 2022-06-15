// // В некотором машинном алфавите имеются четыре буквы
// «а», «и», «с» и «в». Покажите все слова, состоящие из 
// n букв, которые можно построить из букв этого алфавита.
// n = 2 -> аа, ии, сс, вв, аи, иа, ис, си, ас, са,
// ав, ва, ви, ив, св, вс

string letters = "аисв";
void GenWords(string letters, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{new String(word)}");
        return;
    }
    for (int i = 0; i < letters.Length; i++)
    {
        word[length] = letters[i];
        GenWords(letters, word, length + 1);
    }
}
Console.Write("Введите t: ");
int t = Convert.ToInt32(Console.ReadLine());
GenWords(letters, new char[t]);