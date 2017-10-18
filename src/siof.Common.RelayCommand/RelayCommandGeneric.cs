using System;

namespace siof.Common
{
    public class RelayCommand: RelayCommand<object>
    {
        public RelayCommand(Action<object> execute) :
            base(execute)
        {
        }

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute) :
            base(execute, canExecute)
        {
        }
    }
}
