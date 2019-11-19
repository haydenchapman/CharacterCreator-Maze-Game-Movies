using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
//
namespace CharacterCreator
{
    public class Character : IValidatableObject 
    {
        public int Id { get; set; }
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

        private string _name = "";
        private string _description = "";
        public string _profession = "";
        private string _race = "";
        public int Strength { get; set; } = 100;

        public int Intelligence { get; set; } = 100;

        public int Agility { get; set; } = 100;

        public int Constitution { get; set; } = 100;

        public int Charisma { get; set; } = 100;

        public override string ToString () => $"{Name} ({Profession})";

        public IEnumerable<ValidationResult> Validate (ValidationContext validationContext )
        {
            if (String.IsNullOrEmpty (Name))
                yield return new ValidationResult ("Name is required");

            if (String.IsNullOrEmpty (Profession))
                yield return new ValidationResult ("Profession is required");

            if (String.IsNullOrEmpty (Race))
                yield return new ValidationResult ("Race is required");

            if (Strength <= 0 || Strength > 100)
                yield return new ValidationResult ("Attribute must be between 0 to 100");

            if (Intelligence <= 0 || Intelligence > 100)
                yield return new ValidationResult ("Attribute must be between 0 to 100");

            if (Agility <= 0 || Agility > 100)
                yield return new ValidationResult ("Attribute must be between 0 to 100");

            if (Constitution <= 0 || Constitution > 100)
                yield return new ValidationResult ("Attribute must be between 0 to 100");

            if (Charisma <= 0 || Charisma > 100)
                yield return new ValidationResult ("Attribute must be between 0 to 100");

        }

    }

}
