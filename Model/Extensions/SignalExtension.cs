namespace AngelsTeam.Model
{
    public static class SignalExtension
    {
        public static void Clone(this Signal signal, Signal newSignal)
        {
            signal.Attachment = newSignal.Attachment;
            signal.Coin = newSignal.Coin;
            signal.Date = newSignal.Date;
            signal.Body = newSignal.Body;
            signal.Free = newSignal.Free;
            signal.SignalLevel = newSignal.SignalLevel;
            signal.SignalLevelId = newSignal.SignalLevelId;
            signal.Target = newSignal.Target;
            signal.TargetId = newSignal.TargetId;
            signal.Title = newSignal.Title;            
        }
    }
}