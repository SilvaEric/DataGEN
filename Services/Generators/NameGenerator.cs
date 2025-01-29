using GeradorDadosAPI.ContextData;
using GeradorDadosAPI.Enums;
using GeradorDadosAPI.Models;
using GeradorDadosAPI.Services.Interfaces;
using System;

namespace GeradorDadosAPI.Services.Generators
{
    public class NameGenerator : INameGenerator
    {
        private readonly IGenderGenerator _genderGenerator;
        private readonly NamesDataBase _namesDataBase;
        private readonly SecondNamesDataBase _secondNamesDataBase;

        public NameGenerator(IGenderGenerator generator, NamesDataBase namesDataBase, SecondNamesDataBase secondNamesDataBase)
        {
            _genderGenerator = generator;
            _namesDataBase = namesDataBase;
            _secondNamesDataBase = secondNamesDataBase;
        }
        public string Generate(EGender? gender, ERegion region)
        {
            var names = _namesDataBase.DictionaryRegionsNames[region][gender ?? _genderGenerator.Generate()];
            var secondNames = _secondNamesDataBase.DictionaryRegionsSecondNames[region];

            var random = new Random();
            var namesIndex = random.Next(names.Count);
            var secondNamesIndex = random.Next(secondNames.Count);

            return $"{names[namesIndex]} {secondNames[secondNamesIndex]}";  
        }
    }
}
