using ConsoleLibrary;
using csharp_project_hangman.Model;

namespace csharp_project_hangman
{
    internal class Program
    {
        static List<HangmanWords> hangmanWord = new List<HangmanWords>();
        static string[] images = new string[7];

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! Goodbye hanged man!\n");

            PopulateImages();

            string choice = "y";
            while (choice == "y")
            {

            }
            choice = MyConsole.PromptStrInRange("Play another round? (y/n)", "y", "n");
              
            string guess = MyConsole.PromptString("Guess a letter: ");
            int count = 0 ;
            int incorrectGuesses = 0;

            //for (int i = 0; i < images.Length; i++)
            //{

            //}

            string howMuchMan = GetHangedManImage(6);
            MyConsole.PrintL(howMuchMan);

            
           
        }

        
        private static void PopulateImages()
        {
            images[0] =

            """
                ______________________
                   \|/            |
                    |             |
                    |             
                    |             
                    |           
                    |          
                    |          
                    |          
                    |                
                    |               
                    |      
                   /|\
                __/_|_\____________________
                |                         |
            """;
            //Console.WriteLine(hangedMan0);
            MyConsole.PrintL("\nHanged man? Can you hear me?\n...");

            images[1] =

            """
                ______________________
                   \|/            |
                    |             |
                    |             WWWWW
                    |             @ 0 0
                    |              \_c/
                    |              
                    |             
                    |             
                    |                
                    |               
                    |             
                   /|\
                __/_|_\____________________
                |                         |
            """;

            images[2] =

            """
                ______________________
                   \|/            |
                    |             |
                    |             WWWWW
                    |             @ 0 0
                    |             /\_c/_
                    |             |__|_| 
                    |             |____|
                    |          
                    |                
                    |               
                    |             
                   /|\
                __/_|_\____________________
                |                         |
            """;
            images[3] =

            """
                ______________________
                   \|/            |
                    |             |
                    |             WWWWW
                    |             @ 0 0
                    |           __/\_c/_
                    |          / /|__|_|
                    |          | ||____|
                    |          |_>
                    |                
                    |             
                    |             
                   /|\
                __/_|_\____________________
                |                         |
            """;

            images[4] =

            """
                ______________________
                   \|/            |
                    |             |
                    |             WWWWW
                    |             @ 0 0
                    |           __/\_c/_
                    |          / /|__|_| \
                    |          | ||____|\ |
                    |          |_>      <_|
                    |                
                    |               
                    |             
                   /|\
                __/_|_\____________________
                |                         |
            """;

            images[5] =

            """
                ______________________
                   \|/            |
                    |             |
                    |             WWWWW
                    |             @ 0 x
                    |           __/\_c/_
                    |          / /|__|_| \
                    |          | ||____|\ |
                    |          |_>|  _ |<_|
                    |             |  |    
                    |             |  |  
                    |             (___)
                   /|\
                __/_|_\____________________
                |                         |
            """;

            images[6] =

            """
                ______________________
                   \|/            |
                    |             |
                    |             WWWWW
                    |             @ x x
                    |           __/\_c/_
                    |          / /|__|_| \
                    |          | ||____|\ |
                    |          |_>|  _ |<_|
                    |             |  | |   
                    |             |  | |
                    |             (___)__)
                   /|\
                __/_|_\____________________
                |                         |
            """;

        }





        private static string GetHangedManImage(int incorrectGuessses)
        {
            return images[incorrectGuessses];
        }




    }
}
