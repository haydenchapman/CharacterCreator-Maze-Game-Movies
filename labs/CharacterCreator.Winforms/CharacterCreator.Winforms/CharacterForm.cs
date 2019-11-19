using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;
//
namespace CharacterCreator.Winforms
{
    public partial class CharacterForm : Form
    {
        public CharacterForm ()
        {
            InitializeComponent ();
        }

        public Character Character { get; set; }

        protected override void OnLoad ( EventArgs e )
        {
            base.OnLoad (e);

            if (Character != null)
            {
                _txtName.Text = Character.Name;
                _txtDescription.Text = Character.Description;
                cbProfession.Text = Character.Profession;
                cbRace.Text = Character.Race;
                _txtStrength.Text = Character.Strength.ToString ();
                _txtIntelligence.Text = Character.Intelligence.ToString ();
                _txtAgility.Text = Character.Agility.ToString ();
                _txtConstitution.Text = Character.Constitution.ToString ();
                _txtCharisma.Text = Character.Charisma.ToString ();
            }

            ValidateChildren ();
        }

        private int GetAsInt32 ( TextBox control )
        {
            if (Int32.TryParse (control.Text, out var result))
                return result;

            return 0;
        }

        private void OnSave ( object sender, EventArgs e )
        {
            if (!ValidateChildren ())
                return;

            var character = new Character () {
                Name = _txtName.Text,
                Description = _txtDescription.Text,
                Profession = cbProfession.Text,
                Race = cbRace.Text,
                Strength = GetAsInt32 (_txtStrength),
                Intelligence = GetAsInt32 (_txtIntelligence),
                Agility = GetAsInt32 (_txtAgility),
                Constitution = GetAsInt32 (_txtConstitution),
                Charisma = GetAsInt32 (_txtCharisma),
            };

            if (!Validate (character))
                return;

            Character = character;
            DialogResult = DialogResult.OK;
            Close ();
        }

        private bool Validate ( IValidatableObject character )
        {
            var results = ObjectValidator.TryValidateObject (character);
            if (results.Count () > 0)
            {
                foreach (var result in results)
                {
                    MessageBox.Show (this, result.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                };
                return false;
            };

            return true;
        }

        private void OnCancel ( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close ();
        }

        private void OnValidatingName ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            if (control.Text == "")
            {
                e.Cancel = true;
                _errors.SetError (control, "Name is required");
            } else
            {
                _errors.SetError (control, "");
            }
        }

        private void OnValidatingPro ( object sender, CancelEventArgs e )
        {
            var control = sender as ComboBox;

            if (control.SelectedIndex == -1)
            {
                e.Cancel = true;
                _errors.SetError (control, "Profession is required");
            } else
            {
                _errors.SetError (control, "");
            }
        }

        private void OnValidatingRace ( object sender, CancelEventArgs e )
        {
            var control = sender as ComboBox;

            if (control.SelectedIndex == -1)
            {
                e.Cancel = true;
                _errors.SetError (control, "Race is required");
            } else
            {
                _errors.SetError (control, "");
            }
        }

        private void OnValidatingStrength ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            var value = GetAsInt32 (control);
            if (value <= 0 || value > 100)
            {
                e.Cancel = true;
                _errors.SetError (control, "Strength must be between 1 to 100");
            } else
            {
                _errors.SetError (control, "");
            }
        }

        private void OnValidatingIntelligence ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            var value = GetAsInt32 (control);
            if (value <= 0 || value > 100)
            {
                e.Cancel = true;
                _errors.SetError (control, "Intelligence must be between 1 to 100");
            } else
            {
                _errors.SetError (control, "");
            }
        }

        private void OnValidatingAgility ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            var value = GetAsInt32 (control);
            if (value <= 0 || value > 100)
            {
                e.Cancel = true;
                _errors.SetError (control, "Agility must be between 1 to 100");
            } else
            {
                _errors.SetError (control, "");
            }
        }

        private void OnValidatingConstitution ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            var value = GetAsInt32 (control);
            if (value <= 0 || value > 100)
            {
                e.Cancel = true;
                _errors.SetError (control, "Constitution must be between 1 to 100");
            } else
            {
                _errors.SetError (control, "");
            }
        }

        private void OnValidatingCharisma ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            var value = GetAsInt32 (control);
            if (value <= 0 || value > 100)
            {
                e.Cancel = true;
                _errors.SetError (control, "Charisma must be between 1 to 100");
            } else
            {
                _errors.SetError (control, "");
            }
        }
    }
}