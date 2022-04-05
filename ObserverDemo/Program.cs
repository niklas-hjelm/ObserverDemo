using ObserverDemo.ObserverPattern;
using ObserverDemo.ObserverPattern.Interfaces;

ISubject blog = new Blog();

IObserver niklas = new Subscriber("Niklas");
IObserver kalle = new Subscriber("Kalle");
IObserver pelle = new Subscriber("Pelle");

blog.Subscribe(niklas);
blog.Subscribe(kalle);
blog.Subscribe(pelle);

blog.Upload("Byhåla");

blog.UnSubscribe(kalle);

blog.Upload("Byhåla 2");