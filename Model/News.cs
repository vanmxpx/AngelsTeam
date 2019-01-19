using System;

namespace AngelsTeam.Model
{
    public class News
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Likes { get; set; }
        public int Dislikes {get;set;}
        public DateTime Date { get; set; }
        public string Body { get; set; }
        public string Attachment {get;set;}
    }
}