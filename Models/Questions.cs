namespace AspNetAndWebDevelopment_Task4_5.Models
{
    public class Questions
    {
        public readonly IEnumerable<Question> GetQuestions = new List<Question>
        {
            new("У якому методі виконується впровадження залежностей?", new List<Answer>
            {
                new("BuildWebHost"),
                new("Configure", true),
                new("Main"),
                new("ConfigureServices"),
            }),
            new("Чим є поле Transfer-Encoding?", new List<Answer>
            {
                new("Властивість об'єкта"),
                new("Властивість запиту"),
                new("Властивість відповіді"),
                new("Властивість повідомлення", true),
            }),
            new("Які методи необхідно використовувати в ConfigureServices для налаштування Identity?", new List<Answer>
            {
                new("AddIdentityCore<>"),
                new("AddAuthorization()"),
                new("AddIdentity<>", true),
                new("AddIdentityConfiguration<>"),
            }),
            new("У якому класі здійснюються основні налаштування Identity?", new List<Answer>
            {
                new("Startup.cs", true),
                new("ConfigureServices"),
                new("Configure"),
                new("Main.cs"),
            }),
            new("Як називається змінна середовища виконання?", new List<Answer>
            {
                new("DOTNETCORE_ENVIRONMENT"),
                new("ASPNETCORE_ENVIRONMENT"),
                new("ENVIRONMENT", true),
                new("ASPNET_ENVIRONMENT"),
            }),
            new("Модель це:", new List<Answer>
            {
                new("Форма даних"),
                new("Об'єкт даних (Data transfer object)", true),
                new("Тип даних"),
                new("html-вміст"),
            }),
            new("Яким чином можна скасувати мініфікацію в конфігураційному файлі?", new List<Answer>
            {
                new("minify: { enabled: true }", true),
                new("minify: { enabled: false }"),
                new("minify: { renameLocals: false }"),
                new("minify: { renameLocals: true }"),
            }),
            new("Як називається API за допомогою якого здійснюється налаштування доменних моделей CodeFirst?",
                new List<Answer>
                {
                    new("Fluent API", true),
                    new("CLR API"),
                    new("POCO API"),
                    new("T4 Template"),
                }),
            new("Який http метод використовується за замовчуванням для Action method?", new List<Answer>
            {
                new("HttpGet", true),
                new("HttpDelete"),
                new("HttpPost"),
                new("HttpPut"),
            }),
            new("Який тип аутентифікації зазвичай застосовують в Intranet?", new List<Answer>
            {
                new("Застосування сертифікатів SSL"),
                new("Звичайна аутентифікація"),
                new("Вбудована аутентифікація", true),
                new("Анонімна аутентифікація"),
            })
        };
    }
}