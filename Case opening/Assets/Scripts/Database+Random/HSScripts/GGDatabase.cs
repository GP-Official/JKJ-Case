﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class GGDatabase : MonoBehaviour {
	public List<HSCards> ggcards = new List<HSCards> ();

	void Start () {
		#region ggcards
		ggcards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Ancestors Call"});
		ggcards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Anima Golem"});
		ggcards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Annoy-o-Tron"});
		ggcards.Add(new HSCards() { prize = 40, sellprize = 5, type = "Common", name = "Anodized Robo Cub"});
		ggcards.Add(new HSCards() { prize = 40, sellprize = 5, type = "Common", name = "Antique Healbot"});
		ggcards.Add(new HSCards() { prize = 100, sellprize = 20, type = "Rare", name = "Arcane Nullifier X-21"});
		ggcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Blingtron 3000"});
		ggcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Bolvar Fordragon"});
		ggcards.Add(new HSCards() { prize = 100, sellprize = 20, type = "Rare", name = "Bomb Lobber"});
		ggcards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Bouncing Blade"});
		ggcards.Add(new HSCards() { prize = 40, sellprize = 5, type = "Common", name = "Burly Rockjaw Trogg"});
		ggcards.Add(new HSCards() { prize = 100, sellprize = 20, type = "Rare", name = "Call Pet"});
		ggcards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Clockwork Giant"});
		ggcards.Add(new HSCards() { prize = 40, sellprize = 5, type = "Common", name = "Clockwork Gnome"});
		ggcards.Add(new HSCards() { prize = 100, sellprize = 20, type = "Rare", name = "Cobalt Guardian"});
		ggcards.Add(new HSCards() { prize = 40, sellprize = 5, type = "Common", name = "Cobra Shot"});
		ggcards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Coghammer"});
		ggcards.Add(new HSCards() { prize = 40, sellprize = 5, type = "Common", name = "Cogmaster"});
		ggcards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Cogmasters Wrench"});
		ggcards.Add(new HSCards() { prize = 40, sellprize = 5, type = "Common", name = "Crackle"});
		ggcards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Crush"});
		ggcards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Dark Wispers"});
		ggcards.Add(new HSCards() { prize = 40, sellprize = 5, type = "Common", name = "Darkbomb"});
		ggcards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Demonheart"});
		ggcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Dr. Boom"});
		ggcards.Add(new HSCards() { prize = 40, sellprize = 5, type = "Common", name = "Druid of the Fang"});
		ggcards.Add(new HSCards() { prize = 100, sellprize = 20, type = "Rare", name = "Dunemaul Shaman"});
		ggcards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Echo of Medivh"});
		ggcards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Enhance-o Mechano"});
		ggcards.Add(new HSCards() { prize = 40, sellprize = 5, type = "Common", name = "Explosive Sheep"});
		ggcards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Feign Death"});
		ggcards.Add(new HSCards() { prize = 100, sellprize = 20, type = "Rare", name = "Fel Cannom"});
		ggcards.Add(new HSCards() { prize = 100, sellprize = 20, type = "Rare", name = "Fel Reaver"});
		ggcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Flame Leviathan"});
		ggcards.Add(new HSCards() { prize = 40, sellprize = 5, type = "Common", name = "Flamecannon"});
		ggcards.Add(new HSCards() { prize = 40, sellprize = 5, type = "Common", name = "Floating Watcher"});
		ggcards.Add(new HSCards() { prize = 40, sellprize = 5, type = "Common", name = "Flying Machine"});
		ggcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Foe Reaper 4000"});
		ggcards.Add(new HSCards() { prize = 40, sellprize = 5, type = "Common", name = "Force-Tank MAX"});
		ggcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Gahzrilla"});
		ggcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Gazlowe"});
		ggcards.Add(new HSCards() { prize = 40, sellprize = 5, type = "Common", name = "Gilblin Stalker"});
		ggcards.Add(new HSCards() { prize = 40, sellprize = 5, type = "Common", name = "Glaivezooka"});
		ggcards.Add(new HSCards() { prize = 40, sellprize = 5, type = "Common", name = "Gnomeregan Infantry"});
		ggcards.Add(new HSCards() { prize = 100, sellprize = 20, type = "Rare", name = "Gnomish Experimenter"});
		ggcards.Add(new HSCards() { prize = 40, sellprize = 5, type = "Common", name = "Goblin Auto-Barber"});
		ggcards.Add(new HSCards() { prize = 100, sellprize = 20, type = "Rare", name = "Goblin Blastmage"});
		ggcards.Add(new HSCards() { prize = 100, sellprize = 20, type = "Rare", name = "Goblin Sapper"});
		ggcards.Add(new HSCards() { prize = 100, sellprize = 20, type = "Rare", name = "Grove Tender"});
		ggcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Hemet Nesingwary"});
		ggcards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Hobgoblin"});
		ggcards.Add(new HSCards() { prize = 100, sellprize = 20, type = "Rare", name = "Illuminator"});
		ggcards.Add(new HSCards() { prize = 100, sellprize = 20, type = "Rare", name = "Imp-losion"});
		ggcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Iron Juggernaut"});
		ggcards.Add(new HSCards() { prize = 100, sellprize = 20, type = "Rare", name = "Iron Sensei"});
		ggcards.Add(new HSCards() { prize = 100, sellprize = 20, type = "Rare", name = "Jeeves"});
		ggcards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Junkbot"});
		ggcards.Add(new HSCards() { prize = 100, sellprize = 20, type = "Rare", name = "Kezan Mystic"});
		ggcards.Add(new HSCards() { prize = 100, sellprize = 20, type = "Rare", name = "King of Beasts"});
		ggcards.Add(new HSCards() { prize = 100, sellprize = 20, type = "Rare", name = "Light of the Naaru"});
		ggcards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Lightbomb"});
		ggcards.Add(new HSCards() { prize = 100, sellprize = 20, type = "Rare", name = "Lil Exorcist"});
		ggcards.Add(new HSCards() { prize = 40, sellprize = 5, type = "Common", name = "Lost Tallstrider"});
		ggcards.Add(new HSCards() { prize = 100, sellprize = 20, type = "Rare", name = "Madder Bomber"});
		ggcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Mal Ganis"});
		ggcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Malorne"});
		ggcards.Add(new HSCards() { prize = 40, sellprize = 5, type = "Common", name = "Mechanical Yeti"});
		ggcards.Add(new HSCards() { prize = 100, sellprize = 20, type = "Rare", name = "Mech-Bear-Cat"});
		ggcards.Add(new HSCards() { prize = 40, sellprize = 5, type = "Common", name = "Mechwarper"});
		ggcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Mekgineer Thermaplugg"});
		ggcards.Add(new HSCards() { prize = 100, sellprize = 20, type = "Rare", name = "Metaltooth Leaper"});
		ggcards.Add(new HSCards() { prize = 40, sellprize = 5, type = "Common", name = "Micro Machine"});
		ggcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Mimirons Head"});
		ggcards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Mini-Mage"});
		ggcards.Add(new HSCards() { prize = 100, sellprize = 20, type = "Rare", name = "Mistress of Pain"});
		ggcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Mogor the Ogre"});
		ggcards.Add(new HSCards() { prize = 100, sellprize = 20, type = "Rare", name = "Muster for Battle"});
		ggcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Neptulon"});
		ggcards.Add(new HSCards() { prize = 40, sellprize = 5, type = "Common", name = "Ogre Brute"});
		ggcards.Add(new HSCards() { prize = 100, sellprize = 20, type = "Rare", name = "Ogre Ninja"});
		ggcards.Add(new HSCards() { prize = 40, sellprize = 5, type = "Common", name = "Ogre Warmaul"});
		ggcards.Add(new HSCards() { prize = 100, sellprize = 20, type = "Rare", name = "One-eyed-Cheat"});
		ggcards.Add(new HSCards() { prize = 40, sellprize = 5, type = "Common", name = "Piloted Shredder"});
		ggcards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Piloted Sky Golem"});
		ggcards.Add(new HSCards() { prize = 100, sellprize = 20, type = "Rare", name = "Powermace"});
		ggcards.Add(new HSCards() { prize = 40, sellprize = 5, type = "Common", name = "Puddlestomper"});
		ggcards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Quartermaster"});
		ggcards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Recombobulator"});
		ggcards.Add(new HSCards() { prize = 100, sellprize = 20, type = "Rare", name = "Recycle"});
		ggcards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Sabotage"});
		ggcards.Add(new HSCards() { prize = 40, sellprize = 5, type = "Common", name = "Salty Dog"});
		ggcards.Add(new HSCards() { prize = 100, sellprize = 20, type = "Rare", name = "Scarlet Purifier"});
		ggcards.Add(new HSCards() { prize = 100, sellprize = 20, type = "Rare", name = "Screwjank Clunker"});
		ggcards.Add(new HSCards() { prize = 40, sellprize = 5, type = "Common", name = "Seal of Light"});
		ggcards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Shadowbomber"});
		ggcards.Add(new HSCards() { prize = 100, sellprize = 20, type = "Rare", name = "Shadowboxer"});
		ggcards.Add(new HSCards() { prize = 40, sellprize = 5, type = "Common", name = "Shielded Minibot"});
		ggcards.Add(new HSCards() { prize = 100, sellprize = 20, type = "Rare", name = "Shieldmaiden"});
		ggcards.Add(new HSCards() { prize = 40, sellprize = 5, type = "Common", name = "Ships Cannon"});
		ggcards.Add(new HSCards() { prize = 40, sellprize = 5, type = "Common", name = "Shrinkmeister"});
		ggcards.Add(new HSCards() { prize = 100, sellprize = 20, type = "Rare", name = "Siege Engine"});
		ggcards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Siltfin Spiritwalker"});
		ggcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Sneeds Old Shredder"});
		ggcards.Add(new HSCards() { prize = 40, sellprize = 5, type = "Common", name = "Snowchugger"});
		ggcards.Add(new HSCards() { prize = 100, sellprize = 20, type = "Rare", name = "Soot Spewer"});
		ggcards.Add(new HSCards() { prize = 40, sellprize = 5, type = "Common", name = "Spider Tank"});
		ggcards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Steamwheedle Sniper"});
		ggcards.Add(new HSCards() { prize = 40, sellprize = 5, type = "Common", name = "Stonesplinter Trogg"});
		ggcards.Add(new HSCards() { prize = 100, sellprize = 20, type = "Rare", name = "Target Dummy"});
		ggcards.Add(new HSCards() { prize = 40, sellprize = 5, type = "Common", name = "Tinkers Sharpsword Oil"});
		ggcards.Add(new HSCards() { prize = 40, sellprize = 5, type = "Common", name = "Tinkertown Technician"});
		ggcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Toshley"});
		ggcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Trade Prince Gallywix"});
		ggcards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Tree of Life"});
		ggcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Troggzor the Earthinator"});
		ggcards.Add(new HSCards() { prize = 100, sellprize = 20, type = "Rare", name = "Unstable Portal"});
		ggcards.Add(new HSCards() { prize = 100, sellprize = 20, type = "Rare", name = "Upgraded Repair Bot"});
		ggcards.Add(new HSCards() { prize = 40, sellprize = 5, type = "Common", name = "Velens Chosen"});
		ggcards.Add(new HSCards() { prize = 100, sellprize = 20, type = "Rare", name = "Vitality Totem"});
		ggcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Vol jin"});
		ggcards.Add(new HSCards() { prize = 40, sellprize = 5, type = "Common", name = "Warbot"});
		ggcards.Add(new HSCards() { prize = 400, sellprize = 100, type = "Epic", name = "Wee Spellstopper"});
		ggcards.Add(new HSCards() { prize = 40, sellprize = 5, type = "Common", name = "Whirling Zap-o-matic"});
		#endregion
	

	
	
	}
}
