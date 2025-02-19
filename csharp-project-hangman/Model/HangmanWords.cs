using System.Reflection.Metadata;

namespace csharp_project_hangman.Model
{
    internal class HangmanWords
    {
        public string[] Words { get; set; }

        public HangmanWords ()
        {
            this.Words = new string[5] {"dead", "expired", "gone", "bucket", "kicked" };
        }
    }
}
