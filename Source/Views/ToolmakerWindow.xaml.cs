using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Windows;

namespace NSTest {
    /// <summary>
    /// Interaction logic for ToolmakerWindow.xaml
    /// </summary>
    public partial class ToolmakerWindow : Window {

        ToolmakerWindowViewModel _vm;

        public ToolmakerWindow() {
            this.DataContext = _vm = new ToolmakerWindowViewModel();
            InitializeComponent();
        }
    }

    class ToolmakerWindowViewModel : INotifyPropertyChanged {
        public List<Toolmaker> toolmakers() {
            List<NSTest.Toolmaker> ret = new List<Toolmaker>();

            ret.Add(new Toolmaker { clockNum = "31097", badgeNum = "4484314", firstName = "Jeffrey", lastName = " Barstis" });
            ret.Add(new Toolmaker { clockNum = "30430", badgeNum = "4478688", firstName = " Ricardo", lastName = " Colan" });
            ret.Add(new Toolmaker { clockNum = "32138", badgeNum = "4484374", firstName = " Pierre", lastName = " Lemieux" });
            ret.Add(new Toolmaker { clockNum = "30490", badgeNum = "4482804", firstName = " Michael", lastName = " Levesque" });
            ret.Add(new Toolmaker { clockNum = "32983", badgeNum = "4484282", firstName = " Christopher", lastName = " Regan" });
            ret.Add(new Toolmaker { clockNum = "32190", badgeNum = "4484186", firstName = " Antonio", lastName = " Di Rubba" });
            ret.Add(new Toolmaker { clockNum = "31783", badgeNum = "4484939", firstName = " Peter", lastName = " Lacross" });
            return ret;
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