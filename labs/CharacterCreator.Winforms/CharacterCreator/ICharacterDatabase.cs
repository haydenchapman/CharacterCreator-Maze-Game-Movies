using System.Collections.Generic;

namespace CharacterCreator
{
    public interface ICharacterDatabase
    {
        Character Add ( Character character );
        Character Get ( int id );

        IEnumerable<Character> GetAll ();
        void Remove ( int id );
        void Update ( int id, Character newCharacter );
    }
}
