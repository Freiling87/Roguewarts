using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace Roguewarts.Localization
{
	public class LocalizationManager
	{
		public static LocalizationManager Instance => _instance ?? (_instance = new LocalizationManager());
		private static LocalizationManager _instance;

		public L_Ability AbilityLocalization { get; }
		public L_Trait TraitsLocalization { get; }

		private LocalizationManager()
		{
			IDeserializer deserializer = new DeserializerBuilder().Build(); 

			AbilityLocalization = deserializer.Deserialize<L_Ability>(new StreamReader("BepInEx/config/Roguewarts_Abilities.yaml"));
			TraitsLocalization = deserializer.Deserialize<L_Trait>(new StreamReader("BepInEx/config/Roguewarts_Traits.yaml"));
		}
	}
} 