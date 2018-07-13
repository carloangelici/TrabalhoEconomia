using System;
using Xamarin.Forms;
using System.ComponentModel;  //INotifyPropertyChanged
using System.Runtime.CompilerServices; // CallerMemberName
using System.Collections.Generic; //contem EqualityComparer

namespace TrabalhoEconomiaOficial
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        //---------------------------------------Property Changed Event------------------------------------------------
        public event PropertyChangedEventHandler PropertyChanged;

        //public event PropertyChangedEventHandler TextChanged;
        //---------------------------------------Property Changed Methods-----------------------------------------------

        protected virtual void ChangeProperty([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetPropertyChanged<T>(ref T oldProperty, T newProperty, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(oldProperty, newProperty))
            {
                return false;
            }
            oldProperty = newProperty;
            ChangeProperty(propertyName);

            return true;
        }


        protected bool SetPropertyChangedEvenWhenEquals<T>(ref T oldProperty, T newProperty, [CallerMemberName] string propertyName = null)
        {
            oldProperty = newProperty;
            ChangeProperty(propertyName);
            return true;
        }


        //---------------------------------------------Other Methods----------------------------------------------------
        public bool IsStackSelected(StackLayout stack)
        {
            if (stack.Opacity < 0.9)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //---------------------------------------------Other Methods----------------------------------------------------
    }
}
