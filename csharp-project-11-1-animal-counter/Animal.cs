namespace csharp_project_11_1_animal_counter
{
    internal abstract class Animal : ICountable
    {
        int Count { get; set; }

        public int GetCount()
        {
            throw new NotImplementedException();
        }

        public string GetCountString()
        {
            throw new NotImplementedException();
        }

        public void IncrementCount()
        {
            throw new NotImplementedException();
        }

        public void ResetCount()
        {
            throw new NotImplementedException();
        }
    }
}
