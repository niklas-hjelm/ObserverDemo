using ObserverDemo.ObserverPattern.Interfaces;

namespace ObserverDemo.ObserverPattern
{
    public class Subscriber : IObserver
    {
        private string _name;
        
        public Subscriber(string name)
        {
            _name = name;
        }

        public void Update(string title)
        {
            Console.WriteLine($"There is a new blog for you {_name} named: {title}!");
        }
    }
}
