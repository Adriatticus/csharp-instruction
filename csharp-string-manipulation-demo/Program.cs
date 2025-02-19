using ConsoleLibrary;

namespace csharp_string_manipulation_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Where are my letters??!?!!!??\n");

            // define theWord
            string theWord = "superstitious";
            MyConsole.PrintL($"theWord = {theWord}");

            // generate hiddenWord (string == theWord.Length, all underscores)
            string hiddenWord = "";
            // # letters in theWord
            // hiddenWord -> same length as theWord, all underscores
            foreach (char word in theWord)
            {
                hiddenWord += "_";
            }
            MyConsole.PrintL($"hiddenWord {hiddenWord}");

            // display hiddenWord w/ spaces separating the underscores

            MyConsole.PrintL("display hiddenWord");

            DisplayHiddenWord(hiddenWord);

            string letter = "";
            bool winner = false;
            while (!winner)
            {

            // resolve correct guessed letter
            // promt user for a letter: string
            letter = MyConsole.PromptString("Guess a letter: ");
            // iterate over theWord, and find any matches for letter
            char[] charsTheWord = theWord.ToCharArray();
            char[] charsHiddenWord = hiddenWord.ToCharArray();
            for(int i = 0; i < charsTheWord.Length; i++)
            {
                char c = charsTheWord[i];
                if (letter.Equals(c.ToString()))
                {
                    MyConsole.PrintL($"Letter found! {i}");
                    // resolve this character in hiddenWord
                    charsHiddenWord[i] = c;
                }
            }
            hiddenWord = new string (charsHiddenWord);
            if (hiddenWord.IndexOf('_') == -1)
                {
                    winner = true;
                }
            DisplayHiddenWord(hiddenWord);


            }
            MyConsole.PrintL("\nOh there they are!!!!");
        }

        private static void DisplayHiddenWord(string hiddenWord)
        {
            foreach (char c in hiddenWord)
            {
                MyConsole.Print(c + " ");
            }
            MyConsole.PrintL("");
        }
        
    }
}
