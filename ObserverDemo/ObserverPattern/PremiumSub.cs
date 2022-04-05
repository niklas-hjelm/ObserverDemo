using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverDemo.ObserverPattern.Interfaces;

namespace ObserverDemo.ObserverPattern
{
    public class PremiumSub : IObserver
    {
        public void Update(string title)
        {
            throw new NotImplementedException();
        }
    }
}
