﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class PremiumDatabase : MonoBehaviour {
	public List<CSGOSkins> pr = new List<CSGOSkins> ();

	void Start () {
		pr.Add(new CSGOSkins() { prize = 78.69f, type = "Pink",condition ="Field-Tested",stattrak = "", firstname = "M4A4",secondname = "Poseidon"});
		pr.Add(new CSGOSkins() { prize = 79.72f, type = "Pink",condition ="Minimal Wear",stattrak = "",firstname = "M4A4",secondname = "Poseidon"});
		pr.Add(new CSGOSkins() { prize = 120.57f, type = "Pink",condition ="Factory New",stattrak = "",firstname = "M4A4",secondname = "Poseidon"});
		pr.Add(new CSGOSkins() { prize = 9.37f, type = "Red",condition ="Battle-Scared",stattrak = "",firstname = "AK-47",secondname = "Vulcan"});
		pr.Add(new CSGOSkins() { prize = 15.3f, type = "Red",condition ="Well-Worn",stattrak = "",firstname = "AK-47",secondname = "Vulcan"});
		pr.Add(new CSGOSkins() { prize = 16.3f, type = "Red",condition ="Field-Tested",stattrak = "", firstname = "AK-47",secondname = "Vulcan"});
		pr.Add(new CSGOSkins() { prize = 29.1f, type = "Red",condition ="Minimal Wear",stattrak = "",firstname = "AK-47",secondname = "Vulcan"});
		pr.Add(new CSGOSkins() { prize = 47.1f, type = "Red",condition ="Factory New",stattrak = "",firstname = "AK-47",secondname = "Vulcan"});
		pr.Add(new CSGOSkins() { prize = 24.8f, type = "Red",condition ="Battle-Scared",stattrak = "StatTrak", firstname = "AK-47",secondname = "Vulcan"});
		pr.Add(new CSGOSkins() { prize = 54.3f, type = "Red",condition ="Well-Worn",stattrak = "StatTrak", firstname = "AK-47",secondname = "Vulcan"});
		pr.Add(new CSGOSkins() { prize = 57.0f, type = "Red",condition ="Field-Tested",stattrak = "StatTrak", firstname = "AK-47",secondname = "Vulcan"});
		pr.Add(new CSGOSkins() { prize = 137, type = "Red",condition ="Minimal Wear",stattrak = "StatTrak", firstname = "AK-47",secondname = "Vulcan"});
		pr.Add(new CSGOSkins() { prize = 290, type = "Red",condition ="Factory New",stattrak = "StatTrak", firstname = "AK-47",secondname = "Vulcan"});
		pr.Add(new CSGOSkins() { prize = 16.64f, type = "Red",condition ="Battle-Scared",stattrak = "",firstname = "AWP",secondname = "Asiimov"});
		pr.Add(new CSGOSkins() { prize = 21.21f, type = "Red",condition ="Well-Worn",stattrak = "",firstname = "AWP",secondname = "Asiimov"});
		pr.Add(new CSGOSkins() { prize = 24.86f, type = "Red",condition ="Field-Tested",stattrak = "", firstname = "AWP",secondname = "Asiimov"});
		pr.Add(new CSGOSkins() { prize = 44.99f, type = "Red",condition ="Battle-Scared",stattrak = "StatTrak", firstname = "AWP",secondname = "Asiimov"});
		pr.Add(new CSGOSkins() { prize = 59.88f, type = "Red",condition ="Well-Worn",stattrak = "StatTrak", firstname = "AWP",secondname = "Asiimov"});
		pr.Add(new CSGOSkins() { prize = 70.85f, type = "Red",condition ="Field-Tested",stattrak = "StatTrak", firstname = "AWP",secondname = "Asiimov"});
		pr.Add(new CSGOSkins() { prize = 46.26f, type = "Red",condition ="Minimal Wear",stattrak = "",firstname = "AWP",secondname = "Lightning Strike"});
		pr.Add(new CSGOSkins() { prize = 41.02f, type = "Red",condition ="Factory New",stattrak = "",firstname = "AWP",secondname = "Lightning Strike"});
		pr.Add(new CSGOSkins() { prize = 505.00f, type = "Red",condition ="Minimal Wear",stattrak = "StatTrak", firstname = "AWP",secondname = "Lightning Strike"});
		pr.Add(new CSGOSkins() { prize = 158.63f, type = "Red",condition ="Factory New",stattrak = "StatTrak", firstname = "AWP",secondname = "Lightning Strike"});
		pr.Add(new CSGOSkins() { prize = 14.42f, type = "Pink",condition ="Battle-Scared",stattrak = "",firstname = "AK-47",secondname = "Case Hardened"});
		pr.Add(new CSGOSkins() { prize = 15.40f, type = "Pink",condition ="Well-Worn",stattrak = "",firstname = "AK-47",secondname = "Case Hardened"});
		pr.Add(new CSGOSkins() { prize = 16.39f, type = "Pink",condition ="Field-Tested",stattrak = "", firstname = "AK-47",secondname = "Case Hardened"});
		pr.Add(new CSGOSkins() { prize = 20.32f, type = "Pink",condition ="Minimal Wear",stattrak = "",firstname = "AK-47",secondname = "Case Hardened"});
		pr.Add(new CSGOSkins() { prize = 33.47f, type = "Pink",condition ="Factory New",stattrak = "",firstname = "AK-47",secondname = "Case Hardened"});
		pr.Add(new CSGOSkins() { prize = 49.32f, type = "Pink",condition ="Battle-Scared",stattrak = "StatTrak", firstname = "AK-47",secondname = "Case Hardened"});
		pr.Add(new CSGOSkins() { prize = 58.78f, type = "Pink",condition ="Well-Worn",stattrak = "StatTrak", firstname = "AK-47",secondname = "Case Hardened"});
		pr.Add(new CSGOSkins() { prize = 65.24f, type = "Pink",condition ="Field-Tested",stattrak = "StatTrak", firstname = "AK-47",secondname = "Case Hardened"});
		pr.Add(new CSGOSkins() { prize = 89.69f, type = "Pink",condition ="Minimal Wear",stattrak = "StatTrak", firstname = "AK-47",secondname = "Case Hardened"});
		pr.Add(new CSGOSkins() { prize = 202.21f, type = "Pink",condition ="Factory New",stattrak = "StatTrak", firstname = "AK-47",secondname = "Case Hardened"});
		pr.Add(new CSGOSkins() { prize = 8.31f, type = "Pink",condition ="Well-Worn",stattrak = "",firstname = "AWP",secondname = "Electric Hive"});
		pr.Add(new CSGOSkins() { prize = 7.19f, type = "Pink",condition ="Field-Tested",stattrak = "", firstname = "AWP",secondname = "Electric Hive"});
		pr.Add(new CSGOSkins() { prize = 9.14f, type = "Pink",condition ="Minimal Wear",stattrak = "",firstname = "AWP",secondname = "Electric Hive"});
		pr.Add(new CSGOSkins() { prize = 10.03f, type = "Pink",condition ="Factory New",stattrak = "",firstname = "AWP",secondname = "Electric Hive"});
		pr.Add(new CSGOSkins() { prize = 30.82f, type = "Pink",condition ="Well-Worn",stattrak = "StatTrak", firstname = "AWP",secondname = "Electric Hive"});
		pr.Add(new CSGOSkins() { prize = 22.73f, type = "Pink",condition ="Field-Tested",stattrak = "StatTrak", firstname = "AWP",secondname = "Electric Hive"});
		pr.Add(new CSGOSkins() { prize = 29.60f, type = "Pink",condition ="Minimal Wear",stattrak = "StatTrak", firstname = "AWP",secondname = "Electric Hive"});
		pr.Add(new CSGOSkins() { prize = 48.62f, type = "Pink",condition ="Factory New",stattrak = "StatTrak", firstname = "AWP",secondname = "Electric Hive"});
		pr.Add(new CSGOSkins() { prize = 24.6f, type = "Red",condition ="Battle-Scared",stattrak = "",firstname = "AK-47",secondname = "Neon Revolution"});
		pr.Add(new CSGOSkins() { prize = 35.7f, type = "Red",condition ="Well-Worn",stattrak = "",firstname = "AK-47",secondname = "Neon Revolution"});
		pr.Add(new CSGOSkins() { prize = 28.4f, type = "Red",condition ="Field-Tested",stattrak = "", firstname = "AK-47",secondname = "Neon Revolution"});
		pr.Add(new CSGOSkins() { prize = 44.2f, type = "Red",condition ="Minimal Wear",stattrak = "",firstname = "AK-47",secondname = "Neon Revolution"});
		pr.Add(new CSGOSkins() { prize = 74.9f, type = "Red",condition ="Factory New",stattrak = "",firstname = "AK-47",secondname = "Neon Revolution"});
		pr.Add(new CSGOSkins() { prize = 70.4f, type = "Red",condition ="Battle-Scared",stattrak = "StatTrak", firstname = "AK-47",secondname = "Neon Revolution"});
		pr.Add(new CSGOSkins() { prize = 94.7f, type = "Red",condition ="Well-Worn",stattrak = "StatTrak", firstname = "AK-47",secondname = "Neon Revolution"});
		pr.Add(new CSGOSkins() { prize = 84.1f, type = "Red",condition ="Field-Tested",stattrak = "StatTrak", firstname = "AK-47",secondname = "Neon Revolution"});
		pr.Add(new CSGOSkins() { prize = 142.7f, type = "Red",condition ="Minimal Wear",stattrak = "StatTrak", firstname = "AK-47",secondname = "Neon Revolution"});
		pr.Add(new CSGOSkins() { prize = 313.6f, type = "Red",condition ="Factory New",stattrak = "StatTrak", firstname = "AK-47",secondname = "Neon Revolution"});
		pr.Add(new CSGOSkins() { prize = 12.52f, type = "Pink",condition ="Battle-Scared",stattrak = "",firstname = "M4A1-S",secondname = "Master Piece"});
		pr.Add(new CSGOSkins() { prize = 17.09f, type = "Pink",condition ="Well-Worn",stattrak = "",firstname = "M4A1-S",secondname = "Master Piece"});
		pr.Add(new CSGOSkins() { prize = 22.46f, type = "Pink",condition ="Field-Tested",stattrak = "", firstname = "M4A1-S",secondname = "Master Piece"});
		pr.Add(new CSGOSkins() { prize = 35.49f, type = "Pink",condition ="Minimal Wear",stattrak = "",firstname = "M4A1-S",secondname = "Master Piece"});
		pr.Add(new CSGOSkins() { prize = 88.79f, type = "Pink",condition ="Factory New",stattrak = "",firstname = "M4A1-S",secondname = "Master Piece"});
		pr.Add(new CSGOSkins() { prize = 210.78f, type = "Pink",condition ="Battle-Scared",stattrak = "Souvenir", firstname = "M4A1-S",secondname = "Master Piece"});
		pr.Add(new CSGOSkins() { prize = 345.81f, type = "Pink",condition ="Well-Worn",stattrak = "Souvenir", firstname = "M4A1-S",secondname = "Master Piece"});
		pr.Add(new CSGOSkins() { prize = 500.27f, type = "Pink",condition ="Field-Tested",stattrak = "Souvenir", firstname = "M4A1-S",secondname = "Master Piece"});
		pr.Add(new CSGOSkins() { prize = 1000.50f, type = "Pink",condition ="Minimal Wear",stattrak = "Souvenir", firstname = "M4A1-S",secondname = "Master Piece"});
		pr.Add(new CSGOSkins() { prize = 1700.98f, type = "Pink",condition ="Factory New",stattrak = "Souvenir", firstname = "M4A1-S",secondname = "Master Piece"});
	}
}

