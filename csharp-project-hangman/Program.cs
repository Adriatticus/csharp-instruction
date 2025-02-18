using ConsoleLibrary;

namespace csharp_project_hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! Goodbye hanged man!\n");

            PopulateImages();

            //for (int i = 0; images.Length; i++)
            //{

            //}

            string hangedMan0 =

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
            Console.WriteLine(hangedMan0);
            MyConsole.PrintL("\nHanged man? Can you hear me?\n...");

            string hangedMan1 =

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
      
            string hangedMan2 =

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
            string hangedMan3 =

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

            string hangedMan4 =

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

            string hangedMan5 =

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

            string hangedMan6 =

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

            //private static string GetHangedManImage (int incorrectGuessses)
            //{
            //    string[] images = { "a", "b", "c" };
            //    return images[0];
            //}

            private static void PopulateImages()
            {
                string[] images = new string[7];

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

                return images[0];
            }



            private static string GetHangedManImage(int incorrectGuessses)
            {
                return images[incorrectGuessses];
            }

        }

    }
}
