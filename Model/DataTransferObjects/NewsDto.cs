using System;

namespace AngelsTeam.Model
{
    public class NewsDto
    {
        public string title { get; set; }
        public int likes { get; set; }
        public int dislikes {get;set;}
        public DateTime date { get; set; }
        public string body { get; set; }
        public string attachment {get;set;}
    }
}