using System.Xml.Linq;

namespace FootballTeamLib
{
    public class FootballTeam

    {
        private string? _name;
        private string? _league;

        public int Id { get; set; }
        public string? Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(value);
                }
                if (value.Length < 2)
                {
                    throw new ArgumentOutOfRangeException(value);
                }
                _name = value;
            }
        }
        public string League {
            get
            {
                return _league;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(value);
                }
                if (value.Length < 2)
                {
                    throw new ArgumentOutOfRangeException(value);
                }
                _league = value;
            }
        }
    }
}
