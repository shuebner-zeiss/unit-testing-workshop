using System;
using System.Collections.Generic;
using System.Text;

namespace Mocking2Demo._02
{
    public interface INotifier
    {
        event EventHandler<string> SomeEvent;
    }
}
