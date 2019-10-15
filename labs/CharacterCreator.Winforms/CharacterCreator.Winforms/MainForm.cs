using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator.Winforms
{
    public partial class MainForm : Form
    {
        public MainForm ()
        {
            InitializeComponent ();
        }

        private void MainForm_Load ( object sender, EventArgs e )
        {

        }

        private void OnFileExit ( object sender, EventArgs e )
        {
            Close ();
        }

        private void OnCharacterNew ( object sender, EventArgs e )
        {
            var form = new CharacterForm ();
            if (form.ShowDialog (this) == DialogResult.OK)
            {
                AddCharacter (form.Character);
                UpdateUI ();
            }
        }

        private Character[] _characters = new Character[100];

        private void AddCharacter ( Character character )
        {
            for (var index = 0; index < _characters.Length; ++index)
            {
                if (_characters[index] == null)
                {
                    _characters[index] = character;
                    return;
                };
            };
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
                RemoveCharacter (character);
                AddCharacter (form.Character);
                UpdateUI ();
            }
        }

        private void RemoveCharacter ( Character character )
        {
            for (var index = 0; index < _characters.Length; ++index)
            {
                if (_characters[index] == character)
                {
                    _characters[index] = null;
                    return;
                };
            };
        }

        private void OnCharacterDelete ( object sender, EventArgs e )
        {
            {
                var character = GetSelectedCharacter ();
                if (character == null)
                    return;

                var msg = $"Are you sure you want to delete {character.Name}?";
                var result = MessageBox.Show (msg, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result != DialogResult.Yes)
                    return;

                RemoveCharacter (character);
                UpdateUI ();
            }
        }

        private Character[] GetCharacters ()
        {
            var count = 0;
            foreach (var character in _characters)
                if (character != null)
                    ++count;

            var index = 0;
            var characters = new Character[count];
            foreach (var character in _characters)
                if (character != null)
                    characters[index++] = character;

            return characters;
        }

        private Character GetSelectedCharacter ()
        {
            var item = _1stCharacters.SelectedItem;

            return item as Character;
        }

        private void UpdateUI ()
        {
            var characters = GetCharacters ();

            _1stCharacters.DataSource = characters;
        }

        private void OnAboutForm ( object sender, EventArgs e )
        {
            var form = new AboutForm ();
            form.ShowDialog (this);
        }
    }
}
