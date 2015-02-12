using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace fig.ViewModels
{
    public class BaseVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void Changed([CallerMemberName] string property = null)
        {
            if (PropertyChanged != null && property != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }

        public void Changed(params string[] properties)
        {
            if (properties != null)
                properties.ToList().ForEach(property => Changed(property));
        }

    }
}
