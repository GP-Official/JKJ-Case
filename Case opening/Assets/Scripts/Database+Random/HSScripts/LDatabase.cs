using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class LDatabase : MonoBehaviour {
	public List<HSCards> lcards = new List<HSCards> ();

	void Start () {


		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Blingtron 3000"});
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Bolvar Fordragon"});
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Dr. Boom"});
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Flame Leviathan"});
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Foe Reaper 4000"});
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Gahzrilla"});
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Gazlowe"});
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Hemet Nesingwary"});
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Iron Juggernaut"});
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Mal Ganis"});
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Malorne"});
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Mekgineer Thermaplugg"});
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Mimirons Head"});
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Mogor the Ogre"});
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Neptulon"});
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Sneeds Old Shredder"});
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Toshley"});
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Trade Prince Gallywix"});
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Troggzor the Earthinator"});
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Vol jin"});
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Acidmaw" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Anubarak" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Aviana" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Confessor Paletress" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Dreadscale" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Eadric the Pure" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Eydis Darkbane" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Fjola Lightbane" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 1600, type = "Legendary", name = "Gormok the Impaler" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Chillmaw" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Icehowl" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Nexus Champion Saraad" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Justicar Trueheart" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Rhonin" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Skycapn Kragg" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "The Mistcaller" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "The Skeleton Knight" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Varian Wrynn" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Wilfred Fizzlebang" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Anomalus" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Deathwing, Dragonlord" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Fandral Staghelm" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Hallazeal the Ascended" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Herald Volazj" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Hogger, Doom of Elwynn" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Cho gall" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Malkorok" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Mukla,  Tyrant of the Vale" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Nat, the Darkfisher" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "NZoth, the Corruptor" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Princess Huhuran" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Ragnaros, Lightlord" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Soggoth the Slitherer" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Shifter Zerus" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "The Boogeymonster" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Twin Emperor Veklor" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Xaril, Poisoned Mind" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Y Shaarj, Rage Unbound" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Yogg-Saron, Hopes End" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Alakir the Windlord" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Alexstrasza" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Archmage Antonidas" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Baron Geddon" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Bloodmage Thalnos" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Cairne Bloodhoof" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Captain Greenskin" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Cenarius" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Deathwing" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Edwin VanCleef" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Grommash Hellscream" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Gruul" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Harrison Jones" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Hogger" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Illidan Stormrage" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "King Krush" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "King Mukla" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Leeroy Jenkins" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Lord Jaraxxus" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Lorewalker Cho" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Malygos" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Millhouse Manastorm" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Nat Pagle" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Nozdormu" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Onyxia" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Prophet Velen" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Ragnaros the Firelord" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Sylvanas Windrunner" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "The Beast" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "The Black Knight" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Tinkmaster Overspark" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Tirion Fordring" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Ysera" });
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Auctionmaster Beardo"});
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Aya Blackpaw"});
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Don HanCho"});
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Finja, the Flying Star"});
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Genzo, the Shark"});
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Hobart Grapplehammer"});
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Inkmaster Solia"});
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Kazakus"});
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Knuckles"});
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Krul the Unshackled"});
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Kun the Forgotten King"});
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Madam Goya"});
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Mayor Noggenfogger"});
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Patches the Pirate"});
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Raza the Chained"});
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Sergeant Sally"});
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Shaku, the Collector"});
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "White Eyes"});
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Wickerflame Burnbristle"});
		lcards.Add(new HSCards() { prize = 1600, sellprize = 400, type = "Legendary", name = "Wrathion"});

	




	}
}
