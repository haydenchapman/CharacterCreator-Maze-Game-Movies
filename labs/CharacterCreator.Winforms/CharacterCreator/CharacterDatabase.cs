using System.Collections.Generic;
using System.Linq;

namespace CharacterCreator
{
    public abstract class CharacterDatabase : ICharacterDatabase
        {
        protected abstract Character AddCore ( Character character );

        public Character Add ( Character character )
            {
                if (character == null)
                    return null;

                var results = ObjectValidator.TryValidateObject (character);
                if (results.Count () > 0)
                    return null;

                var existing = GetByNameCore (character.Name);
                if (existing != null)
                    return null;

                return AddCore (character);
            }

            protected abstract void RemoveCore ( int id );
            public void Remove ( int id )
            {
                RemoveCore (id);
            }

            public Character Get ( int id )
            {
                if (id <= 0)
                    return null;

                return GetCore (id);
            }

            protected abstract Character GetCore ( int id );

            public IEnumerable<Character> GetAll ()
            {
                return GetAllCore ();
            }

            protected abstract IEnumerable<Character> GetAllCore ();

            public void Update ( int id, Character newCharacter )
            {
                if (id <= 0)
                    return;
                if (newCharacter == null)
                    return;

                var results = ObjectValidator.TryValidateObject (newCharacter);
                if (results.Count () > 0)
                    return;

                var existing = GetByNameCore (newCharacter.Name);
                if (existing != null && existing.Id != id)
                    return;

                UpdateCore (id, newCharacter);
            }

            protected abstract Character UpdateCore ( int id, Character newCharacter );

            protected abstract Character GetByNameCore ( string name );

        }
}
