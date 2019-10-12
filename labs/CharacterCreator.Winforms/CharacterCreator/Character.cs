using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Character
    {
        public string Name
        {
            get { return _name ?? ""; }
            set { _name = value; }

        }

        public string Profession
        {
            get { return _profession ?? ""; }
            set { _profession = value; }
        }

        public string Race
        {
            get { return _race ?? ""; }
            set { _race = value; }
        }

        public string Description
        {
            get { return _description ?? ""; }
            set { _description = value; }
        }

        public string Validate ()
        {

            if (String.IsNullOrEmpty (Name))
                return "Name is required";
 
            if (String.IsNullOrEmpty (Profession))
                return "Rating is required";

            if (String.IsNullOrEmpty (Race))
                return "Rating is required";

            if (Strength < 0)
            {
                return "Strength must be between 0 to 100";
            } else if (Strength > 100)
            {
                return "Strength must be between 0 to 100";
            }

            if (Intelligence < 0)
            {
                return "Strength must be between 0 to 100";
            } else if (Intelligence > 100)
            {
                return "Strength must be between 0 to 100";
            }

            if (Agility < 0)
            {
                return "Strength must be between 0 to 100";
            } else if (Agility > 100)
            {
                return "Strength must be between 0 to 100";
            }

            if (Constitution < 0)
            {
                return "Strength must be between 0 to 100";
            } else if (Constitution > 100)
            {
                return "Strength must be between 0 to 100";
            }

            if (Charisma < 0)
            {
                return "Strength must be between 0 to 100";
            } else if (Charisma > 100)
            {
                return "Strength must be between 0 to 100";
            }

            return "";
        }

        private string _name = "";
        private string _description = "";
        public string _profession = "";
        private string _race = "";
        public int Strength { get; set; } = 100;

        public int Intelligence { get; set; } = 100;

        public int Agility { get; set; } = 100;

        public int Constitution { get; set; } = 100;

        public int Charisma { get; set; } = 100;

    }
}
