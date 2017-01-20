using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class UltraPremiumDatabase : MonoBehaviour {
	public List<CSGOSkins> up = new List<CSGOSkins>();

	void Start () {
	
		up.Add(new CSGOSkins() { prize = 217.92f, type = "Pink",condition ="Minimal Wear",stattrak = "",firstname = "M4A1-S",secondname = "Knight"});
		up.Add(new CSGOSkins() { prize = 222.97f, type = "Pink",condition ="Factory New",stattrak = "",firstname = "M4A1-S",secondname = "Knight"});
		up.Add(new CSGOSkins() { prize = 700.52f, type = "Pink",condition ="Minimal Wear",stattrak = "Souvenir", firstname = "M4A1-S",secondname = "Knight"});
		up.Add(new CSGOSkins() { prize = 900.21f, type = "Pink",condition ="Factory New",stattrak = "Souvenir", firstname = "M4A1-S",secondname = "Knight"});
		up.Add(new CSGOSkins() { prize = 429.00f, type = "Red",condition ="Battle-Scared",stattrak = "",firstname = "AWP",secondname = "Dragon Lore"});
		up.Add(new CSGOSkins() { prize = 489.00f, type = "Red",condition ="Well-Worn",stattrak = "",firstname = "AWP",secondname = "Dragon Lore"});
		up.Add(new CSGOSkins() { prize = 600.00f, type = "Red",condition ="Field-Tested",stattrak = "", firstname = "AWP",secondname = "Dragon Lore"});
		up.Add(new CSGOSkins() { prize = 892.00f, type = "Red",condition ="Minimal Wear",stattrak = "",firstname = "AWP",secondname = "Dragon Lore"});
		up.Add(new CSGOSkins() { prize = 1170.00f, type = "Red",condition ="Factory New",stattrak = "",firstname = "AWP",secondname = "Dragon Lore"});
		up.Add(new CSGOSkins() { prize = 1500.00f, type = "Red",condition ="Battle-Scared",stattrak = "Souvenir", firstname = "AWP",secondname = "Dragon Lore"});
		up.Add(new CSGOSkins() { prize = 2500.00f, type = "Red",condition ="Well-Worn",stattrak = "Souvenir", firstname = "AWP",secondname = "Dragon Lore"});
		up.Add(new CSGOSkins() { prize = 5000.00f, type = "Red",condition ="Field-Tested",stattrak = "Souvenir", firstname = "AWP",secondname = "Dragon Lore"});
		up.Add(new CSGOSkins() { prize = 10000.00f, type = "Red",condition ="Minimal Wear",stattrak = "Souvenir", firstname = "AWP",secondname = "Dragon Lore"});
		up.Add(new CSGOSkins() { prize = 15000.00f, type = "Red",condition ="Factory New",stattrak = "Souvenir", firstname = "AWP",secondname = "Dragon Lore"});
		up.Add(new CSGOSkins() { prize = 310.47f, type = "Red",condition ="Battle-Scared",stattrak = "",firstname = "AWP",secondname = "Medusa"});
		up.Add(new CSGOSkins() { prize = 309.57f, type = "Red",condition ="Well-Worn",stattrak = "",firstname = "AWP",secondname = "Medusa"});
		up.Add(new CSGOSkins() { prize = 260.07f, type = "Red",condition ="Field-Tested",stattrak = "", firstname = "AWP",secondname = "Medusa"});
		up.Add(new CSGOSkins() { prize = 416.41f, type = "Red",condition ="Minimal Wear",stattrak = "",firstname = "AWP",secondname = "Medusa"});
		up.Add(new CSGOSkins() { prize = 840.72f, type = "Red",condition ="Factory New",stattrak = "",firstname = "AWP",secondname = "Medusa"});
		up.Add(new CSGOSkins() { prize = 86.24f, type = "Red",condition ="Battle-Scared",stattrak = "",firstname = "AK-47",secondname = "Fire Serpent"});
		up.Add(new CSGOSkins() { prize = 129.24f, type = "Red",condition ="Well-Worn",stattrak = "", firstname = "AK-47",secondname = "Fire Serpent"});
		up.Add(new CSGOSkins() { prize = 137.61f, type = "Red",condition ="Field-Tested",stattrak = "", firstname = "AK-47",secondname = "Fire Serpent"});
		up.Add(new CSGOSkins() { prize = 214.20f, type = "Red",condition ="Minimal Wear",stattrak = "",firstname = "AK-47",secondname = "Fire Serpent"});
		up.Add(new CSGOSkins() { prize = 348.0f, type = "Red",condition ="Factory New",stattrak = "",firstname = "AK-47",secondname = "Fire Serpent"});
		up.Add(new CSGOSkins() { prize = 413.12f, type = "Red",condition ="Battle-Scared",stattrak = "StatTrak", firstname = "AK-47",secondname = "Fire Serpent"});
		up.Add(new CSGOSkins() { prize = 535.36f, type = "Red",condition ="Field-Tested",stattrak = "StatTrak", firstname = "AK-47",secondname = "Fire Serpent"});
		up.Add(new CSGOSkins() { prize = 1260.0f, type = "Red",condition ="Minimal Wear",stattrak = "StatTrak", firstname = "AK-47",secondname = "Fire Serpent"});
		up.Add(new CSGOSkins() { prize = 107, type = "Rare",condition ="Field-Tested",stattrak = "",firstname = "M9 Bayonet",secondname = "Crimson Web"});
		up.Add(new CSGOSkins() { prize = 5000, type = "Rare",condition ="Factory New",stattrak = "StatTrak",firstname = "M9 Bayonet",secondname = "Crimson Web"});
		up.Add(new CSGOSkins() { prize = 1211, type = "Rare",condition ="Factory New",stattrak = "",firstname = "Karambit",secondname = "Lore"});
		up.Add(new CSGOSkins() { prize = 413, type = "Rare",condition ="Field-Tested",stattrak = "StatTrak",firstname = "Karambit",secondname = "Lore"});
		up.Add(new CSGOSkins() { prize = 350.00f, type = "Red",condition ="Well-Worn",stattrak = "",firstname = "M4A4",secondname = "Howl"});
		up.Add(new CSGOSkins() { prize = 410.00f, type = "Red",condition ="Field-Tested",stattrak = "", firstname = "M4A4",secondname = "Howl"});
		up.Add(new CSGOSkins() { prize = 502.00f, type = "Red",condition ="Minimal Wear",stattrak = "",firstname = "M4A4",secondname = "Howl"});
		up.Add(new CSGOSkins() { prize = 664.00f, type = "Red",condition ="Factory New",stattrak = "",firstname = "M4A4",secondname = "Howl"});
		up.Add(new CSGOSkins() { prize = 969.00f, type = "Red",condition ="Well-Worn",stattrak = "Souvenir", firstname = "M4A4",secondname = "Howl"});
		up.Add(new CSGOSkins() { prize = 806.00f, type = "Red",condition ="Field-Tested",stattrak = "Souvenir", firstname = "M4A4",secondname = "Howl"});
		up.Add(new CSGOSkins() { prize = 1234.00f, type = "Red",condition ="Minimal Wear",stattrak = "Souvenir", firstname = "M4A4",secondname = "Howl"});
		up.Add(new CSGOSkins() { prize = 1613.00f, type = "Red",condition ="Factory New",stattrak = "Souvenir", firstname = "M4A4",secondname = "Howl"});
	
	}
}
