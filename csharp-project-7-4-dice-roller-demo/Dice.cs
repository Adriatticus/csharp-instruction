using ConsoleLibrary;

namespace csharp_project_7_4_dice_roller_demo
{
    public class Dice
    {
        public Die Die1 { get; set; }
        public Die Die2 { get; set; }

        //public Dice()
        //{
        //    Die Die1 = new Die();
        //    Die Die2 = new Die();
        //}

        public Dice()
        {
            this.Die1 = new Die();
            this.Die2 = new Die();
        }

        public int Sum()
        {
            return this.Die1.Value + this.Die2.Value;
        }

        public void Roll()
        {
            this.Die1.Roll();
            this.Die2.Roll();
        }

        public string GetRollResults()
        {
            // changed requirement to return a string!
            string returnStr = ("\nDie 1: " + Die1.Value);
            returnStr += ("\nDie 2: " + Die2.Value);
            returnStr += "\nTotal: " + Sum() + "\n";
            if (Sum() == 2)
            {
                returnStr += "Snake Eyes!\n";
            }
            else if (Sum() == 12)
            {
                returnStr += "Box Cars!\n";
            }
            else if (Sum() == 7)
            {
                returnStr += "Craps!\n";
            }
            return returnStr;

        }
    }
}
