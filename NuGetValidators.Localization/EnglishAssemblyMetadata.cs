﻿
using Newtonsoft.Json.Linq;

namespace NuGetValidators.Localization
{
    internal class EnglishAssemblyMetadata
    {
        public string AssemblyPath { get; set; }

        public bool HasResources { get; set; }

        public int TranslatedAssemblyCount { get; set; }

        public JObject ToJson()
        {
            return new JObject
            {
                ["AssemblyPath"] = AssemblyPath,
                ["HasResources"] = HasResources,
                ["TranslatedAssemblyCount"] = TranslatedAssemblyCount
            };
        }
    }
}