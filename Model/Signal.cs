using System;

namespace AngelsTeam.Model
{
    public class Signal
    {
        public int Id {get;set;}
        public string Title {get;set;}
        public DateTime Date {get;set;}
        public string Text {get;set;}
        public bool IsFree{get;set;}
        public string Risk {get;set;}
        public string Duration {get;set;} //days
        public string Coin {get;set;}
        public string Buy {get;set;}
        public string Sell {get;set;}
        public string TPs {get;set;}
        
    }
}