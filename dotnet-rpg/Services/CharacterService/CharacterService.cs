using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Services.CharacterService
{
    public class CharacterService
    {
        List<Character> GetAllCharacters();
        CharacterService GetCharacterById(int id);
        List<Character> AddCharacter(CharacterService newCharacter);
    }
}