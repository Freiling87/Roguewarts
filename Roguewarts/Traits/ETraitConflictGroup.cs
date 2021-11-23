﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguewarts.Traits
{
	public enum ETraitConflictGroup
	{
		StrikerTraits,
		LimitDrugs,
		LimitFood,
		LimitWeapons, // TODO conflict vTrait.LimitWeapons
		ExperienceRate, // TODO conflict vTrait.ExperienceRate
		Luck,
		MagicCasting,
		VisionRange,
		Charisma,
		PoliceStanding,

		Myopic_Ballistician,
		Myopic_Sniper,

		AfraidOfLoudNoises_DrawNoBlood,

		SmoothBrained_VeryHardOnYourself,

		Archmage_FocusedCasting,
		Archmage_MagicTraining,
		Archmage_ManaBattery,
		Archmage_WildCasting,

		BootLicker_Unpleasant,
	}
}
