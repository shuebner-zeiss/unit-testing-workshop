using System;
using System.Collections.Generic;
using System.Text;

namespace Mocking2Demo._02
{
    public class Observer
    {
        private readonly INotifier notifier;

        public Observer(INotifier notifier)
        {
            this.notifier = notifier;
        }

        public void Observe()
        {
        }

        public string LastNotification { get; private set; }
    }
}
