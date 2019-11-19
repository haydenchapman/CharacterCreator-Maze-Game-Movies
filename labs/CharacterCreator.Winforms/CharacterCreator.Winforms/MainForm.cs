using System;
using System.Linq;
using System.Windows.Forms;

namespace CharacterCreator.Winforms
{
    public partial class MainForm : Form
    {
        public MainForm ()
        {
            InitializeComponent ();
        }

        protected override void OnLoad ( EventArgs e )
        {
            base.OnLoad (e);

            _characters = new MemoryCharacterDatabase ();
            var count = _characters.GetAll ().Count ();
            if (count == 0)

            UpdateUI ();
        }
        private void OnFileExit ( object sender, EventArgs e )
        {
            Close ();

        }

        private void OnHelpAbout ( object sender, EventArgs e )
        {
            var form = new AboutForm ();
            form.ShowDialog (this);
        }

        private void OnCharacterAdd ( object sender, EventArgs e )
        {
            var form = new CharacterForm ();

            if (form.ShowDialog (this) == DialogResult.OK)
            {
                _characters.Add (form.Character);
                UpdateUI ();
            };
        }

        private Character GetSelectedCharacter ()
        {
            var item = _1stCharacters.SelectedItem;

            return item as Character;
        }

        private void UpdateUI ()
        {
            var characters = _characters.GetAll ();

            _1stCharacters.DataSource = characters.ToArray ();
        }

        private void OnCharacterEdit ( object sender, EventArgs e )
        {
            var character = GetSelectedCharacter ();
            if (character == null)
                return;

            var form = new CharacterForm ();
            form.Character = character;

            if (form.ShowDialog (this) == DialogResult.OK)
            {
                _characters.Update (character.Id, form.Character);
                UpdateUI ();
            };
        }

        private void OnCharacterDelete ( object sender, EventArgs e )
        {
            var character = GetSelectedCharacter ();
            if (character == null)
                return;

            var msg = $"Are you sure you want to delete {character.Name}?";
            var result = MessageBox.Show (msg, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            _characters.Remove (character.Id);
            UpdateUI ();
        }

        private void MainForm_Load ( object sender, EventArgs e )
        {

            _characters = new MemoryCharacterDatabase ();
            var count = _characters.GetAll ().Count ();
            if (count == 0)
                _characters.GetAll ();

            UpdateUI ();
        }

        private ICharacterDatabase _characters;
    }
}
