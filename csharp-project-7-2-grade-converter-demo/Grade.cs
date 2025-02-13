namespace csharp_project_7_2_grade_converter_demo
{
    internal class Grade
    {
        public int Number { get; set; }

        public Grade()
        {
            this.Number = 0;
        }

        public Grade(int Number)
        {
            this.Number = Number;
        }

        public string GetLetter()
        {
            string letterGrade = "F";
            if (Number >= 88)
            {
                letterGrade = "A";
            }
            if (Number >= 80)
            {
                letterGrade = "B";
            }
            if (Number >= 68)
            {
                letterGrade = "C";
            }
            if (Number >= 60)
            {
                letterGrade = "D";
            }
            return letterGrade;
        }
        
        



    }
}
