﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class HuntsmanDatabase : MonoBehaviour {
	public List<CSGOSkins> h = new List<CSGOSkins> ();

	void Start () {
		h.Add(new CSGOSkins() { prize = 0.09f, type = "Blue",condition ="Battle-Scared",stattrak = "",firstname = "CZ75-Auto",secondname = "Twist"});
		h.Add(new CSGOSkins() { prize = 0.08f, type = "Blue",condition ="Well-Worn",stattrak = "",firstname = "CZ75-Auto",secondname = "Twist"});
		h.Add(new CSGOSkins() { prize = 0.09f, type = "Blue",condition ="Field-Tested",stattrak = "", firstname = "CZ75-Auto",secondname = "Twist"});
		h.Add(new CSGOSkins() { prize = 0.1f, type = "Blue",condition ="Minimal Wear",stattrak = "",firstname = "CZ75-Auto",secondname = "Twist"});
		h.Add(new CSGOSkins() { prize = 0.27f, type = "Blue",condition ="Factory New",stattrak = "",firstname = "CZ75-Auto",secondname = "Twist"});
		h.Add(new CSGOSkins() { prize = 0.2f, type = "Blue",condition ="Battle-Scared",stattrak = "StatTrak", firstname = "CZ75-Auto",secondname = "Twist"});
		h.Add(new CSGOSkins() { prize = 0.19f, type = "Blue",condition ="Well-Worn",stattrak = "StatTrak", firstname = "CZ75-Auto",secondname = "Twist"});
		h.Add(new CSGOSkins() { prize = 0.21f, type = "Blue",condition ="Field-Tested",stattrak = "StatTrak", firstname = "CZ75-Auto",secondname = "Twist"});
		h.Add(new CSGOSkins() { prize = 0.35f, type = "Blue",condition ="Minimal Wear",stattrak = "StatTrak", firstname = "CZ75-Auto",secondname = "Twist"});
		h.Add(new CSGOSkins() { prize = 1.15f, type = "Blue",condition ="Factory New",stattrak = "StatTrak", firstname = "CZ75-Auto",secondname = "Twist"});
		h.Add(new CSGOSkins() { prize = 0.47f, type = "Blue",condition ="Field-Tested",stattrak = "", firstname = "P90",secondname = "Module"});
		h.Add(new CSGOSkins() { prize = 0.28f, type = "Blue",condition ="Minimal Wear",stattrak = "",firstname = "P90",secondname = "Module"});
		h.Add(new CSGOSkins() { prize = 0.41f, type = "Blue",condition ="Factory New",stattrak = "",firstname = "P90",secondname = "Module"});
		h.Add(new CSGOSkins() { prize = 0.95f, type = "Blue",condition ="Field-Tested",stattrak = "StatTrak", firstname = "P90",secondname = "Module"});
		h.Add(new CSGOSkins() { prize = 0.94f, type = "Blue",condition ="Minimal Wear",stattrak = "StatTrak", firstname = "P90",secondname = "Module"});
		h.Add(new CSGOSkins() { prize = 1.34f, type = "Blue",condition ="Factory New",stattrak = "StatTrak", firstname = "P90",secondname = "Module"});
		h.Add(new CSGOSkins() { prize = 0.12f, type = "Blue",condition ="Battle-Scared",stattrak = "",firstname = "P2000",secondname = "Pulse"});
		h.Add(new CSGOSkins() { prize = 0.17f, type = "Blue",condition ="Well-Worn",stattrak = "",firstname = "P2000",secondname = "Pulse"});
		h.Add(new CSGOSkins() { prize = 0.11f, type = "Blue",condition ="Field-Tested",stattrak = "", firstname = "P2000",secondname = "Pulse"});
		h.Add(new CSGOSkins() { prize = 0.15f, type = "Blue",condition ="Minimal Wear",stattrak = "",firstname = "P2000",secondname = "Pulse"});
		h.Add(new CSGOSkins() { prize = 0.22f, type = "Blue",condition ="Factory New",stattrak = "",firstname = "P2000",secondname = "Pulse"});
		h.Add(new CSGOSkins() { prize = 0.28f, type = "Blue",condition ="Battle-Scared",stattrak = "StatTrak", firstname = "P2000",secondname = "Pulse"});
		h.Add(new CSGOSkins() { prize = 0.59f, type = "Blue",condition ="Well-Worn",stattrak = "StatTrak", firstname = "P2000",secondname = "Pulse"});
		h.Add(new CSGOSkins() { prize = 0.28f, type = "Blue",condition ="Field-Tested",stattrak = "StatTrak", firstname = "P2000",secondname = "Pulse"});
		h.Add(new CSGOSkins() { prize = 0.56f, type = "Blue",condition ="Minimal Wear",stattrak = "StatTrak", firstname = "P2000",secondname = "Pulse"});
		h.Add(new CSGOSkins() { prize = 1.08f, type = "Blue",condition ="Factory New",stattrak = "StatTrak", firstname = "P2000",secondname = "Pulse"});
		h.Add(new CSGOSkins() { prize = 0.23f, type = "Blue",condition ="Battle-Scared",stattrak = "",firstname = "Tec-9",secondname = "Isaac"});
		h.Add(new CSGOSkins() { prize = 0.28f, type = "Blue",condition ="Well-Worn",stattrak = "",firstname = "Tec-9",secondname = "Isaac"});
		h.Add(new CSGOSkins() { prize = 0.32f, type = "Blue",condition ="Field-Tested",stattrak = "", firstname = "Tec-9",secondname = "Isaac"});
		h.Add(new CSGOSkins() { prize = 0.56f, type = "Blue",condition ="Minimal Wear",stattrak = "",firstname = "Tec-9",secondname = "Isaac"});
		h.Add(new CSGOSkins() { prize = 2.42f, type = "Blue",condition ="Factory New",stattrak = "",firstname = "Tec-9",secondname = "Isaac"});
		h.Add(new CSGOSkins() { prize = 0.69f, type = "Blue",condition ="Battle-Scared",stattrak = "StatTrak", firstname = "Tec-9",secondname = "Isaac"});
		h.Add(new CSGOSkins() { prize = 0.78f, type = "Blue",condition ="Well-Worn",stattrak = "StatTrak", firstname = "Tec-9",secondname = "Isaac"});
		h.Add(new CSGOSkins() { prize = 1.11f, type = "Blue",condition ="Field-Tested",stattrak = "StatTrak", firstname = "Tec-9",secondname = "Isaac"});
		h.Add(new CSGOSkins() { prize = 1.94f, type = "Blue",condition ="Minimal Wear",stattrak = "StatTrak", firstname = "Tec-9",secondname = "Isaac"});
		h.Add(new CSGOSkins() { prize = 10.8f, type = "Blue",condition ="Factory New",stattrak = "StatTrak", firstname = "Tec-9",secondname = "Isaac"});
		h.Add(new CSGOSkins() { prize = 0.15f, type = "Blue",condition ="Battle-Scared",stattrak = "",firstname = "SSG 08",secondname = "Slashed"});
		h.Add(new CSGOSkins() { prize = 0.17f, type = "Blue",condition ="Well-Worn",stattrak = "",firstname = "SSG 08",secondname = "Slashed"});
		h.Add(new CSGOSkins() { prize = 0.19f, type = "Blue",condition ="Field-Tested",stattrak = "", firstname = "SSG 08",secondname = "Slashed"});
		h.Add(new CSGOSkins() { prize = 0.43f, type = "Blue",condition ="Battle-Scared",stattrak = "StatTrak", firstname = "SSG 08",secondname = "Slashed"});
		h.Add(new CSGOSkins() { prize = 0.48f, type = "Blue",condition ="Well-Worn",stattrak = "StatTrak", firstname = "SSG 08",secondname = "Slashed"});
		h.Add(new CSGOSkins() { prize = 0.59f, type = "Blue",condition ="Field-Tested",stattrak = "StatTrak", firstname = "SSG 08",secondname = "Slashed"});
		h.Add(new CSGOSkins() { prize = 0.1f, type = "Blue",condition ="Battle-Scared",stattrak = "",firstname = "Galil AR",secondname = "Kami"});
		h.Add(new CSGOSkins() { prize = 0.18f, type = "Blue",condition ="Well-Worn",stattrak = "",firstname = "Galil AR",secondname = "Kami"});
		h.Add(new CSGOSkins() { prize = 0.09f, type = "Blue",condition ="Field-Tested",stattrak = "", firstname = "Galil AR",secondname = "Kami"});
		h.Add(new CSGOSkins() { prize = 0.15f, type = "Blue",condition ="Minimal Wear",stattrak = "",firstname = "Galil AR",secondname = "Kami"});
		h.Add(new CSGOSkins() { prize = 0.21f, type = "Blue",condition ="Factory New",stattrak = "",firstname = "Galil AR",secondname = "Kami"});
		h.Add(new CSGOSkins() { prize = 0.24f, type = "Blue",condition ="Battle-Scared",stattrak = "StatTrak", firstname = "Galil AR",secondname = "Kami"});
		h.Add(new CSGOSkins() { prize = 0.35f, type = "Blue",condition ="Well-Worn",stattrak = "StatTrak", firstname = "Galil AR",secondname = "Kami"});
		h.Add(new CSGOSkins() { prize = 0.25f, type = "Blue",condition ="Field-Tested",stattrak = "StatTrak", firstname = "Galil AR",secondname = "Kami"});
		h.Add(new CSGOSkins() { prize = 0.46f, type = "Blue",condition ="Minimal Wear",stattrak = "StatTrak", firstname = "Galil AR",secondname = "Kami"});
		h.Add(new CSGOSkins() { prize = 0.9f, type = "Blue",condition ="Factory New",stattrak = "StatTrak", firstname = "Galil AR",secondname = "Kami"});
		h.Add(new CSGOSkins() { prize = 1.27f, type = "Purple",condition ="Battle-Scared",stattrak = "",firstname = "MAC-10",secondname = "Tatter"});
		h.Add(new CSGOSkins() { prize = 0.59f, type = "Purple",condition ="Well-Worn",stattrak = "",firstname = "MAC-10",secondname = "Tatter"});
		h.Add(new CSGOSkins() { prize = 0.51f, type = "Purple",condition ="Field-Tested",stattrak = "", firstname = "MAC-10",secondname = "Tatter"});
		h.Add(new CSGOSkins() { prize = 0.57f, type = "Purple",condition ="Minimal Wear",stattrak = "",firstname = "MAC-10",secondname = "Tatter"});
		h.Add(new CSGOSkins() { prize = 0.89f, type = "Purple",condition ="Factory New",stattrak = "",firstname = "MAC-10",secondname = "Tatter"});
		h.Add(new CSGOSkins() { prize = 5.24f, type = "Purple",condition ="Battle-Scared",stattrak = "StatTrak", firstname = "MAC-10",secondname = "Tatter"});
		h.Add(new CSGOSkins() { prize = 1.5f, type = "Purple",condition ="Well-Worn",stattrak = "StatTrak", firstname = "MAC-10",secondname = "Tatter"});
		h.Add(new CSGOSkins() { prize = 1.6f, type = "Purple",condition ="Field-Tested",stattrak = "StatTrak", firstname = "MAC-10",secondname = "Tatter"});
		h.Add(new CSGOSkins() { prize = 2.47f, type = "Purple",condition ="Minimal Wear",stattrak = "StatTrak", firstname = "MAC-10",secondname = "Tatter"});
		h.Add(new CSGOSkins() { prize = 3.51f, type = "Purple",condition ="Factory New",stattrak = "StatTrak", firstname = "MAC-10",secondname = "Tatter"});
		h.Add(new CSGOSkins() { prize = 0.84f, type = "Purple",condition ="Battle-Scared",stattrak = "",firstname = "AUG",secondname = "Torque"});
		h.Add(new CSGOSkins() { prize = 0.57f, type = "Purple",condition ="Well-Worn",stattrak = "",firstname = "AUG",secondname = "Torque"});
		h.Add(new CSGOSkins() { prize = 0.54f, type = "Purple",condition ="Field-Tested",stattrak = "", firstname = "AUG",secondname = "Torque"});
		h.Add(new CSGOSkins() { prize = 0.65f, type = "Purple",condition ="Minimal Wear",stattrak = "",firstname = "AUG",secondname = "Torque"});
		h.Add(new CSGOSkins() { prize = 0.96f, type = "Purple",condition ="Factory New",stattrak = "",firstname = "AUG",secondname = "Torque"});
		h.Add(new CSGOSkins() { prize = 2.49f, type = "Purple",condition ="Battle-Scared",stattrak = "StatTrak", firstname = "AUG",secondname = "Torque"});
		h.Add(new CSGOSkins() { prize = 1.55f, type = "Purple",condition ="Well-Worn",stattrak = "StatTrak", firstname = "AUG",secondname = "Torque"});
		h.Add(new CSGOSkins() { prize = 1.53f, type = "Purple",condition ="Field-Tested",stattrak = "StatTrak", firstname = "AUG",secondname = "Torque"});
		h.Add(new CSGOSkins() { prize = 2.2f, type = "Purple",condition ="Minimal Wear",stattrak = "StatTrak", firstname = "AUG",secondname = "Torque"});
		h.Add(new CSGOSkins() { prize = 3.74f, type = "Purple",condition ="Factory New",stattrak = "StatTrak", firstname = "AUG",secondname = "Torque"});
		h.Add(new CSGOSkins() { prize = 0.97f, type = "Purple",condition ="Battle-Scared",stattrak = "",firstname = "PP-Bizon",secondname = "Antique"});
		h.Add(new CSGOSkins() { prize = 0.56f, type = "Purple",condition ="Well-Worn",stattrak = "",firstname = "PP-Bizon",secondname = "Antique"});
		h.Add(new CSGOSkins() { prize = 0.53f, type = "Purple",condition ="Field-Tested",stattrak = "", firstname = "PP-Bizon",secondname = "Antique"});
		h.Add(new CSGOSkins() { prize = 0.56f, type = "Purple",condition ="Minimal Wear",stattrak = "",firstname = "PP-Bizon",secondname = "Antique"});
		h.Add(new CSGOSkins() { prize = 1.1f, type = "Purple",condition ="Factory New",stattrak = "",firstname = "PP-Bizon",secondname = "Antique"});
		h.Add(new CSGOSkins() { prize = 2.24f, type = "Purple",condition ="Battle-Scared",stattrak = "StatTrak", firstname = "PP-Bizon",secondname = "Antique"});
		h.Add(new CSGOSkins() { prize = 1.8f, type = "Purple",condition ="Well-Worn",stattrak = "StatTrak", firstname = "PP-Bizon",secondname = "Antique"});
		h.Add(new CSGOSkins() { prize = 1.45f, type = "Purple",condition ="Field-Tested",stattrak = "StatTrak", firstname = "PP-Bizon",secondname = "Antique"});
		h.Add(new CSGOSkins() { prize = 2.08f, type = "Purple",condition ="Minimal Wear",stattrak = "StatTrak", firstname = "PP-Bizon",secondname = "Antique"});
		h.Add(new CSGOSkins() { prize = 4.01f, type = "Purple",condition ="Factory New",stattrak = "StatTrak", firstname = "PP-Bizon",secondname = "Antique"});
		h.Add(new CSGOSkins() { prize = 0.58f, type = "Purple",condition ="Battle-Scared",stattrak = "",firstname = "XM1014",secondname = "Heaven Guard"});
		h.Add(new CSGOSkins() { prize = 0.56f, type = "Purple",condition ="Well-Worn",stattrak = "",firstname = "XM1014",secondname = "Heaven Guard"});
		h.Add(new CSGOSkins() { prize = 0.47f, type = "Purple",condition ="Field-Tested",stattrak = "", firstname = "XM1014",secondname = "Heaven Guard"});
		h.Add(new CSGOSkins() { prize = 0.63f, type = "Purple",condition ="Minimal Wear",stattrak = "",firstname = "XM1014",secondname = "Heaven Guard"});
		h.Add(new CSGOSkins() { prize = 0.99f, type = "Purple",condition ="Factory New",stattrak = "",firstname = "XM1014",secondname = "Heaven Guard"});
		h.Add(new CSGOSkins() { prize = 1.91f, type = "Purple",condition ="Battle-Scared",stattrak = "StatTrak", firstname = "XM1014",secondname = "Heaven Guard"});
		h.Add(new CSGOSkins() { prize = 1.94f, type = "Purple",condition ="Well-Worn",stattrak = "StatTrak", firstname = "XM1014",secondname = "Heaven Guard"});
		h.Add(new CSGOSkins() { prize = 1.63f, type = "Purple",condition ="Field-Tested",stattrak = "StatTrak", firstname = "XM1014",secondname = "Heaven Guard"});
		h.Add(new CSGOSkins() { prize = 2.19f, type = "Purple",condition ="Minimal Wear",stattrak = "StatTrak", firstname = "XM1014",secondname = "Heaven Guard"});
		h.Add(new CSGOSkins() { prize = 6.33f, type = "Purple",condition ="Factory New",stattrak = "StatTrak", firstname = "XM1014",secondname = "Heaven Guard"});
		h.Add(new CSGOSkins() { prize = 4.83f, type = "Pink",condition ="Well-Worn",stattrak = "",firstname = "USP-S",secondname = "Caiman"});
		h.Add(new CSGOSkins() { prize = 3.76f, type = "Pink",condition ="Field-Tested",stattrak = "", firstname = "USP-S",secondname = "Caiman"});
		h.Add(new CSGOSkins() { prize = 4.13f, type = "Pink",condition ="Minimal Wear",stattrak = "",firstname = "USP-S",secondname = "Caiman"});
		h.Add(new CSGOSkins() { prize = 5.26f, type = "Pink",condition ="Factory New",stattrak = "",firstname = "USP-S",secondname = "Caiman"});
		h.Add(new CSGOSkins() { prize = 19.5f, type = "Pink",condition ="Well-Worn",stattrak = "StatTrak", firstname = "USP-S",secondname = "Caiman"});
		h.Add(new CSGOSkins() { prize = 8.49f, type = "Pink",condition ="Field-Tested",stattrak = "StatTrak", firstname = "USP-S",secondname = "Caiman"});
		h.Add(new CSGOSkins() { prize = 12.7f, type = "Pink",condition ="Minimal Wear",stattrak = "StatTrak", firstname = "USP-S",secondname = "Caiman"});
		h.Add(new CSGOSkins() { prize = 16.7f, type = "Pink",condition ="Factory New",stattrak = "StatTrak", firstname = "USP-S",secondname = "Caiman"});
		h.Add(new CSGOSkins() { prize = 2.37f, type = "Pink",condition ="Battle-Scared",stattrak = "",firstname = "M4A1-S",secondname = "Atomic Alloy"});
		h.Add(new CSGOSkins() { prize = 2.84f, type = "Pink",condition ="Well-Worn",stattrak = "",firstname = "M4A1-S",secondname = "Atomic Alloy"});
		h.Add(new CSGOSkins() { prize = 2.51f, type = "Pink",condition ="Field-Tested",stattrak = "", firstname = "M4A1-S",secondname = "Atomic Alloy"});
		h.Add(new CSGOSkins() { prize = 3.9f, type = "Pink",condition ="Minimal Wear",stattrak = "",firstname = "M4A1-S",secondname = "Atomic Alloy"});
		h.Add(new CSGOSkins() { prize = 9.06f, type = "Pink",condition ="Factory New",stattrak = "",firstname = "M4A1-S",secondname = "Atomic Alloy"});
		h.Add(new CSGOSkins() { prize = 7.85f, type = "Pink",condition ="Battle-Scared",stattrak = "StatTrak", firstname = "M4A1-S",secondname = "Atomic Alloy"});
		h.Add(new CSGOSkins() { prize = 8.55f, type = "Pink",condition ="Well-Worn",stattrak = "StatTrak", firstname = "M4A1-S",secondname = "Atomic Alloy"});
		h.Add(new CSGOSkins() { prize = 8.24f, type = "Pink",condition ="Field-Tested",stattrak = "StatTrak", firstname = "M4A1-S",secondname = "Atomic Alloy"});
		h.Add(new CSGOSkins() { prize = 14.0f, type = "Pink",condition ="Minimal Wear",stattrak = "StatTrak", firstname = "M4A1-S",secondname = "Atomic Alloy"});
		h.Add(new CSGOSkins() { prize = 30.8f, type = "Pink",condition ="Factory New",stattrak = "StatTrak", firstname = "M4A1-S",secondname = "Atomic Alloy"});
		h.Add(new CSGOSkins() { prize = 2.97f, type = "Pink",condition ="Battle-Scared",stattrak = "",firstname = "SCAR-20",secondname = "Cyrex"});
		h.Add(new CSGOSkins() { prize = 3.09f, type = "Pink",condition ="Well-Worn",stattrak = "",firstname = "SCAR-20",secondname = "Cyrex"});
		h.Add(new CSGOSkins() { prize = 1.95f, type = "Pink",condition ="Field-Tested",stattrak = "", firstname = "SCAR-20",secondname = "Cyrex"});
		h.Add(new CSGOSkins() { prize = 2.57f, type = "Pink",condition ="Minimal Wear",stattrak = "",firstname = "SCAR-20",secondname = "Cyrex"});
		h.Add(new CSGOSkins() { prize = 3.97f, type = "Pink",condition ="Factory New",stattrak = "",firstname = "SCAR-20",secondname = "Cyrex"});
		h.Add(new CSGOSkins() { prize = 11.7f, type = "Pink",condition ="Battle-Scared",stattrak = "StatTrak", firstname = "SCAR-20",secondname = "Cyrex"});
		h.Add(new CSGOSkins() { prize = 9.76f, type = "Pink",condition ="Well-Worn",stattrak = "StatTrak", firstname = "SCAR-20",secondname = "Cyrex"});
		h.Add(new CSGOSkins() { prize = 7.44f, type = "Pink",condition ="Field-Tested",stattrak = "StatTrak", firstname = "SCAR-20",secondname = "Cyrex"});
		h.Add(new CSGOSkins() { prize = 10.1f, type = "Pink",condition ="Minimal Wear",stattrak = "StatTrak", firstname = "SCAR-20",secondname = "Cyrex"});
		h.Add(new CSGOSkins() { prize = 16.8f, type = "Pink",condition ="Factory New",stattrak = "StatTrak", firstname = "SCAR-20",secondname = "Cyrex"});
		h.Add(new CSGOSkins() { prize = 1.61f, type = "Red",condition ="Battle-Scared",stattrak = "",firstname = "M4A4",secondname = "Desert-Strike"});
		h.Add(new CSGOSkins() { prize = 2.29f, type = "Red",condition ="Well-Worn",stattrak = "",firstname = "M4A4",secondname = "Desert-Strike"});
		h.Add(new CSGOSkins() { prize = 1.7f, type = "Red",condition ="Field-Tested",stattrak = "", firstname = "M4A4",secondname = "Desert-Strike"});
		h.Add(new CSGOSkins() { prize = 3.07f, type = "Red",condition ="Minimal Wear",stattrak = "",firstname = "M4A4",secondname = "Desert-Strike"});
		h.Add(new CSGOSkins() { prize = 4.51f, type = "Red",condition ="Factory New",stattrak = "",firstname = "M4A4",secondname = "Desert-Strike"});
		h.Add(new CSGOSkins() { prize = 6.32f, type = "Red",condition ="Battle-Scared",stattrak = "StatTrak", firstname = "M4A4",secondname = "Desert-Strike"});
		h.Add(new CSGOSkins() { prize = 11.4f, type = "Red",condition ="Well-Worn",stattrak = "StatTrak", firstname = "M4A4",secondname = "Desert-Strike"});
		h.Add(new CSGOSkins() { prize = 6.94f, type = "Red",condition ="Field-Tested",stattrak = "StatTrak", firstname = "M4A4",secondname = "Desert-Strike"});
		h.Add(new CSGOSkins() { prize = 13.5f, type = "Red",condition ="Minimal Wear",stattrak = "StatTrak", firstname = "M4A4",secondname = "Desert-Strike"});
		h.Add(new CSGOSkins() { prize = 25.3f, type = "Red",condition ="Factory New",stattrak = "StatTrak", firstname = "M4A4",secondname = "Desert-Strike"});
		h.Add(new CSGOSkins() { prize = 9.37f, type = "Red",condition ="Battle-Scared",stattrak = "",firstname = "AK-47",secondname = "Vulcan"});
		h.Add(new CSGOSkins() { prize = 15.3f, type = "Red",condition ="Well-Worn",stattrak = "",firstname = "AK-47",secondname = "Vulcan"});
		h.Add(new CSGOSkins() { prize = 16.3f, type = "Red",condition ="Field-Tested",stattrak = "", firstname = "AK-47",secondname = "Vulcan"});
		h.Add(new CSGOSkins() { prize = 29.1f, type = "Red",condition ="Minimal Wear",stattrak = "",firstname = "AK-47",secondname = "Vulcan"});
		h.Add(new CSGOSkins() { prize = 47.1f, type = "Red",condition ="Factory New",stattrak = "",firstname = "AK-47",secondname = "Vulcan"});
		h.Add(new CSGOSkins() { prize = 24.8f, type = "Red",condition ="Battle-Scared",stattrak = "StatTrak", firstname = "AK-47",secondname = "Vulcan"});
		h.Add(new CSGOSkins() { prize = 54.3f, type = "Red",condition ="Well-Worn",stattrak = "StatTrak", firstname = "AK-47",secondname = "Vulcan"});
		h.Add(new CSGOSkins() { prize = 57.0f, type = "Red",condition ="Field-Tested",stattrak = "StatTrak", firstname = "AK-47",secondname = "Vulcan"});
		h.Add(new CSGOSkins() { prize = 137, type = "Red",condition ="Minimal Wear",stattrak = "StatTrak", firstname = "AK-47",secondname = "Vulcan"});
		h.Add(new CSGOSkins() { prize = 290, type = "Red",condition ="Factory New",stattrak = "StatTrak", firstname = "AK-47",secondname = "Vulcan"});
		h.Add(new CSGOSkins() { prize = 775, type = "Rare",condition ="Factory New",stattrak = "",firstname = "Huntsman",secondname = "Crimson Web"});
		h.Add(new CSGOSkins() { prize = 135, type = "Rare",condition ="Field-Tested",stattrak = "StatTrak",firstname = "Huntsman",secondname = "Crimson Web"});
		h.Add(new CSGOSkins() { prize = 219, type = "Rare",condition ="Minimal Wear",stattrak = "",firstname = "Huntsman",secondname = "Fade"});
		h.Add(new CSGOSkins() { prize = 244, type = "Rare",condition ="Factory New",stattrak = "StatTrak",firstname = "Huntsman",secondname = "Fade"});
		h.Add(new CSGOSkins() { prize = 44, type = "Rare",condition ="Well-Worn",stattrak = "",firstname = "Huntsman",secondname = "Urban Masked"});
		h.Add(new CSGOSkins() { prize = 56, type = "Rare",condition ="Field-Tested",stattrak = "StatTrak",firstname = "Huntsman",secondname = "Urban Masked"});
		h.Add(new CSGOSkins() { prize = 89, type = "Rare",condition ="Field-Tested",stattrak = "",firstname = "Huntsman",secondname = "Case Hardened"});
		h.Add(new CSGOSkins() { prize = 184, type = "Rare",condition ="Minimal Wear",stattrak = "StatTrak",firstname = "Huntsman",secondname = "Case Hardened"});
		h.Add(new CSGOSkins() { prize = 51, type = "Rare",condition ="Battle-Scared",stattrak = "",firstname = "Huntsman",secondname = "Boreal Forest"});
		h.Add(new CSGOSkins() { prize = 80, type = "Rare",condition ="Battle-Scared",stattrak = "StatTrak",firstname = "Huntsman",secondname = "Boreal Forest"});
		h.Add(new CSGOSkins() { prize = 50, type = "Rare",condition ="Field-Tested",stattrak = "",firstname = "Huntsman",secondname = "Scorched"});
		h.Add(new CSGOSkins() { prize = 68, type = "Rare",condition ="Battle-Scared",stattrak = "StatTrak",firstname = "Huntsman",secondname = "Scorched"});
		h.Add(new CSGOSkins() { prize = 137, type = "Rare",condition ="Minimal Wear",stattrak = "",firstname = "Huntsman",secondname = "Slaughter"});
		h.Add(new CSGOSkins() { prize = 315, type = "Rare",condition ="Factory New",stattrak = "StatTrak",firstname = "Huntsman",secondname = "Slaughter"});
		h.Add(new CSGOSkins() { prize = 61, type = "Rare",condition ="Field-Tested",stattrak = "",firstname = "Huntsman",secondname = "Stained"});
		h.Add(new CSGOSkins() { prize = 97, type = "Rare",condition ="Minimal Wear",stattrak = "StatTrak",firstname = "Huntsman",secondname = "Stained"});
	}
}
