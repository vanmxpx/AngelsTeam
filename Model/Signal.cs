using System;

namespace AngelsTeam.Model
{
    public class Signal
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public bool IsFree { get; set; }

        public string Coin { get; set; }
        public string Attachment { get; set; }

        public int SignalLevelId { get; set; }
        public SignalLevel SignalLevel { get; set; }

        public int TargetId { get; set; }
        public Target Target { get; set; }

    }
}