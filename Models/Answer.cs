namespace AspNetAndWebDevelopment_Task4_5.Models
{
    public class Answer
    {
        public string Title { get; }

        public bool IsRight { get; }

        public Answer(string title, bool isRight = false)
        {
            Title = title;
            IsRight = isRight;
        }
    }
}