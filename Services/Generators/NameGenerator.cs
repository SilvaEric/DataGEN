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

        public NameGenerator(IGenderGenerator generator)
        {
            _genderGenerator = generator;
        }
        public string Generate(EGender? gender, ERegion region)
        {
            var names = new NamesDataBase().DictionaryRegionsNames[region][gender ?? _genderGenerator.Generate()];
            var secondNames = new SecondNamesDataBase().DictionaryRegionsSecondNames[region];

            var random = new Random();
            var namesIndex = random.Next(names.Count);
            var secondNamesIndex = random.Next(secondNames.Count);

            return $"{names[namesIndex]} {secondNames[secondNamesIndex]}";  
        }
    }
}
