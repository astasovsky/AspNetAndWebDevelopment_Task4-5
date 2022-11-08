namespace AspNetAndWebDevelopment_Task4_5.Models
{
    public class Question
    {
        public string Title { get; }

        public List<Answer> Answers { get; }

        public Question(string title, List<Answer> answers)
        {
            Title = title;
            Answers = answers;
        }
    }
}