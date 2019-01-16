using System;
using System.Diagnostics.Tracing;

namespace AngelsTeam.Tools
{
    public sealed class Diagnostics: EventListener
    {
        // Вызывается в момент создания EventSource.
        protected override void OnEventSourceCreated(EventSource eventSource)
        {
            // Смотрим за EventSource для .NET runtime и подключаем весь список событий.
            if (eventSource.Name.Equals("Microsoft-Windows-DotNETRuntime"))
            {
                EnableEvents(eventSource, EventLevel.Verbose, (EventKeywords) (-1));
            }
        }

        // Вызывается в момент регистрации события.
        protected override void OnEventWritten(EventWrittenEventArgs eventData)
        {
            // Распечатываем содержимое события в консоль.
            Console.WriteLine($"ThreadID = {eventData.OSThreadId} ID = {eventData.EventId} Name = {eventData.EventName}");
            for (int i = 0; i < eventData.Payload.Count; i++)
            {
                string payloadString = eventData.Payload[i] != null ? eventData.Payload[i].ToString() : string.Empty;
                Console.WriteLine($"\tName = \"{eventData.PayloadNames[i]}\" Value = \"{payloadString}\"");
            }
            Console.WriteLine("\n");
        }
    }
}