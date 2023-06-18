using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Services.CharacterService
{
    public interface ICharacterService : ICharacterService
    {
        public List<Character> AddCharacter(CharacterService newCharacter)
        {
            throw new NotImplementedException();
        }

        public List<Character> GetAllCharacters()
        {
            throw new NotImplementedException();
        }

        public List<Character> GetCharacterById(int id)
        {
            throw new NotImplementedException();
        }


    }
}