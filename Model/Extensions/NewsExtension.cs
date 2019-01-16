namespace AngelsTeam.Model
{
    public static class NewsExtension
    {
        public static void Clone(this News news, News newNews)
        {
            news.Date = newNews.Date;
            news.Text = newNews.Text;
            news.Title = newNews.Title;            
        }
    }
}