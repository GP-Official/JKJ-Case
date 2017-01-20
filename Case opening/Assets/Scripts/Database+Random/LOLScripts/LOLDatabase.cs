using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class LOLDatabase : MonoBehaviour {
	public List<LOLSkins> skins = new List<LOLSkins>();

	void Start () {
		#region skins
		skins.Add(new LOLSkins() { prize = 975, sellprize = 0, name = "Aatrox" }); 
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Abyssal Nautilus" }); 
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Academy Ahri" }); 
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Academy Darius" }); 
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Academy Ekko" });
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Academy Vladimir" });
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Ace of Spades Ezreal" });
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Acolyte Lee Sin" }); 
		skins.Add(new LOLSkins() { prize = 1820, sellprize = 364, name = "Aether Wing Kayle" }); 
		skins.Add(new LOLSkins() { prize = 880, sellprize = 0, name = "Ahri" }); 
		skins.Add(new LOLSkins() { prize = 790, sellprize = 0, name = "Akali" }); 
		skins.Add(new LOLSkins() { prize = 585, sellprize = 0, name = "Alistar" }); 
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Amethyst Ashe" }); 
		skins.Add(new LOLSkins() { prize = 585, sellprize = 0, name = "Amumu" }); 
		skins.Add(new LOLSkins() { prize = 790, sellprize = 0, name = "Anivia" }); 
		skins.Add(new LOLSkins() { prize = 260, sellprize = 0, name = "Annie" }); 
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Apocalyptic Brand" });
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Arcade Ahri" }); 
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Arcade Corki" }); 
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Arcade Ezreal" });
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Arcade Hecarim" }); 
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Arcade Miss Fortune" });
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Arcade Riven" }); 
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Arcade Sona" }); 
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Archduke Nasus" }); 
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Arclight Varus" });
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Arclight Vayne" }); 
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Arclight Velkoz" }); 
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Arctic Ops Kennen" }); 
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Arctic Ops Varus" }); 
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Arctic Warfare Caitlyn" }); 
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Aristocrat Vayne" }); 
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Armor of the Fifth Age Taric" }); 
		skins.Add(new LOLSkins() { prize = 585, sellprize = 0, name = "Ashe" }); 
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Ashen Lord Aurelion Sol" });
		skins.Add(new LOLSkins() { prize = 390, sellprize = 78, name = "Assassin Master Yi" });
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Astronaut Teemo" }); 
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "AstroNautilus" }); 
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Asylum Shaco" }); 
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Atalantean Syndra" }); 
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Atlantean Fizz" }); 
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Augmented Singed" }); 
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Aurelion Sol" }); 
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Aviator Irelia" }); 
		skins.Add(new LOLSkins() { prize = 975, sellprize = 0, name = "Azir" }); 
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Bandit Sivir" }); 
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Bandito Fiddlesticks" }); 
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Barbarian Sion" }); 
		skins.Add(new LOLSkins() { prize = 975, sellprize = 0, name = "Bard" });
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Battle Boss Blitzcrank" });
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Battle Bunny Riven" }); 
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Battle Regalia Poppy" }); 
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Battleborn Kayle" }); 
		skins.Add(new LOLSkins() { prize = 1820, sellprize = 364, name = "Battlecast Alpha Skarner" });
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Battlecast KogMaw" }); 
		skins.Add(new LOLSkins() { prize = 1820, sellprize = 364, name = "Battlecast Prime ChoGath" }); 
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Battlecast Urgot" });
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Battlecast Velkoz" });
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Battlecast Xerath" }); 
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Bear Cavalry Sejuani" });
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Beast Hunter Draven" });
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Beast Hunter Sejuani" });
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Beast Hunter Tryndamere" }); 
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Bilgewater Katarina" });
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Bilgewater Swain" }); 
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Bioforge Darius" }); 
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Bird of Prey Anivia" }); 
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Bittersweet Lulu" }); 
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Black Belt Udyr" }); 
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Black Scourge Singed" }); 
		skins.Add(new LOLSkins() { prize = 1820, sellprize = 364, name = "Blackfrost Anivia" }); 
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Blackthorn Morgana" }); 
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Blade Quenn Lissandra" }); 
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Bladecraft Orianna" }); 
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Blast Zone Heimerdinger" }); 
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Blight Crystal Varus" }); 
		skins.Add(new LOLSkins() { prize = 790, sellprize = 0, name = "Blitzcrank" }); 
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Blood Knight Hecarim" }); 
		skins.Add(new LOLSkins() { prize = 1820, sellprize = 364, name = "Blood Lord Vladimir" }); 
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Blood Moon Akali" }); 
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Blood Moon Elise" }); 
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Blood Moon Kalista" }); 
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Blood Moon Kennen" }); 
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Blood Moon Shen" }); 
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Blood Moon Thresh" }); 
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Blood Moon Yasuo" }); 
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Blood Moon Zilean" }); 
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Bloodfury Renekton" }); 
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Bloodstone Lissandra" }); 
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Bloodstone Taric" }); 
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Boneclaw Shyvana" }); 
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Boom Boom Blitzcrank" }); 
		skins.Add(new LOLSkins() { prize = 880, sellprize = 0, name = "Brand" }); 
		skins.Add(new LOLSkins() { prize = 975, sellprize = 0, name = "Braum" }); 
		skins.Add(new LOLSkins() { prize = 1820, sellprize = 364, name = "Brolaf" }); 
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Buccaneer Tristana" }); 
		skins.Add(new LOLSkins() { prize = 880, sellprize = 0, name = "Caitlyn" }); 
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Captain Fortune" }); 
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Captain Volibear" }); 
		skins.Add(new LOLSkins() { prize = 880, sellprize = 0, name = "Cassiopeia" }); 
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Celestine Soraka" }); 
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Commando Galio" }); 
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Commando Garen" }); 
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Commando Jarvan IV" }); 
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Commando Lux" }); 
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Commando Xin Zhao" }); 
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Constable Trundle" }); 
		skins.Add(new LOLSkins() { prize = 790, sellprize = 0, name = "Corki" }); 
		skins.Add(new LOLSkins() { prize = 1820, sellprize = 364, name = "Corporate Mundo" }); 
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Corsair Quinn" }); 
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Cosmic Reaver Kassadin" }); 
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Cottontail Fizz" }); 
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Cottontail Teemo" }); 
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Cowgirl Miss Fortune" }); 
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Creator Viktor" }); 
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Crimson Elite Riven" }); 
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Crimson Elite Talon" }); 
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Cryocore Brand" }); 
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Cursed Revenant Nocturne" });
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Cutpurse Twisted Fate" }); 
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Cutthroat Graves" }); 
		skins.Add(new LOLSkins() { prize = 880, sellprize = 0, name = "Darius" }); 
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Dark Crystal Ryze" });
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Dark Flame Shyvana" });
		skins.Add(new LOLSkins() { prize = 1820, sellprize = 364, name = "Dark Star Thresh" }); 
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Dark Valkyre Diana" }); 
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Darkforge Jarvan IV" }); 
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Darkride Sejuani" });
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Death Blossom Elise" }); 
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Death Blossom KhaZix" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Debonair Ezreal" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Debonair Galio" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Debonair Jayce" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Debonair Vi" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Deep Sea KogMaw" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Deep Sea Nami" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Deep Terror Thresh" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Defender Leona" }); //people [0] 
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Definitely Not Udyr" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Definitely Not Velkoz" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Demolisher Nunu" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Demon Vi" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1820, sellprize = 364, name = "Demonblade Tryndamere" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Desperada Cassiopeia" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 0, name = "Diana" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Dino Gnar" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Divine Soraka" }); //people [0]
		skins.Add(new LOLSkins() { prize = 3250, sellprize = 650, name = "DJ Sona" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Djinn Malzahar" }); //people [0]
		skins.Add(new LOLSkins() { prize = 585, sellprize = 0, name = "Dr. Mundo" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Dragon Fist Lee Sin" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Dragon Trainer Lulu" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1820, sellprize = 364, name = "Dragon Trainer Tristana" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Dragonblade Talon" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Dragonslayer Braum" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Dragonslayer Jarvan IV" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Dragonslayer Pantheon" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Dragonslayer Vayne" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Dragonwing Corki" }); //people [0]
		skins.Add(new LOLSkins() { prize = 880, sellprize = 0, name = "Draven" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Dreadknight Nasus" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Dryad Sorka" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1820, sellprize = 364, name = "Dunkmaster Darius" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Dynasty Ahri" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Earthrune Skarner" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 0, name = "Ekko" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "El León Gnar" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "El Macho Mundo" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "El Rayo Volibear" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "El Tigre Braum" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Elderwood Hecarim" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Elderwood LeBlanc" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 0, name = "Elise" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Emumu" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Enchanted Galio" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Eternum Nocturne" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Eternum RekSai" }); //people [0]
		skins.Add(new LOLSkins() { prize = 585, sellprize = 0, name = "Evelynn" }); //people [0]
		skins.Add(new LOLSkins() { prize = 880, sellprize = 0, name = "Ezreal" }); //people [0]
		skins.Add(new LOLSkins() { prize = 585, sellprize = 0, name = "Fiddlesticks" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1820, sellprize = 364, name = "Final Boss Veigar" }); //people [0]
		skins.Add(new LOLSkins() { prize = 880, sellprize = 0, name = "Fiora" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Firecracker Jinx" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Firefang Warwick" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Fisherman Fizz" }); //people [0]
		skins.Add(new LOLSkins() { prize = 880, sellprize = 0, name = "Fizz" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1820, sellprize = 364, name = "Forecast Janna" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Forsaken Jayce" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Forsaken Olaf" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Foxfire Ahri" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Freljord Rammus" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Freljord Taliyah" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "French Maid Nidalee" }); //people [0]		
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Frost Quenn Janna" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Frostblade Irelia" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Frosted Ezreal" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Frostfire Annie" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Frozen Terror Nocturne" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Full Machine Viktor" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Full Metal Jayce" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Full Metal Pantheon" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Full Metal Rammus" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Galactic Azir" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Galactic Nasus" }); //people [0]
		skins.Add(new LOLSkins() { prize = 880, sellprize = 0, name = "Galio" }); //people [0]
		skins.Add(new LOLSkins() { prize = 790, sellprize = 0, name = "Gangplank" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Gangster Twitch" }); //people [0]
		skins.Add(new LOLSkins() { prize = 260, sellprize = 0, name = "Garen" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1820, sellprize = 364, name = "Gatekeeper Galio" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Genaral Wukong" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Gentleman Gnar" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1820, sellprize = 364, name = "Gentleman ChoGath" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Ghost Bride Morgana" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Giant Enemy Crabgot" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Glacial Malphite" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Gladiator Draven" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Glaive Warrior Pantheon" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 0, name = "Gnar" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Glaive Warrior Pantheon" }); //people [0]
		skins.Add(new LOLSkins() { prize = 390, sellprize = 78, name = "Golden Alistar" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Gothic Orianna" }); //people [0]
		skins.Add(new LOLSkins() { prize = 790, sellprize = 0, name = "Gragas" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Gragas Caskbreaker" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Gragas, Esq" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Gravelord Azir" }); //people [0]
		skins.Add(new LOLSkins() { prize = 880, sellprize = 0, name = "Graves" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Grim Reaper Karthus" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Groovy Zilean" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Grungy Nunu" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Guardian of the Sands KhaZix" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Guardian of the Sands Rammus" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Guardian of the Sands Skarner" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 195, name = "Guardian of the Sands Xerath" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Guqin Sona" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Harbinger Kassadin" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Haunted Zyra" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Hazmat Heimerdinger" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Headhunter Akali" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Headhunter Caitlyn" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Headhunter Master Yi" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Headhunter Nidalee" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Headhunter Rengar" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Hearthseeker Ashe" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Hearthseeker Orianna" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Hearthseeker Varus" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Hearthseeker Vayne" }); //people [0]
		skins.Add(new LOLSkins() { prize = 880, sellprize = 0, name = "Hecarim" }); //people [0]
		skins.Add(new LOLSkins() { prize = 790, sellprize = 0, name = "Heimerdinger" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Hextech Anivia" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Hextech Janna" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Hextech Singed" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Hextech Sion" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "High Command Katarina" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "High Noon Jhin" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "High Noon Twisted Fate" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "High Noon Yasuo" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Hillbilly Gragas" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Hired Gun Graves" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Hired Gun Lucian" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Hyena Warwick" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Chosen Master Yi" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Chrome Rammus" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "iBlitzcrank" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Ice Dreak Shyvana" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 0, name = "Illaoi" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Imperial Xin Zhao" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Infernal Alistar" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Infernal Diana" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Infernal Mordekaiser" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1820, sellprize = 364, name = "Infernal Nasus" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Ionia Master Yi" }); //people [0]
		skins.Add(new LOLSkins() { prize = 880, sellprize = 0, name = "Irelia" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Iron Inquisitor Kayle" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Iron Solari Leona" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Ironscale Shyvana" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Ironside Malphite" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Jack of Hearts Twisted Fate" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Jade Dragon Wukong" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Jade Fang Cassiopeia" }); //people [0]
		skins.Add(new LOLSkins() { prize = 585, sellprize = 0, name = "Janna" }); //people [0]
		skins.Add(new LOLSkins() { prize = 880, sellprize = 0, name = "Jarvan IV" }); //people [0]
		skins.Add(new LOLSkins() { prize = 565, sellprize = 0, name = "Jax" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Jaximus" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 0, name = "Jayce" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 0, name = "Jhin" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 0, name = "Jinx" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Junkyard Trundle" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Jurassic ChoGath" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Jurassic KogMaw" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Justicar Aatrox" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Justicar Syndra" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 0, name = "Kalista" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Karate Kennen" }); //people [0]
		skins.Add(new LOLSkins() { prize = 790, sellprize = 0, name = "Karma" }); //people [0]
		skins.Add(new LOLSkins() { prize = 790, sellprize = 0, name = "Kartus" }); //people [0]
		skins.Add(new LOLSkins() { prize = 790, sellprize = 0, name = "Kassadin" }); //people [0]
		skins.Add(new LOLSkins() { prize = 790, sellprize = 0, name = "Katarina" }); //people [0]
		skins.Add(new LOLSkins() { prize = 260, sellprize = 0, name = "Kayle" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Kenned M.D." }); //people [0]
		skins.Add(new LOLSkins() { prize = 880, sellprize = 0, name = "Kennen" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 0, name = "KhaZix" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 0, name = "Kindred" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "King of Clubs Mordekaiser" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "King Tryndamere" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 0, name = "Kled" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Knockout Lee Sin" }); //people [0]
		skins.Add(new LOLSkins() { prize = 880, sellprize = 0, name = "KogMaw" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Koi Nami" }); //people [0]
		skins.Add(new LOLSkins() { prize = 790, sellprize = 0, name = "LeBlanc" }); //people [0]
		skins.Add(new LOLSkins() { prize = 880, sellprize = 0, name = "Lee Sin" }); //people [0]
		skins.Add(new LOLSkins() { prize = 880, sellprize = 0, name = "Leona" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Leprechaun Veigar" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Lil Slugger Trundle" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Lion Dance KogMaw" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 0, name = "Lissandra" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Little Knight Amumu" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Loch Ness ChoGath" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Lord Darius" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Lord Mordekaiser" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 0, name = "Lucian" }); //people [0]
		skins.Add(new LOLSkins() { prize = 880, sellprize = 0, name = "Lulu" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Lumberjack Sion" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Lunar Goddness Diana" }); //people [0]
		skins.Add(new LOLSkins() { prize = 790, sellprize = 0, name = "Lux" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Mad Hatter Shaco" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Mad Scientist Ziggs" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Mafia Graves" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Mafia Jinx" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Mafia Miss Fortune" }); //people [0]
		skins.Add(new LOLSkins() { prize = 585, sellprize = 0, name = "Malphite" }); //people [0]
		skins.Add(new LOLSkins() { prize = 880, sellprize = 0, name = "Malzahar" }); //people [0]
		skins.Add(new LOLSkins() { prize = 880, sellprize = 0, name = "Maokai" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Marauder Alistar" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Marauder Ashe" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Marauder Olaf" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Marauder Warwick" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Marquis Vladimir" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Masked Shaco" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Master Arcanist Ziggs" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Master Chef Tahm Kench" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Master Yi" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Mecha Aatrox" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Mecha Malphite" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1820, sellprize = 364, name = "Mecha Zero Sion" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Meowkai" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Mercenary Katarina" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Midnight Ahri" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Minuteman Gangplank" }); //people [0]
		skins.Add(new LOLSkins() { prize = 790, sellprize = 0, name = "Miss Fortune" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Monarch KogMaw" }); //people [0]
		skins.Add(new LOLSkins() { prize = 790, sellprize = 0, name = "Mordekaiser" }); //people [0]
		skins.Add(new LOLSkins() { prize = 585, sellprize = 0, name = "Morgana" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Muay Thai Lee Sin" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Musketeer Twisted Fate" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Myrmidon Pantheon" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Mythic Cassiopeia" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 0, name = "Nami" }); //people [0]
		skins.Add(new LOLSkins() { prize = 585, sellprize = 0, name = "Nasus" }); //people [0]
		skins.Add(new LOLSkins() { prize = 880, sellprize = 0, name = "Nautilus" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Nemesis Jax" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Neon Strike Vi" }); //people [0]
		skins.Add(new LOLSkins() { prize = 790, sellprize = 0, name = "Nidalee" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Night Hunter Rengar" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Nightblade Irelia" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Nightmare Tryndamere" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Nightraven Fiora" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Ninja Rammus" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Northern Front Swain" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Northern Storm Volibear" }); //people [0]
		skins.Add(new LOLSkins() { prize = 260, sellprize = 0, name = "Nunu" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1820, sellprize = 364, name = "Nunu Bot" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Nurse Akali" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Officer Caitlyn" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Officer Vi" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Oktoberfest Gragas" }); //people [0]
		skins.Add(new LOLSkins() { prize = 790, sellprize = 0, name = "Olaf" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1820, sellprize = 364, name = "Omega Squad Teemo" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Order of the Lotus Irelia" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Order of the Lotus Karma" }); //people [0]
		skins.Add(new LOLSkins() { prize = 880, sellprize = 0, name = "Orianna" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Outback Renekton" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Overlord Malzahar" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Panda Annie" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Panda Teemo" }); //people [0]
		skins.Add(new LOLSkins() { prize = 790, sellprize = 0, name = "Pantheon" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Pentakill Karthus" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Pentakill Mordekaiser" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Pentakill Olaf" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Pentakill Sona" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Pentakill Yorick" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Pharaoh Nasus" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Pharaoh Nidalee" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Phoenix Quinn" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Pickpocket Twitch" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Piltover Customs Blitzcrank" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Piltover Customs Heimerdinger" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Pool Party Draven" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Pool Party Fiora" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Pool Party Graves" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Pool Party Lee Sin" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Pool Party Leona" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Pool Party Lulu" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Pool Party Miss Fortune" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Pool Party Mundo" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Pool Party RekSai" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Pool Party Renekton" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Pool Party Taric" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Pool Party Zac" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Pool Party Ziggs" }); //people [0]
		skins.Add(new LOLSkins() { prize = 260, sellprize = 0, name = "Poppy" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Popstar Ahri" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Pre Void Kassadin" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Prehistoric Anivia" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Prehistoric ChoGath" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Prehistoric Renekton" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Prestigious LeBlanc" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Primetime Draven" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Program Lissandra" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Program Soraka" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1820, sellprize = 364, name = "Project Ashe" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Project Ekko" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Project Fiora" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Project Katarina" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Project Leona" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Project Lucian" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Project Yasuo" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1820, sellprize = 364, name = "Project Yi" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Project Zed" }); //people [0]
		skins.Add(new LOLSkins() { prize = 3250, sellprize = 650, name = "Pullsefire Ezreal" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Queen of Diamonds Syndra" }); //people [0]
		skins.Add(new LOLSkins() { prize = 880, sellprize = 0, name = "Quinn" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Radiant Wukong" }); //people [0]
		skins.Add(new LOLSkins() { prize = 790, sellprize = 195, name = "Rageborn Mundo" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 0, name = "Rammus" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Ravager Nocturne" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Reaper Hecarim" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Red Card Twisted Fate" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Redeemed Riven" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 0, name = "RekSai" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Renegade Talon" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Renekton" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 0, name = "Rengar" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Resistance Caitlyn" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Reverse Annie" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Risen Fiddlesticks" }); //people [0]
		skins.Add(new LOLSkins() { prize = 880, sellprize = 0, name = "Riven" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "River Spirit Nami" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Rocket Girl Tristana" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Rogue Admiral Garen" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Royal Guard Fiora" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Royal Shaco" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Rugged Garen" }); //people [0]
		skins.Add(new LOLSkins() { prize = 880, sellprize = 0, name = "Rumble" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Rumble in the Jungle" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Runeborn Xerath" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Runeguard Volibear" }); //people [0]
		skins.Add(new LOLSkins() { prize = 260, sellprize = 0, name = "Ryze" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Ryze Whitebeard" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Sad Robot Amumu" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Safecracker Evelynn" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Sakura Karma" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Samurai Yi" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Sandscrouge Skarner" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Sandstorm Ekko" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Sandstorm Katarina" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Sanguine Garen" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Scarlet Hammer Poppy" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Scorched Earth Renekton" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Scorched Earth Xerath" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Sea Hunter Aatrox" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Secret Agent Xin Zhao" }); //people [0]
		skins.Add(new LOLSkins() { prize = 880, sellprize = 0, name = "Sejuani" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Sewn Chaos Orianna" }); //people [0]
		skins.Add(new LOLSkins() { prize = 790, sellprize = 0, name = "Shaco" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Shadow Evelynn" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Shadow Prince Malzahar" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Shadowfire Kindred" }); //people [0]
		skins.Add(new LOLSkins() { prize = 790, sellprize = 0, name = "Shen" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Sherwood Forest Ashe" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Shockblade Zed" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Schurima Desert Zilean" }); //people [0]
		skins.Add(new LOLSkins() { prize = 880, sellprize = 0, name = "Shyvana" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Silverfang Akali" }); //people [0]
		skins.Add(new LOLSkins() { prize = 585, sellprize = 0, name = "Singed" }); //people [0]
		skins.Add(new LOLSkins() { prize = 585, sellprize = 0, name = "Sion" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Sir Kled" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Siren Cassiopeia" }); //people [0]
		skins.Add(new LOLSkins() { prize = 260, sellprize = 0, name = "Sivir" }); //people [0]
		skins.Add(new LOLSkins() { prize = 880, sellprize = 0, name = "Skarner" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "SKT T1 Alistar" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "SKT T1 Azir" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "SKT T1 Elise" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "SKT T1 Kalista" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Snow Day Bard" }); //people [0]
		skins.Add(new LOLSkins() { prize = 790, sellprize = 0, name = "Sona" }); //people [0]
		skins.Add(new LOLSkins() { prize = 260, sellprize = 0, name = "Soraka" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Sorceress Lux" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Soul Reaver Draven" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Soulstealer Vladimir" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Special Forces Gangplank" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Special Weapon Zac" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Spectral Fiddlesticks" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Spellthief Lux" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1320, sellprize = 270, name = "Spirit Fire Brand" }); //people [0]
		skins.Add(new LOLSkins() { prize = 3250, sellprize = 650, name = "Spirit Guard Udyr" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Spooky Gankplank" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Star Guardian Lux" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Statue of Karthus" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Steel Legion Garen" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Steel Legion Lux" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Striker Lucian" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Subterranean Nautilus" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Sultan Gangplank" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Sultan Tryndamere" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Super Galaxy Fizz" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1820, sellprize = 364, name = "Super Galaxy Rumble" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Super Galaxy Shyvana" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Super Teemo" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Superb Villain Veigar" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Superfan Gragas" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Surfer Singed" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Surgeon Shen" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Surprise Party Amumu" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Surprise Party Fiddlesticks" }); //people [0]
		skins.Add(new LOLSkins() { prize = 880, sellprize = 0, name = "Swain" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Sweeper Alistar" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Sweethearth Annie" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Sweethearth Sona" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 0, name = "Syndra" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 0, name = "Tahm Kench" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 0, name = "Taliyah" }); //people [0]
		skins.Add(new LOLSkins() { prize = 880, sellprize = 0, name = "Talon" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Tango Evelynn" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Tango Twisted Fate" }); //people [0]
		skins.Add(new LOLSkins() { prize = 585, sellprize = 0, name = "Taric" }); //people [0]
		skins.Add(new LOLSkins() { prize = 585, sellprize = 0, name = "Teemo" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Temple Jax" }); //people [0]
		skins.Add(new LOLSkins() { prize = 975, sellprize = 0, name = "Thresh" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Thunder Lord Volibear" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Totemic Maokai" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Traditional Lee Sin" }); //people [0]
		skins.Add(new LOLSkins() { prize = 585, sellprize = 0, name = "Tristana" }); //people [0]
		skins.Add(new LOLSkins() { prize = 880, sellprize = 0, name = "Trundle" }); //people [0]
		skins.Add(new LOLSkins() { prize = 585, sellprize = 0, name = "Tryndamere" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Tundra Fizz" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Tundra Hunter Warwick" }); //people [0]
		skins.Add(new LOLSkins() { prize = 585, sellprize = 0, name = "Twisted Fate" }); //people [0]
		skins.Add(new LOLSkins() { prize = 790, sellprize = 0, name = "Twitch" }); //people [0]
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Tyrant Swain" }); //people [0]
		skins.Add(new LOLSkins() { prize = 790, sellprize = 0, name = "Udyr" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Uncle Ryze" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Undertaker Yorick" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Urf Kench" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Urf the Nami tee" }); //people [0]
		skins.Add(new LOLSkins() { prize = 790, sellprize = 0, name = "Urgot" }); //people [0]
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Valkyrie Leona" });
		skins.Add(new LOLSkins() { prize = 880, sellprize = 0, name = "Varus" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Varus Swiftbolt" }); 
		skins.Add(new LOLSkins() { prize = 880, sellprize = 0, name = "Vayne" }); //people [0]
		skins.Add(new LOLSkins() { prize = 790, sellprize = 0, name = "Veigar" }); //people [0]
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Veigar Greybeard" }); 
		skins.Add(new LOLSkins() { prize = 975, sellprize = 0, name = "Velkoz" }); 
		skins.Add(new LOLSkins() { prize = 880, sellprize = 0, name = "Vi" }); 
		skins.Add(new LOLSkins() { prize = 880, sellprize = 0, name = "Viktor" }); 
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Viridian Kayle" });
		skins.Add(new LOLSkins() { prize = 880, sellprize = 0, name = "Vladimir" });
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Void Bringer Illaoi" }); 
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Void Fizz" }); 
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Volcanic Wukong" }); 
		skins.Add(new LOLSkins() { prize = 880, sellprize = 0, name = "Volibear" }); 
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Warden Jax" }); 
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Warden Nautilus" });
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Warden Sivir" }); 
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Warlord Shen" });
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Warmonger Sion" }); 
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Warring Kingdoms Jarvan IV" }); 
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Warring Kingdoms Katarina" }); 
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Warring Kingdoms Nidalee" }); 
		skins.Add(new LOLSkins() { prize = 1350, sellprize = 270, name = "Warring Kingdoms Xin Zhao" }); 
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Warrior Princess Sivir" }); 
		skins.Add(new LOLSkins() { prize = 260, sellprize = 0, name = "Warwick" }); 
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Waterloo Miss Fortune" }); 
		skins.Add(new LOLSkins() { prize = 390, sellprize = 78, name = "White Mage Veigar" }); 
		skins.Add(new LOLSkins() { prize = 750, sellprize = 150, name = "Wicked LeBlanc" });
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Wicked Lulu" }); 
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Wild Card Shaco" });
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Wildfire Zyra" });
		skins.Add(new LOLSkins() { prize = 520, sellprize = 104, name = "Woad Ashe" });
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Woad King Darius" }); 
		skins.Add(new LOLSkins() { prize = 975, sellprize = 195, name = "Woad Scout Quinn" });
		skins.Add(new LOLSkins() { prize = 880, sellprize = 0, name = "Wukong" }); 
		skins.Add(new LOLSkins() { prize = 880, sellprize = 0, name = "Xerath" }); 
		skins.Add(new LOLSkins() { prize = 585, sellprize = 0, name = "Xin Zhao" }); 
		skins.Add(new LOLSkins() { prize = 975, sellprize = 0, name = "Yasuo" });
		skins.Add(new LOLSkins() { prize = 880, sellprize = 0, name = "Yorick" }); 
		skins.Add(new LOLSkins() { prize = 975, sellprize = 0, name = "Zac" });
		skins.Add(new LOLSkins() { prize = 975, sellprize = 0, name = "Zed" });
		skins.Add(new LOLSkins() { prize = 880, sellprize = 0, name = "Ziggs" });
		skins.Add(new LOLSkins() { prize = 585, sellprize = 0, name = "Zilean" }); 
		skins.Add(new LOLSkins() { prize = 975, sellprize = 0, name = "Zyra" }); 
		#endregion
	}
 }
