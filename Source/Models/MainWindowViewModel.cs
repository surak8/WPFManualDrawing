//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;


namespace NSTest {

    public partial class MainWindowViewModel : INotifyPropertyChanged {
        public MainWindowViewModel() {
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void firePropertyChanged(string propertyName) {
            if ((this.PropertyChanged != null)) {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public void firePropertyChanged(MethodBase mb) {
            int n;

            if (((n = mb.Name.Length)
                        > 4)) {
                if (((string.Compare(mb.Name.Substring(0, 3), "get", true) == 0)
                            || (string.Compare(mb.Name.Substring(0, 3), "set", true) == 0))) {
                    firePropertyChanged(mb.Name.Substring(4));
                }
            }
        }
    }


    
}