using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class ViewModelBase
    {
        [AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
        public class CallerMemberNameAttribute : Attribute
        {

        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void UpdateProper<T>(ref T properValue, T newValue, [CallerMemberName] string properName = "")
        {
            if (object.Equals(properValue, newValue))
                return;

            properValue = newValue;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(properName));
        }
    }
}
