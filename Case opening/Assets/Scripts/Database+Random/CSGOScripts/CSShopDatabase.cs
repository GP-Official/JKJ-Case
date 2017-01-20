﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class CSShopDatabase : MonoBehaviour {
	public List<CSGOSkins> shop = new List<CSGOSkins> ();

	void Start () {
		shop.Add(new CSGOSkins() { prize = 86.24f, type = "Red",condition ="Battle-Scared",stattrak = "",firstname = "AK-47",secondname = "Fire Serpent"});
		shop.Add(new CSGOSkins() { prize = 129.24f, type = "Red",condition ="Well-Worn",stattrak = "", firstname = "AK-47",secondname = "Fire Serpent"});
		shop.Add(new CSGOSkins() { prize = 137.61f, type = "Red",condition ="Field-Tested",stattrak = "", firstname = "AK-47",secondname = "Fire Serpent"});
		shop.Add(new CSGOSkins() { prize = 214.20f, type = "Red",condition ="Minimal Wear",stattrak = "",firstname = "AK-47",secondname = "Fire Serpent"});
		shop.Add(new CSGOSkins() { prize = 348.0f, type = "Red",condition ="Factory New",stattrak = "",firstname = "AK-47",secondname = "Fire Serpent"});
		shop.Add(new CSGOSkins() { prize = 413.12f, type = "Red",condition ="Battle-Scared",stattrak = "StatTrak", firstname = "AK-47",secondname = "Fire Serpent"});
		shop.Add(new CSGOSkins() { prize = 535.36f, type = "Red",condition ="Field-Tested",stattrak = "StatTrak", firstname = "AK-47",secondname = "Fire Serpent"});
		shop.Add(new CSGOSkins() { prize = 1260.0f, type = "Red",condition ="Minimal Wear",stattrak = "StatTrak", firstname = "AK-47",secondname = "Fire Serpent"});
		shop.Add(new CSGOSkins() { prize = 85.52f, type = "Red",condition ="Minimal Wear",stattrak = "StatTrak", firstname = "Desert Eagle",secondname = "Golden Koi"});
		shop.Add(new CSGOSkins() { prize = 66.94f, type = "Red",condition ="Factory New",stattrak = "StatTrak", firstname = "Desert Eagle",secondname = "Golden Koi"});
		shop.Add(new CSGOSkins() { prize = 8.4f, type = "Red",condition ="Minimal Wear",stattrak = "",firstname = "M4A1-S",secondname = "Cyrex"});
		shop.Add(new CSGOSkins() { prize = 10.75f, type = "Red",condition ="Factory New",stattrak = "",firstname = "M4A1-S",secondname = "Cyrex"});
		shop.Add(new CSGOSkins() { prize = 19.3f, type = "Red",condition ="Field-Tested",stattrak = "StatTrak", firstname = "M4A1-S",secondname = "Cyrex"});
		shop.Add(new CSGOSkins() { prize = 35.5f, type = "Red",condition ="Minimal Wear",stattrak = "StatTrak", firstname = "M4A1-S",secondname = "Cyrex"});
		shop.Add(new CSGOSkins() { prize = 48.4f, type = "Red",condition ="Factory New",stattrak = "StatTrak", firstname = "M4A1-S",secondname = "Cyrex"});
		shop.Add(new CSGOSkins() { prize = 24.1f, type = "Red",condition ="Minimal Wear",stattrak = "StatTrak", firstname = "P90",secondname = "Asiimov"});
		shop.Add(new CSGOSkins() { prize = 75.9f, type = "Red",condition ="Factory New",stattrak = "StatTrak", firstname = "P90",secondname = "Asiimov"});
		shop.Add(new CSGOSkins() { prize = 217.92f, type = "Pink",condition ="Minimal Wear",stattrak = "",firstname = "M4A1-S",secondname = "Knight"});
		shop.Add(new CSGOSkins() { prize = 222.97f, type = "Pink",condition ="Factory New",stattrak = "",firstname = "M4A1-S",secondname = "Knight"});
		shop.Add(new CSGOSkins() { prize = 700.52f, type = "Pink",condition ="Minimal Wear",stattrak = "Souvenir", firstname = "M4A1-S",secondname = "Knight"});
		shop.Add(new CSGOSkins() { prize = 900.21f, type = "Pink",condition ="Factory New",stattrak = "Souvenir", firstname = "M4A1-S",secondname = "Knight"});
		shop.Add(new CSGOSkins() { prize = 429.00f, type = "Red",condition ="Battle-Scared",stattrak = "",firstname = "AWP",secondname = "Dragon Lore"});
		shop.Add(new CSGOSkins() { prize = 489.00f, type = "Red",condition ="Well-Worn",stattrak = "",firstname = "AWP",secondname = "Dragon Lore"});
		shop.Add(new CSGOSkins() { prize = 600.00f, type = "Red",condition ="Field-Tested",stattrak = "", firstname = "AWP",secondname = "Dragon Lore"});
		shop.Add(new CSGOSkins() { prize = 892.00f, type = "Red",condition ="Minimal Wear",stattrak = "",firstname = "AWP",secondname = "Dragon Lore"});
		shop.Add(new CSGOSkins() { prize = 1170.00f, type = "Red",condition ="Factory New",stattrak = "",firstname = "AWP",secondname = "Dragon Lore"});
		shop.Add(new CSGOSkins() { prize = 1500.00f, type = "Red",condition ="Battle-Scared",stattrak = "Souvenir", firstname = "AWP",secondname = "Dragon Lore"});
		shop.Add(new CSGOSkins() { prize = 2500.00f, type = "Red",condition ="Well-Worn",stattrak = "Souvenir", firstname = "AWP",secondname = "Dragon Lore"});
		shop.Add(new CSGOSkins() { prize = 5000.00f, type = "Red",condition ="Field-Tested",stattrak = "Souvenir", firstname = "AWP",secondname = "Dragon Lore"});
		shop.Add(new CSGOSkins() { prize = 10000.00f, type = "Red",condition ="Minimal Wear",stattrak = "Souvenir", firstname = "AWP",secondname = "Dragon Lore"});
		shop.Add(new CSGOSkins() { prize = 15000.00f, type = "Red",condition ="Factory New",stattrak = "Souvenir", firstname = "AWP",secondname = "Dragon Lore"});
		shop.Add(new CSGOSkins() { prize = 29.08f, type = "Red",condition ="Factory New",stattrak = "",firstname = "AK-47",secondname = "Jaguar"});
		shop.Add(new CSGOSkins() { prize = 24.56f, type = "Red",condition ="Battle-Scared",stattrak = "StatTrak", firstname = "AK-47",secondname = "Jaguar"});
		shop.Add(new CSGOSkins() { prize = 28.66f, type = "Red",condition ="Well-Worn",stattrak = "StatTrak", firstname = "AK-47",secondname = "Jaguar"});
		shop.Add(new CSGOSkins() { prize = 37.66f, type = "Red",condition ="Field-Tested",stattrak = "StatTrak", firstname = "AK-47",secondname = "Jaguar"});
		shop.Add(new CSGOSkins() { prize = 54.59f, type = "Red",condition ="Minimal Wear",stattrak = "StatTrak", firstname = "AK-47",secondname = "Jaguar"});
		shop.Add(new CSGOSkins() { prize = 232.20f, type = "Red",condition ="Factory New",stattrak = "StatTrak", firstname = "AK-47",secondname = "Jaguar"});
		shop.Add(new CSGOSkins() { prize = 16.48f, type = "Red",condition ="Field-Tested",stattrak = "StatTrak", firstname = "M4A4",secondname = "X-Ray"});
		shop.Add(new CSGOSkins() { prize = 24.42f, type = "Red",condition ="Minimal Wear",stattrak = "StatTrak", firstname = "M4A4",secondname = "X-Ray"});
		shop.Add(new CSGOSkins() { prize = 36.80f, type = "Red",condition ="Factory New",stattrak = "StatTrak", firstname = "M4A4",secondname = "X-Ray"});
		shop.Add(new CSGOSkins() { prize = 17.89f, type = "Red",condition ="Field-Tested",stattrak = "", firstname = "AWP",secondname = "Hyper Beast"});
		shop.Add(new CSGOSkins() { prize = 25.76f, type = "Red",condition ="Minimal Wear",stattrak = "",firstname = "AWP",secondname = "Hyper Beast"});
		shop.Add(new CSGOSkins() { prize = 36.48f, type = "Red",condition ="Factory New",stattrak = "",firstname = "AWP",secondname = "Hyper Beast"});
		shop.Add(new CSGOSkins() { prize = 25.76f, type = "Red",condition ="Battle-Scared",stattrak = "StatTrak", firstname = "AWP",secondname = "Hyper Beast"});
		shop.Add(new CSGOSkins() { prize = 31.73f, type = "Red",condition ="Well-Worn",stattrak = "StatTrak", firstname = "AWP",secondname = "Hyper Beast"});
		shop.Add(new CSGOSkins() { prize = 47.56f, type = "Red",condition ="Field-Tested",stattrak = "StatTrak", firstname = "AWP",secondname = "Hyper Beast"});
		shop.Add(new CSGOSkins() { prize = 79.06f, type = "Red",condition ="Minimal Wear",stattrak = "StatTrak", firstname = "AWP",secondname = "Hyper Beast"});
		shop.Add(new CSGOSkins() { prize = 191.41f, type = "Red",condition ="Factory New",stattrak = "StatTrak", firstname = "AWP",secondname = "Hyper Beast"});
		shop.Add(new CSGOSkins() { prize = 16.77f, type = "Red",condition ="Minimal Wear",stattrak = "",firstname = "AK-47",secondname = "Aquamarine Revenge"});
		shop.Add(new CSGOSkins() { prize = 26.1f, type = "Red",condition ="Factory New",stattrak = "",firstname = "AK-47",secondname = "Aquamarine Revenge"});
		shop.Add(new CSGOSkins() { prize = 27.7f, type = "Red",condition ="Battle-Scared",stattrak = "StatTrak", firstname = "AK-47",secondname = "Aquamarine Revenge"});
		shop.Add(new CSGOSkins() { prize = 32.47f, type = "Red",condition ="Well-Worn",stattrak = "StatTrak", firstname = "AK-47",secondname = "Aquamarine Revenge"});
		shop.Add(new CSGOSkins() { prize = 39.04f, type = "Red",condition ="Field-Tested",stattrak = "StatTrak", firstname = "AK-47",secondname = "Aquamarine Revenge"});
		shop.Add(new CSGOSkins() { prize = 52.56f, type = "Red",condition ="Minimal Wear",stattrak = "StatTrak", firstname = "AK-47",secondname = "Aquamarine Revenge"});
		shop.Add(new CSGOSkins() { prize = 120.56f, type = "Red",condition ="Factory New",stattrak = "StatTrak", firstname = "AK-47",secondname = "Aquamarine Revenge"});
		shop.Add(new CSGOSkins() { prize = 24.6f, type = "Red",condition ="Battle-Scared",stattrak = "",firstname = "AK-47",secondname = "Neon Revolution"});
		shop.Add(new CSGOSkins() { prize = 35.7f, type = "Red",condition ="Well-Worn",stattrak = "",firstname = "AK-47",secondname = "Neon Revolution"});
		shop.Add(new CSGOSkins() { prize = 44.2f, type = "Red",condition ="Minimal Wear",stattrak = "",firstname = "AK-47",secondname = "Neon Revolution"});
		shop.Add(new CSGOSkins() { prize = 74.9f, type = "Red",condition ="Factory New",stattrak = "",firstname = "AK-47",secondname = "Neon Revolution"});
		shop.Add(new CSGOSkins() { prize = 70.4f, type = "Red",condition ="Battle-Scared",stattrak = "StatTrak", firstname = "AK-47",secondname = "Neon Revolution"});
		shop.Add(new CSGOSkins() { prize = 94.7f, type = "Red",condition ="Well-Worn",stattrak = "StatTrak", firstname = "AK-47",secondname = "Neon Revolution"});
		shop.Add(new CSGOSkins() { prize = 84.1f, type = "Red",condition ="Field-Tested",stattrak = "StatTrak", firstname = "AK-47",secondname = "Neon Revolution"});
		shop.Add(new CSGOSkins() { prize = 142.7f, type = "Red",condition ="Minimal Wear",stattrak = "StatTrak", firstname = "AK-47",secondname = "Neon Revolution"});
		shop.Add(new CSGOSkins() { prize = 313.6f, type = "Red",condition ="Factory New",stattrak = "StatTrak", firstname = "AK-47",secondname = "Neon Revolution"});
		shop.Add(new CSGOSkins() { prize = 12.4f, type = "Red",condition ="Minimal Wear",stattrak = "",firstname = "Glock-18",secondname = "Wasteland Rebel"});
		shop.Add(new CSGOSkins() { prize = 14.8f, type = "Red",condition ="Factory New",stattrak = "",firstname = "Glock-18",secondname = "Wasteland Rebel"});
		shop.Add(new CSGOSkins() { prize = 21.8f, type = "Red",condition ="Battle-Scared",stattrak = "StatTrak", firstname = "Glock-18",secondname = "Wasteland Rebel"});
		shop.Add(new CSGOSkins() { prize = 40.2f, type = "Red",condition ="Well-Worn",stattrak = "StatTrak", firstname = "Glock-18",secondname = "Wasteland Rebel"});
		shop.Add(new CSGOSkins() { prize = 29.8f, type = "Red",condition ="Field-Tested",stattrak = "StatTrak", firstname = "Glock-18",secondname = "Wasteland Rebel"});
		shop.Add(new CSGOSkins() { prize = 46.6f, type = "Red",condition ="Minimal Wear",stattrak = "StatTrak", firstname = "Glock-18",secondname = "Wasteland Rebel"});
		shop.Add(new CSGOSkins() { prize = 60.1f, type = "Red",condition ="Factory New",stattrak = "StatTrak", firstname = "Glock-18",secondname = "Wasteland Rebel"});
		shop.Add(new CSGOSkins() { prize = 21.1f, type = "Red",condition ="Minimal Wear",stattrak = "",firstname = "M4A1-S",secondname = "Mecha Industries"});
		shop.Add(new CSGOSkins() { prize = 32.2f, type = "Red",condition ="Factory New",stattrak = "",firstname = "M4A1-S",secondname = "Mecha Industries"});
		shop.Add(new CSGOSkins() { prize = 40.4f, type = "Red",condition ="Battle-Scared",stattrak = "StatTrak", firstname = "M4A1-S",secondname = "Mecha Industries"});
		shop.Add(new CSGOSkins() { prize = 48.2f, type = "Red",condition ="Well-Worn",stattrak = "StatTrak", firstname = "M4A1-S",secondname = "Mecha Industries"});
		shop.Add(new CSGOSkins() { prize = 49.4f, type = "Red",condition ="Field-Tested",stattrak = "StatTrak", firstname = "M4A1-S",secondname = "Mecha Industries"});
		shop.Add(new CSGOSkins() { prize = 81.7f, type = "Red",condition ="Minimal Wear",stattrak = "StatTrak", firstname = "M4A1-S",secondname = "Mecha Industries"});
		shop.Add(new CSGOSkins() { prize = 167.2f, type = "Red",condition ="Factory New",stattrak = "StatTrak", firstname = "M4A1-S",secondname = "Mecha Industries"});
		shop.Add(new CSGOSkins() { prize = 78.69f, type = "Pink",condition ="Field-Tested",stattrak = "", firstname = "M4A4",secondname = "Poseidon"});
		shop.Add(new CSGOSkins() { prize = 79.72f, type = "Pink",condition ="Minimal Wear",stattrak = "",firstname = "M4A4",secondname = "Poseidon"});
		shop.Add(new CSGOSkins() { prize = 120.57f, type = "Pink",condition ="Factory New",stattrak = "",firstname = "M4A4",secondname = "Poseidon"});
		shop.Add(new CSGOSkins() { prize = 310.47f, type = "Red",condition ="Battle-Scared",stattrak = "",firstname = "AWP",secondname = "Medusa"});
		shop.Add(new CSGOSkins() { prize = 309.57f, type = "Red",condition ="Well-Worn",stattrak = "",firstname = "AWP",secondname = "Medusa"});
		shop.Add(new CSGOSkins() { prize = 260.07f, type = "Red",condition ="Field-Tested",stattrak = "", firstname = "AWP",secondname = "Medusa"});
		shop.Add(new CSGOSkins() { prize = 416.41f, type = "Red",condition ="Minimal Wear",stattrak = "",firstname = "AWP",secondname = "Medusa"});
		shop.Add(new CSGOSkins() { prize = 840.72f, type = "Red",condition ="Factory New",stattrak = "",firstname = "AWP",secondname = "Medusa"});
		shop.Add(new CSGOSkins() { prize = 16.3f, type = "Red",condition ="Field-Tested",stattrak = "", firstname = "AK-47",secondname = "Vulcan"});
		shop.Add(new CSGOSkins() { prize = 29.1f, type = "Red",condition ="Minimal Wear",stattrak = "",firstname = "AK-47",secondname = "Vulcan"});
		shop.Add(new CSGOSkins() { prize = 47.1f, type = "Red",condition ="Factory New",stattrak = "",firstname = "AK-47",secondname = "Vulcan"});
		shop.Add(new CSGOSkins() { prize = 24.8f, type = "Red",condition ="Battle-Scared",stattrak = "StatTrak", firstname = "AK-47",secondname = "Vulcan"});
		shop.Add(new CSGOSkins() { prize = 54.3f, type = "Red",condition ="Well-Worn",stattrak = "StatTrak", firstname = "AK-47",secondname = "Vulcan"});
		shop.Add(new CSGOSkins() { prize = 57.0f, type = "Red",condition ="Field-Tested",stattrak = "StatTrak", firstname = "AK-47",secondname = "Vulcan"});
		shop.Add(new CSGOSkins() { prize = 137, type = "Red",condition ="Minimal Wear",stattrak = "StatTrak", firstname = "AK-47",secondname = "Vulcan"});
		shop.Add(new CSGOSkins() { prize = 290, type = "Red",condition ="Factory New",stattrak = "StatTrak", firstname = "AK-47",secondname = "Vulcan"});
		shop.Add(new CSGOSkins() { prize = 13.42f, type = "Red",condition ="Minimal Wear",stattrak = "",firstname = "M4A1-S",secondname = "Hyper Beast"});
		shop.Add(new CSGOSkins() { prize = 28.83f, type = "Red",condition ="Factory New",stattrak = "", firstname = "M4A1-S",secondname = "Hyper Beast"});
		shop.Add(new CSGOSkins() { prize = 15.34f, type = "Red",condition ="Battle-Scared",stattrak = "StatTrak", firstname = "M4A1-S",secondname = "Hyper Beast"});
		shop.Add(new CSGOSkins() { prize = 20.46f, type = "Red",condition ="Well-Worn",stattrak = "StatTrak", firstname = "M4A1-S",secondname = "Hyper Beast"});
		shop.Add(new CSGOSkins() { prize = 25.93f, type = "Red",condition ="Field-Tested",stattrak = "StatTrak", firstname = "M4A1-S",secondname = "Hyper Beast"});
		shop.Add(new CSGOSkins() { prize = 44.38f, type = "Red",condition ="Minimal Wear",stattrak = "StatTrak",firstname = "M4A1-S",secondname = "Hyper Beast"});
		shop.Add(new CSGOSkins() { prize = 144, type = "Red",condition ="Factory New",stattrak = "StatTrak", firstname = "M4A1-S",secondname = "Hyper Beast"});
		shop.Add(new CSGOSkins() { prize = 8.72f, type = "Red",condition ="Field-Tested",stattrak = "",firstname = "M4A1-S",secondname = "Chanticos Fire"});
		shop.Add(new CSGOSkins() { prize = 13.42f, type = "Red",condition ="Minimal Wear",stattrak = "",firstname = "M4A1-S",secondname = "Chanticos Fire"});
		shop.Add(new CSGOSkins() { prize = 28.83f, type = "Red",condition ="Factory New",stattrak = "", firstname = "M4A1-S",secondname = "Chanticos Fire"});
		shop.Add(new CSGOSkins() { prize = 15.34f, type = "Red",condition ="Battle-Scared",stattrak = "StatTrak", firstname = "M4A1-S",secondname = "Chanticos Fire"});
		shop.Add(new CSGOSkins() { prize = 20.46f, type = "Red",condition ="Well-Worn",stattrak = "StatTrak", firstname = "M4A1-S",secondname = "Chanticos Fire"});
		shop.Add(new CSGOSkins() { prize = 25.93f, type = "Red",condition ="Field-Tested",stattrak = "StatTrak", firstname = "M4A1-S",secondname = "Chanticos Fire"});
		shop.Add(new CSGOSkins() { prize = 44.38f, type = "Red",condition ="Minimal Wear",stattrak = "StatTrak",firstname = "M4A1-S",secondname = "Chanticos Fire"});
		shop.Add(new CSGOSkins() { prize = 144, type = "Red",condition ="Factory New",stattrak = "StatTrak", firstname = "M4A1-S",secondname = "Chanticos Fire"});
		shop.Add(new CSGOSkins() { prize = 27.66f, type = "Purple",condition ="Minimal Wear",stattrak = "",firstname = "Tec-9",secondname = "Nuclear Threat"});
		shop.Add(new CSGOSkins() { prize = 360.79f, type = "Purple",condition ="Factory New",stattrak = "",firstname = "Tec-9",secondname = "Nuclear Threat"});
		shop.Add(new CSGOSkins() { prize = 39.09f, type = "Purple",condition ="Battle-Scared",stattrak = "Souvenir", firstname = "Tec-9",secondname = "Nuclear Threat"});
		shop.Add(new CSGOSkins() { prize = 44.11f, type = "Purple",condition ="Well-Worn",stattrak = "Souvenir", firstname = "Tec-9",secondname = "Nuclear Threat"});
		shop.Add(new CSGOSkins() { prize = 68.13f, type = "Purple",condition ="Field-Tested",stattrak = "Souvenir", firstname = "Tec-9",secondname = "Nuclear Threat"});
		shop.Add(new CSGOSkins() { prize = 373.40f, type = "Purple",condition ="Minimal Wear",stattrak = "Souvenir", firstname = "Tec-9",secondname = "Nuclear Threat"});
		shop.Add(new CSGOSkins() { prize = 524.87f, type = "Purple",condition ="Factory New",stattrak = "Souvenir", firstname = "Tec-9",secondname = "Nuclear Threat"});
		shop.Add(new CSGOSkins() { prize = 22.46f, type = "Pink",condition ="Field-Tested",stattrak = "", firstname = "M4A1-S",secondname = "Master Piece"});
		shop.Add(new CSGOSkins() { prize = 35.49f, type = "Pink",condition ="Minimal Wear",stattrak = "",firstname = "M4A1-S",secondname = "Master Piece"});
		shop.Add(new CSGOSkins() { prize = 88.79f, type = "Pink",condition ="Factory New",stattrak = "",firstname = "M4A1-S",secondname = "Master Piece"});
		shop.Add(new CSGOSkins() { prize = 210.78f, type = "Pink",condition ="Battle-Scared",stattrak = "Souvenir", firstname = "M4A1-S",secondname = "Master Piece"});
		shop.Add(new CSGOSkins() { prize = 345.81f, type = "Pink",condition ="Well-Worn",stattrak = "Souvenir", firstname = "M4A1-S",secondname = "Master Piece"});
		shop.Add(new CSGOSkins() { prize = 500.27f, type = "Pink",condition ="Field-Tested",stattrak = "Souvenir", firstname = "M4A1-S",secondname = "Master Piece"});
		shop.Add(new CSGOSkins() { prize = 1000.50f, type = "Pink",condition ="Minimal Wear",stattrak = "Souvenir", firstname = "M4A1-S",secondname = "Master Piece"});
		shop.Add(new CSGOSkins() { prize = 1700.98f, type = "Pink",condition ="Factory New",stattrak = "Souvenir", firstname = "M4A1-S",secondname = "Master Piece"});
		shop.Add(new CSGOSkins() { prize = 16.64f, type = "Red",condition ="Battle-Scared",stattrak = "",firstname = "AWP",secondname = "Asiimov"});
		shop.Add(new CSGOSkins() { prize = 24.86f, type = "Red",condition ="Field-Tested",stattrak = "", firstname = "AWP",secondname = "Asiimov"});
		shop.Add(new CSGOSkins() { prize = 44.99f, type = "Red",condition ="Battle-Scared",stattrak = "StatTrak", firstname = "AWP",secondname = "Asiimov"});
		shop.Add(new CSGOSkins() { prize = 59.88f, type = "Red",condition ="Well-Worn",stattrak = "StatTrak", firstname = "AWP",secondname = "Asiimov"});
		shop.Add(new CSGOSkins() { prize = 70.85f, type = "Red",condition ="Field-Tested",stattrak = "StatTrak", firstname = "AWP",secondname = "Asiimov"});
		shop.Add(new CSGOSkins() { prize = 13.3f, type = "Red",condition ="Battle-Scared",stattrak = "",firstname = "AK-47",secondname = "Wasteland Rebel"});
		shop.Add(new CSGOSkins() { prize = 16.49f, type = "Red",condition ="Well-Worn",stattrak = "",firstname = "AK-47",secondname = "Wasteland Rebel"});
		shop.Add(new CSGOSkins() { prize = 13.88f, type = "Red",condition ="Field-Tested",stattrak = "", firstname = "AK-47",secondname = "Wasteland Rebel"});
		shop.Add(new CSGOSkins() { prize = 20.15f, type = "Red",condition ="Minimal Wear",stattrak = "",firstname = "AK-47",secondname = "Wasteland Rebel"});
		shop.Add(new CSGOSkins() { prize = 76.72f, type = "Red",condition ="Factory New",stattrak = "",firstname = "AK-47",secondname = "Wasteland Rebel"});
		shop.Add(new CSGOSkins() { prize = 44.75f, type = "Red",condition ="Battle-Scared",stattrak = "StatTrak", firstname = "AK-47",secondname = "Wasteland Rebel"});
		shop.Add(new CSGOSkins() { prize = 62.70f, type = "Red",condition ="Well-Worn",stattrak = "StatTrak", firstname = "AK-47",secondname = "Wasteland Rebel"});
		shop.Add(new CSGOSkins() { prize = 55.64f, type = "Red",condition ="Field-Tested",stattrak = "StatTrak", firstname = "AK-47",secondname = "Wasteland Rebel"});
		shop.Add(new CSGOSkins() { prize = 80.81f, type = "Red",condition ="Minimal Wear",stattrak = "StatTrak", firstname = "AK-47",secondname = "Wasteland Rebel"});
		shop.Add(new CSGOSkins() { prize = 360, type = "Red",condition ="Factory New",stattrak = "StatTrak", firstname = "AK-47",secondname = "Wasteland Rebel"});
		shop.Add(new CSGOSkins() { prize = 46.26f, type = "Red",condition ="Minimal Wear",stattrak = "",firstname = "AWP",secondname = "Lightning Strike"});
		shop.Add(new CSGOSkins() { prize = 41.02f, type = "Red",condition ="Factory New",stattrak = "",firstname = "AWP",secondname = "Lightning Strike"});
		shop.Add(new CSGOSkins() { prize = 505.00f, type = "Red",condition ="Minimal Wear",stattrak = "StatTrak", firstname = "AWP",secondname = "Lightning Strike"});
		shop.Add(new CSGOSkins() { prize = 158.63f, type = "Red",condition ="Factory New",stattrak = "StatTrak", firstname = "AWP",secondname = "Lightning Strike"});
		shop.Add(new CSGOSkins() { prize = 16.39f, type = "Pink",condition ="Field-Tested",stattrak = "", firstname = "AK-47",secondname = "Case Hardened"});
		shop.Add(new CSGOSkins() { prize = 20.32f, type = "Pink",condition ="Minimal Wear",stattrak = "",firstname = "AK-47",secondname = "Case Hardened"});
		shop.Add(new CSGOSkins() { prize = 33.47f, type = "Pink",condition ="Factory New",stattrak = "",firstname = "AK-47",secondname = "Case Hardened"});
		shop.Add(new CSGOSkins() { prize = 49.32f, type = "Pink",condition ="Battle-Scared",stattrak = "StatTrak", firstname = "AK-47",secondname = "Case Hardened"});
		shop.Add(new CSGOSkins() { prize = 58.78f, type = "Pink",condition ="Well-Worn",stattrak = "StatTrak", firstname = "AK-47",secondname = "Case Hardened"});
		shop.Add(new CSGOSkins() { prize = 65.24f, type = "Pink",condition ="Field-Tested",stattrak = "StatTrak", firstname = "AK-47",secondname = "Case Hardened"});
		shop.Add(new CSGOSkins() { prize = 89.69f, type = "Pink",condition ="Minimal Wear",stattrak = "StatTrak", firstname = "AK-47",secondname = "Case Hardened"});
		shop.Add(new CSGOSkins() { prize = 202.21f, type = "Pink",condition ="Factory New",stattrak = "StatTrak", firstname = "AK-47",secondname = "Case Hardened"});
		shop.Add(new CSGOSkins() { prize = 11.46f, type = "Red",condition ="Battle-Scared",stattrak = "",firstname = "M4A4",secondname = "Asiimov"});
		shop.Add(new CSGOSkins() { prize = 20.94f, type = "Red",condition ="Well-Worn",stattrak = "",firstname = "M4A4",secondname = "Asiimov"});
		shop.Add(new CSGOSkins() { prize = 29.82f, type = "Red",condition ="Field-Tested",stattrak = "", firstname = "M4A4",secondname = "Asiimov"});
		shop.Add(new CSGOSkins() { prize = 33.68f, type = "Red",condition ="Battle-Scared",stattrak = "StatTrak", firstname = "M4A4",secondname = "Asiimov"});
		shop.Add(new CSGOSkins() { prize = 89.75f, type = "Red",condition ="Well-Worn",stattrak = "StatTrak", firstname = "M4A4",secondname = "Asiimov"});
		shop.Add(new CSGOSkins() { prize = 149.57f, type = "Red",condition ="Field-Tested",stattrak = "StatTrak", firstname = "M4A4",secondname = "Asiimov"});
		shop.Add(new CSGOSkins() { prize = 18.5f, type = "Red",condition ="Well-Worn",stattrak = "",firstname = "AK-47",secondname = "Fuel Injector"});
		shop.Add(new CSGOSkins() { prize = 28.0f, type = "Red",condition ="Minimal Wear",stattrak = "",firstname = "AK-47",secondname = "Fuel Injector"});
		shop.Add(new CSGOSkins() { prize = 51.8f, type = "Red",condition ="Factory New",stattrak = "",firstname = "AK-47",secondname = "Fuel Injector"});
		shop.Add(new CSGOSkins() { prize = 54, type = "Red",condition ="Battle-Scared",stattrak = "StatTrak", firstname = "AK-47",secondname = "Fuel Injector"});
		shop.Add(new CSGOSkins() { prize = 66, type = "Red",condition ="Well-Worn",stattrak = "StatTrak", firstname = "AK-47",secondname = "Fuel Injector"});
		shop.Add(new CSGOSkins() { prize = 74, type = "Red",condition ="Field-Tested",stattrak = "StatTrak", firstname = "AK-47",secondname = "Fuel Injector"});
		shop.Add(new CSGOSkins() { prize = 105, type = "Red",condition ="Minimal Wear",stattrak = "StatTrak", firstname = "AK-47",secondname = "Fuel Injector"});
		shop.Add(new CSGOSkins() { prize = 252, type = "Red",condition ="Factory New",stattrak = "StatTrak", firstname = "AK-47",secondname = "Fuel Injector"});
	}
}