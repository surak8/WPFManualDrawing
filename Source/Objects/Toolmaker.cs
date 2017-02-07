using System.Collections.Generic;
using System.ComponentModel;

namespace NSTest {
    public class Toolmaker {

        public List<Toolmaker> toolMakers() {
            List<Toolmaker> ret = new List<Toolmaker>();

            ret.Add(new Toolmaker { clockNum = "31097", badgeNum = "4484314", firstName = "Jeffrey", lastName = "Barstis" });
            ret.Add(new Toolmaker { clockNum = "30430", badgeNum = "4478688", firstName = "Ricardo", lastName = "Colan" });
            ret.Add(new Toolmaker { clockNum = "32138", badgeNum = "4484374", firstName = "Pierre", lastName = "Lemieux" });
            ret.Add(new Toolmaker { clockNum = "30490", badgeNum = "4482804", firstName = "Michael", lastName = "Levesque" });
            ret.Add(new Toolmaker { clockNum = "32983", badgeNum = "4484282", firstName = "Christopher", lastName = "Regan" });
            ret.Add(new Toolmaker { clockNum = "32190", badgeNum = "4484186", firstName = "Antonio", lastName = "Di Rubba" });
            ret.Add(new Toolmaker { clockNum = "31783", badgeNum = "4484939", firstName = "Peter", lastName = "Lacross" });
            return ret;
        }
        [DisplayName("test")]
        public string clockNum { get;   set; }
        public string badgeNum { get;   set; }
        public string firstName { get;   set; }
        public string lastName { get;   set; }

        public string fullName {  get { return lastName + ", " + firstName; } }
    }
}