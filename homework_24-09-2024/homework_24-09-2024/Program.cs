using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_24_09_2024
{
    internal class Program
    {
        static void PrintAllEvents(List<Event> events)
        {
            foreach (var eventItem in events)
            {
                Console.WriteLine($"Id: {eventItem.id}, Title: {eventItem.Title}, Start: {eventItem.Start}");
            }
        }
        static int nextId = 1;
        static void AddEvent(string title, DateTime start, List<Event> events)
        {
            events.Add(new Event { id = nextId, Title = title, Start = start });
            nextId++;
        }
        static void UpdateEventTitle(int Id, string newTitle, List<Event> events)
        {
            Event e = events.Find(ev => ev.id == Id); 
            
            if (e != null)
            {
                e.Title = newTitle;
            }
            else
            {
                Console.WriteLine("not found");
            }
        }

        static void DeleteEvent(int Id, List<Event> events)
        {
            events.RemoveAll(e => e.id == Id);
        }
        static void Main(string[] args)
        {
            List<Event> events = new List<Event>();          
            AddEvent("Birthday", new DateTime(2024, 10, 10, 11, 30, 00), events);
            AddEvent("meeting", new DateTime(2024, 11, 15, 12, 00, 00), events);
            PrintAllEvents(events);
            AddEvent("lecture", new DateTime(2024,12,12,17,15,00), events);
            PrintAllEvents(events);
            UpdateEventTitle(2, "Urgent meeting", events);
            PrintAllEvents(events);

            // מחיקת אירוע
            DeleteEvent(1,events);
            PrintAllEvents(events);
            Console.ReadLine();

        }
    }
}
