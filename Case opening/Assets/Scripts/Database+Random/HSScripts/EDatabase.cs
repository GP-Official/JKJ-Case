using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class EDatabase : MonoBehaviour {
	public List<HSCards> ecards = new List<HSCards> ();

	void Start () {
		#region ecards
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Ancient Harbinger" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Blade of CThun" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Blood of the Ancient One" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Blood Warriors" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Cabalists Tome" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "call of the wild" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Crazed Worshipper" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Cyclopian Horror" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Darkspeaker" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "DOOM!" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Embrace the Shadow" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Eternal Sentinel" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Faceless Shambler" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Forbidden Ancien" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Forbidden Flame" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Forbidden Healing" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Forbidden Shaping" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Giant Sand Worm" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Hammer of Twilight" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Lock and Load" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Renounce Darkness" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Scaled Nightmare" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Shadowcaster" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Tentacles for Arms" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Twilight Summoner" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Validated Doomsayer" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Vilefin Inquisitor" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Whisps of the Old Gods" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Arcane Blast" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Astral Communion" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Beneath the Grounds" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Captured Jormungar" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Confuse" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Crowd Favorite" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Dark Bargain" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Dreadsteed" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 400, type = "Epic", name = "Elemental Destruction" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 400, type = "Epic", name = "Enter the Coliseum" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Frost Giant" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Garrison Commander" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Grand Crusader" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Charged Hammer" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Kodorider" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Magnataur Alpha" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Master of Ceremonies" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Mulch" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Mysterious Challenger" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Poisoned Blade" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 20, type = "Epic", name = "Recruiter" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Sea Reaver" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Shadowfiend" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Sideshow Spelleater" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Stablemaster" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Twilight Guardian" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Ancestors Call"});
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Anima Golem"});
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Annoy-o-Tron"});
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Bouncing Blade"});
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Clockwork Giant"});
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Coghammer"});
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Cogmasters Wrench"});
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Crush"});
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Dark Wispers"});
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Demonheart"});
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Echo of Medivh"});
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Enhance-o Mechano"});
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Feign Death"});
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Hobgoblin"});
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Junkbot"});
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Mini-Mage"});
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Lightbomb"});
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Piloted Sky Golem"});
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Quartermaster"});
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Recombobulator"});
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Sabotage"});
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Shadowbomber"});
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Siltfin Spiritwalker"});
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Steamwheedle Sniper"});
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Tree of Life"});
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Wee Spellstopper"});
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Ancient of Lore" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Ancient of War" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Avenging Wrath" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Bane of Doom" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Bestial Wrath" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Big Game Hunter" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Brawl" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Cabal Shadow Priest" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Doomhammer" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Doomsayer" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Earth Elemental" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Fen Creeper" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Flame Imp" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Force of Nature" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Gladiators longbow" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Gorehowl" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Hungry Crab" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Ice Block" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Kidnapper" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Lay on Hands" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Mindgames" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 10, type = "Epic", name = "Molten Giant" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Mountain Giant" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Murloc Warleader" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Patient Assasin" });	
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Pit Lord" });		
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Preparation" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "PyroBlast" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Sea Giant" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Shadowform" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Shield Slam" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Snake Trap" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Southsea Captain" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Spellbender" });
		ecards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Twisting Nether" });
	
		#endregion 
	
	
	
	
	
	
	
	
	}

}
