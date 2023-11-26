using System.Data;

namespace _02.Articles
{

    public class Article
    {
        public Article(string newTitle, string newContent, string newAuthor) 
        {
           this.Content = newContent;
           this.Author = newAuthor;
           this.Title = newTitle;
        }

        public void Edit(string newContent)
        {
            this.Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            this.Title = newTitle;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
    }
    public class Articles
    {
        static void Main(string[] args)
        {
            string[] articleInfo = Console.ReadLine().Split(", ");
            string title = articleInfo[0];
            string content = articleInfo[1];
            string author = articleInfo[2];

            Article article = new(title, content, author);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(": ");
                string action = command[0];
                string parameter = command[1];

                switch (action)
                {
                    case "Edit":
                        article.Edit(parameter);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(parameter);
                        break;
                    case "Rename":
                        article.Rename(parameter);
                        break;
                }
            }

            Console.WriteLine(article);
        }
    }
}