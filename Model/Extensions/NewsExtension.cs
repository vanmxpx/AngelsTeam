namespace AngelsTeam.Model
{
    public static class NewsExtension
    {
        public static void Clone(this News news, News newNews)
        {
            news.Date = newNews.Date;
            news.Attachment = newNews.Attachment;
            news.Body = newNews.Body;
            news.Date = newNews.Date;
            news.Dislikes = newNews.Likes;            
            news.Title = newNews.Title;            
        }
    }
}