﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class WeaponDatabase : MonoBehaviour {
	public List<CSGOSkins> w1 = new List<CSGOSkins> ();

	void Start () {
		w1.Add(new CSGOSkins() { prize = 0.69f, type = "Blue",condition ="Minimal Wear",stattrak = "",firstname = "AUG",secondname = "Wings"});
		w1.Add(new CSGOSkins() { prize = 0.54f, type = "Blue",condition ="Factory New",stattrak = "",firstname = "AUG",secondname = "Wings"});
		w1.Add(new CSGOSkins() { prize = 1.70f, type = "Blue",condition ="Minimal Wear",stattrak = "StatTrak", firstname = "AUG",secondname = "Wings"});
		w1.Add(new CSGOSkins() { prize = 1.68f, type = "Blue",condition ="Factory New",stattrak = "StatTrak", firstname = "AUG",secondname = "Wings"});
		w1.Add(new CSGOSkins() { prize = 0.56f, type = "Blue",condition ="Battle-Scared",stattrak = "",firstname = "SG 553",secondname = "Ultraviolet"});
		w1.Add(new CSGOSkins() { prize = 0.64f, type = "Blue",condition ="Well-Worn",stattrak = "",firstname = "SG 553",secondname = "Ultraviolet"});
		w1.Add(new CSGOSkins() { prize = 0.52f, type = "Blue",condition ="Field-Tested",stattrak = "", firstname = "SG 553",secondname = "Ultraviolet"});
		w1.Add(new CSGOSkins() { prize = 0.74f, type = "Blue",condition ="Minimal Wear",stattrak = "",firstname = "SG 553",secondname = "Ultraviolet"});
		w1.Add(new CSGOSkins() { prize = 5.88f, type = "Blue",condition ="Factory New",stattrak = "",firstname = "SG 553",secondname = "Ultraviolet"});
		w1.Add(new CSGOSkins() { prize = 1.23f, type = "Blue",condition ="Battle-Scared",stattrak = "StatTrak", firstname = "SG 553",secondname = "Ultraviolet"});
		w1.Add(new CSGOSkins() { prize = 1.32f, type = "Blue",condition ="Well-Worn",stattrak = "StatTrak", firstname = "SG 553",secondname = "Ultraviolet"});
		w1.Add(new CSGOSkins() { prize = 1.20f, type = "Blue",condition ="Field-Tested",stattrak = "StatTrak", firstname = "SG 553",secondname = "Ultraviolet"});
		w1.Add(new CSGOSkins() { prize = 2.07f, type = "Blue",condition ="Minimal Wear",stattrak = "StatTrak", firstname = "SG 553",secondname = "Ultraviolet"});
		w1.Add(new CSGOSkins() { prize = 30.90f, type = "Blue",condition ="Factory New",stattrak = "StatTrak", firstname = "SG 553",secondname = "Ultraviolet"});
		w1.Add(new CSGOSkins() { prize = 0.66f, type = "Blue",condition ="Field-Tested",stattrak = "", firstname = "MP7",secondname = "Skulls"});
		w1.Add(new CSGOSkins() { prize = 0.64f, type = "Blue",condition ="Minimal Wear",stattrak = "",firstname = "MP7",secondname = "Skulls"});
		w1.Add(new CSGOSkins() { prize = 1.20f, type = "Blue",condition ="Field-Tested",stattrak = "StatTrak", firstname = "MP7",secondname = "Skulls"});
		w1.Add(new CSGOSkins() { prize = 1.89f, type = "Blue",condition ="Minimal Wear",stattrak = "StatTrak", firstname = "MP7",secondname = "Skulls"});
		w1.Add(new CSGOSkins() { prize = 6.42f, type = "Purple",condition ="Minimal Wear",stattrak = "",firstname = "Glock-18",secondname = "Dragon Tattoo"});
		w1.Add(new CSGOSkins() { prize = 4.96f, type = "Purple",condition ="Factory New",stattrak = "",firstname = "Glock-18",secondname = "Dragon Tattoo"});
		w1.Add(new CSGOSkins() { prize = 19.28f, type = "Purple",condition ="Minimal Wear",stattrak = "StatTrak", firstname = "Glock-18",secondname = "Dragon Tattoo"});
		w1.Add(new CSGOSkins() { prize = 19.80f, type = "Purple",condition ="Factory New",stattrak = "StatTrak", firstname = "Glock-18",secondname = "Dragon Tattoo"});
		w1.Add(new CSGOSkins() { prize = 5.22f, type = "Purple",condition ="Field-Tested",stattrak = "", firstname = "USP-S",secondname = "Dark Water"});
		w1.Add(new CSGOSkins() { prize = 5.04f, type = "Purple",condition ="Minimal Wear",stattrak = "",firstname = "USP-S",secondname = "Dark Water"});
		w1.Add(new CSGOSkins() { prize = 10.58f, type = "Purple",condition ="Field-Tested",stattrak = "StatTrak", firstname = "USP-S",secondname = "Dark Water"});
		w1.Add(new CSGOSkins() { prize = 15.03f, type = "Purple",condition ="Minimal Wear",stattrak = "StatTrak", firstname = "USP-S",secondname = "Dark Water"});
		w1.Add(new CSGOSkins() { prize = 4.31f, type = "Purple",condition ="Field-Tested",stattrak = "", firstname = "M4A1-S",secondname = "Dark Water"});
		w1.Add(new CSGOSkins() { prize = 4.65f, type = "Purple",condition ="Minimal Wear",stattrak = "",firstname = "M4A1-S",secondname = "Dark Water"});
		w1.Add(new CSGOSkins() { prize = 10.13f, type = "Purple",condition ="Field-Tested",stattrak = "StatTrak", firstname = "M4A1-S",secondname = "Dark Water"});
		w1.Add(new CSGOSkins() { prize = 14.74f, type = "Purple",condition ="Minimal Wear",stattrak = "StatTrak", firstname = "M4A1-S",secondname = "Dark Water"});
		w1.Add(new CSGOSkins() { prize = 14.42f, type = "Pink",condition ="Battle-Scared",stattrak = "",firstname = "AK-47",secondname = "Case Hardened"});
		w1.Add(new CSGOSkins() { prize = 15.40f, type = "Pink",condition ="Well-Worn",stattrak = "",firstname = "AK-47",secondname = "Case Hardened"});
		w1.Add(new CSGOSkins() { prize = 16.39f, type = "Pink",condition ="Field-Tested",stattrak = "", firstname = "AK-47",secondname = "Case Hardened"});
		w1.Add(new CSGOSkins() { prize = 20.32f, type = "Pink",condition ="Minimal Wear",stattrak = "",firstname = "AK-47",secondname = "Case Hardened"});
		w1.Add(new CSGOSkins() { prize = 33.47f, type = "Pink",condition ="Factory New",stattrak = "",firstname = "AK-47",secondname = "Case Hardened"});
		w1.Add(new CSGOSkins() { prize = 49.32f, type = "Pink",condition ="Battle-Scared",stattrak = "StatTrak", firstname = "AK-47",secondname = "Case Hardened"});
		w1.Add(new CSGOSkins() { prize = 58.78f, type = "Pink",condition ="Well-Worn",stattrak = "StatTrak", firstname = "AK-47",secondname = "Case Hardened"});
		w1.Add(new CSGOSkins() { prize = 65.24f, type = "Pink",condition ="Field-Tested",stattrak = "StatTrak", firstname = "AK-47",secondname = "Case Hardened"});
		w1.Add(new CSGOSkins() { prize = 89.69f, type = "Pink",condition ="Minimal Wear",stattrak = "StatTrak", firstname = "AK-47",secondname = "Case Hardened"});
		w1.Add(new CSGOSkins() { prize = 202.21f, type = "Pink",condition ="Factory New",stattrak = "StatTrak", firstname = "AK-47",secondname = "Case Hardened"});
		w1.Add(new CSGOSkins() { prize = 10.02f, type = "Pink",condition ="Minimal Wear",stattrak = "",firstname = "Desert Eagle",secondname = "Hypnotic"});
		w1.Add(new CSGOSkins() { prize = 6.47f, type = "Pink",condition ="Factory New",stattrak = "",firstname = "Desert Eagle",secondname = "Hypnotic"});
		w1.Add(new CSGOSkins() { prize = 39.96f, type = "Pink",condition ="Minimal Wear",stattrak = "StatTrak", firstname = "Desert Eagle",secondname = "Hypnotic"});
		w1.Add(new CSGOSkins() { prize = 21.42f, type = "Pink",condition ="Factory New",stattrak = "StatTrak", firstname = "Desert Eagle",secondname = "Hypnotic"});
		w1.Add(new CSGOSkins() { prize = 46.26f, type = "Red",condition ="Minimal Wear",stattrak = "",firstname = "AWP",secondname = "Lightning Strike"});
		w1.Add(new CSGOSkins() { prize = 41.02f, type = "Red",condition ="Factory New",stattrak = "",firstname = "AWP",secondname = "Lightning Strike"});
		w1.Add(new CSGOSkins() { prize = 505.00f, type = "Red",condition ="Minimal Wear",stattrak = "StatTrak", firstname = "AWP",secondname = "Lightning Strike"});
		w1.Add(new CSGOSkins() { prize = 158.63f, type = "Red",condition ="Factory New",stattrak = "StatTrak", firstname = "AWP",secondname = "Lightning Strike"});

		w1.Add(new CSGOSkins() { prize = 107, type = "Rare",condition ="Field-Tested",stattrak = "",firstname = "M9 Bayonet",secondname = "Crimson Web"});
		w1.Add(new CSGOSkins() { prize = 5000, type = "Rare",condition ="Factory New",stattrak = "StatTrak",firstname = "M9 Bayonet",secondname = "Crimson Web"});
		w1.Add(new CSGOSkins() { prize = 57, type = "Rare",condition ="Well-Worn",stattrak = "",firstname = "M9 Bayonet",secondname = "Forest DDPAT"});
		w1.Add(new CSGOSkins() { prize = 80, type = "Rare",condition ="Field-Tested",stattrak = "StatTrak",firstname = "M9 Bayonet",secondname = "Forest DDPAT"});
		w1.Add(new CSGOSkins() { prize = 137, type = "Rare",condition ="Field-Tested",stattrak = "",firstname = "M9 Bayonet",secondname = "Slaughter"});
		w1.Add(new CSGOSkins() { prize = 240, type = "Rare",condition ="Minimal Wear",stattrak = "StatTrak",firstname = "M9 Bayonet",secondname = "Slaughter"});
		w1.Add(new CSGOSkins() { prize = 91, type = "Rare",condition ="Field-Tested",stattrak = "",firstname = "Karambit",secondname = "Boreal Forest"});
		w1.Add(new CSGOSkins() { prize = 100, type = "Rare",condition ="Field-Tested",stattrak = "StatTrak",firstname = "Karambit",secondname = "Boreal Forest"});
		w1.Add(new CSGOSkins() { prize = 188, type = "Rare",condition ="Field-Tested",stattrak = "",firstname = "Karambit",secondname = "Crimson Web"});
		w1.Add(new CSGOSkins() { prize = 5000, type = "Rare",condition ="Factory New",stattrak = "StatTrak",firstname = "Karambit",secondname = "Crimson Web"});
		w1.Add(new CSGOSkins() { prize = 339, type = "Rare",condition ="Minimal Wear",stattrak = "",firstname = "Karambit",secondname = "Fade"});
		w1.Add(new CSGOSkins() { prize = 800, type = "Rare",condition ="Factory New",stattrak = "StatTrak",firstname = "Karambit",secondname = "Fade"});
		w1.Add(new CSGOSkins() { prize = 81, type = "Rare",condition ="Battle-Scared",stattrak = "",firstname = "Karambit",secondname = "Safari Mesh"});
		w1.Add(new CSGOSkins() { prize = 179, type = "Rare",condition ="Well-Worn",stattrak = "StatTrak",firstname = "Karambit",secondname = "Safari Mesh"});
		w1.Add(new CSGOSkins() { prize = 88, type = "Rare",condition ="Field-Tested",stattrak = "",firstname = "Karambit",secondname = "Scorched"});
		w1.Add(new CSGOSkins() { prize = 148, type = "Rare",condition ="Battle-Scared",stattrak = "StatTrak",firstname = "Karambit",secondname = "Scorched"});
		w1.Add(new CSGOSkins() { prize = 333, type = "Rare",condition ="Factory New",stattrak = "",firstname = "Karambit",secondname = "Slaughter"});
		w1.Add(new CSGOSkins() { prize = 362, type = "Rare",condition ="Field-Tested",stattrak = "StatTrak",firstname = "Karambit",secondname = "Slaughter"});
		w1.Add(new CSGOSkins() { prize = 122, type = "Rare",condition ="Field-Tested",stattrak = "",firstname = "Karambit",secondname = "Stained"});
		w1.Add(new CSGOSkins() { prize = 206, type = "Rare",condition ="Minimal Wear",stattrak = "StatTrak",firstname = "Karambit",secondname = "Stained"});
		w1.Add(new CSGOSkins() { prize = 91, type = "Rare",condition ="Battle-Scared",stattrak = "",firstname = "Karambit",secondname = "Urban Masked"});
		w1.Add(new CSGOSkins() { prize = 127, type = "Rare",condition ="Field-Tested",stattrak = "StatTrak",firstname = "Karambit",secondname = "Urban Masked"});
		w1.Add(new CSGOSkins() { prize = 37, type = "Rare",condition ="Battle-Scared",stattrak = "",firstname = "Gut Knife",secondname = "Blue Steel"});
		w1.Add(new CSGOSkins() { prize = 55, type = "Rare",condition ="Field-Tested",stattrak = "StatTrak",firstname = "Gut Knife",secondname = "Blue Steel"});
		w1.Add(new CSGOSkins() { prize = 43, type = "Rare",condition ="Minimal Wear",stattrak = "",firstname = "Gut Knife",secondname = "Case Hardened"});
		w1.Add(new CSGOSkins() { prize = 74, type = "Rare",condition ="Field-Tested",stattrak = "StatTrak",firstname = "Gut Knife",secondname = "Case Hardened"});
		w1.Add(new CSGOSkins() { prize = 31, type = "Rare",condition ="Field-Tested",stattrak = "",firstname = "Gut Knife",secondname = "Forest DDPAT"});
		w1.Add(new CSGOSkins() { prize = 45, type = "Rare",condition ="Field-Tested",stattrak = "StatTrak",firstname = "Gut Knife",secondname = "Forest DDPAT"});
		w1.Add(new CSGOSkins() { prize = 48, type = "Rare",condition ="Field-Tested",stattrak = "",firstname = "Flip Knife",secondname = "Blue Steel"});
		w1.Add(new CSGOSkins() { prize = 83, type = "Rare",condition ="Field-Tested",stattrak = "StatTrak",firstname = "Flip Knife",secondname = "Blue Steel"});
		w1.Add(new CSGOSkins() { prize = 168, type = "Rare",condition ="Factory New",stattrak = "",firstname = "Flip Knife",secondname = "Fade"});
		w1.Add(new CSGOSkins() { prize = 251, type = "Rare",condition ="Minimal Wear",stattrak = "StatTrak",firstname = "Flip Knife",secondname = "Fade"});
		w1.Add(new CSGOSkins() { prize = 40, type = "Rare",condition ="Battle-Scared",stattrak = "",firstname = "Flip Knife",secondname = "Stained"});
		w1.Add(new CSGOSkins() { prize = 57, type = "Rare",condition ="Well-Worn",stattrak = "StatTrak",firstname = "Flip Knife",secondname = "Stained"});
		w1.Add(new CSGOSkins() { prize = 82, type = "Rare",condition ="Field-Tested",stattrak = "",firstname = "Bayonet",secondname = "Case Hardened"});
		w1.Add(new CSGOSkins() { prize = 439, type = "Rare",condition ="Factory New",stattrak = "StatTrak",firstname = "Bayonet",secondname = "Case Hardened"});
		w1.Add(new CSGOSkins() { prize = 65, type = "Rare",condition ="Minimal Wear",stattrak = "",firstname = "Bayonet",secondname = "Scorched"});
		w1.Add(new CSGOSkins() { prize = 75, type = "Rare",condition ="Well-Worn",stattrak = "StatTrak",firstname = "Bayonet",secondname = "Scorched"});
		w1.Add(new CSGOSkins() { prize = 65, type = "Rare",condition ="Field-Tested",stattrak = "",firstname = "Bayonet",secondname = "Stained"});
		w1.Add(new CSGOSkins() { prize = 92, type = "Rare",condition ="Field-Tested",stattrak = "StatTrak",firstname = "Bayonet",secondname = "Stained"});
		w1.Add(new CSGOSkins() { prize = 50, type = "Rare",condition ="Well-Worn",stattrak = "",firstname = "Bayonet",secondname = "Urban Masked"});
		w1.Add(new CSGOSkins() { prize = 63, type = "Rare",condition ="Field-Tested",stattrak = "StatTrak",firstname = "Bayonet",secondname = "Urban Masked"});



	}
}