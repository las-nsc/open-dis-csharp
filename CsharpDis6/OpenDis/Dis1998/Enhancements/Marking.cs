using System.Linq;
using System.Text;

namespace OpenDis.Dis1998
{
    public partial class Marking
    {
        // Additional property to make using Characters easier and safer

        public string CharacterString
        {
            get { return Encoding.ASCII.GetString(Characters).Replace("\0", ""); }
            set { Characters = Encoding.ASCII.GetBytes(value).Concat(Enumerable.Repeat((byte)0, 11)).Take(11).ToArray(); } // Ensures array is always 11 bytes long
        }

        public override string ToString()
        {
            return CharacterString;
        }
    }
}
