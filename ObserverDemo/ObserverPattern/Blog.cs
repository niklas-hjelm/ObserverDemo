using ObserverDemo.ObserverPattern.Interfaces;

namespace ObserverDemo.ObserverPattern
{
    public class Blog : ISubject
    {
        private ICollection<IObserver> Subscribers { get; set; } = new List<IObserver>();

        private string Title { get; set; }

        public void Subscribe(IObserver sub)
        {
            Subscribers.Add(sub);
        }

        public void UnSubscribe(IObserver sub)
        {
            Subscribers.Remove(sub);
        }

        public void Upload(string title)
        {
            Title = title;
            NotifySubs(title);
        }

        public void NotifySubs(string title)
        {
            foreach (var subscriber in Subscribers)
            {
                subscriber.Update(title);
            }
        }
    }
}
