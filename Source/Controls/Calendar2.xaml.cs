using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;

namespace NSTest {
    /// <summary>
    /// Interaction logic for Calendar2.xaml
    /// </summary>
    public partial class Calendar2 : UserControl, INotifyPropertyChanged {

        public Calendar2() {
            InitializeComponent();
            this.month = DateTime.Now.Month;
            this.year = DateTime.Now.Year;
            this.DataContext = this;
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

        void decreaseMonth(object sender, RoutedEventArgs e) {
            if (month - 1 < 0) {
                month = 11;
                --year;
            } else
                month--;
        }

        void increaseMonth(object sender, RoutedEventArgs e) {
            if (month + 1 >= 12) {
                month = 0;
                year++;
            } else
                month++;
        }


        /// <summary>backing-store for property month of type <b>int</b>.</summary>
        /// <seealso name="month"/>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        int _month;

        /// <summary>property month.</summary>
        /// <seealso name="_month"/>
        public int month {
            get { return _month; }
            set {
                _month = value;
                firePropertyChanged(MethodBase.GetCurrentMethod());
                monthName = monthNames[month];
            }
        }
        string[] monthNames = {
            "JAN","FEB","MAR","APR",
            "MAY","JUN","JUL","AUG",
            "SEP","OCT","NOV","DEC"
        };



        /// <summary>backing-store for property year of type <b>int</b>.</summary>
        /// <seealso name="year"/>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        int _year;

        /// <summary>property year.</summary>
        /// <seealso name="_year"/>
        public int year {
            get { return _year; }
            set { _year = value; firePropertyChanged(MethodBase.GetCurrentMethod()); }
        }




        /// <summary>backing-store for property monthName of type <b>string</b>.</summary>
        /// <seealso name="monthName"/>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        string _monthName;

        /// <summary>property monthName.</summary>
        /// <seealso name="_monthName"/>
        public string monthName {
            get { return _monthName; }
            set { _monthName = value; firePropertyChanged(MethodBase.GetCurrentMethod()); }
        }

          void Button_Click(object sender, RoutedEventArgs e) {

        }

        private void decreaseYear(object sender, RoutedEventArgs e) {

        }
    }
}