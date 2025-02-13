namespace csharp_project_7_4_dice_roller_demo
{
    public class Die
    {
        public int Value { get; set; }

        public Die()
        {
            this.Value = 0;
        }

        public void Roll()
        {
            Random r = new Random();
            this.Value = r.Next(1, 7);
        }
    }
}
