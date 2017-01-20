using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class CSSelect : MonoBehaviour {

	public CSRandom SelectedDatabase;
	public BravoDatabase badata;
	public BreakoutDatabase brdata;
	public CacheDatabase cadata;
	public CobblestoneDatabase cbdata;
	public Dust2Database d2data;
	public eSports2013Database e2data;
	public eSportsSummerDatabase esdata;
	public eSportsWinterDatabase ewdata;
	public FalchionDatabase fdata;
	public GammaDatabase gdata;
	public Gamma2Database g2data;
	public GodsandMonstersDatabase gmdata;
	public GlovesDatabase gldata;
	public HuntsmanDatabase hdata;
	public ChromaDatabase cdata;
	public Chroma2Database c2data;
	public Chroma3Database c3data;
	public MirageDatabase mdata;
	public NukeDatabase ndata;
	public OverpassDatabase odata;
	public PhoenixDatabase pdata;
	public RevolverDatabase rdata;
	public ShadowDatabase sdata;
	public VanguardDatabase vdata;
	public WeaponDatabase wdata;
	public Weapon2Database w2data;
	public Weapon3Database w3data;
	public WildfireDatabase widata;
	public WOffensiveDatabase wodata;
	public PremiumDatabase prdata;
	public UltraPremiumDatabase updata;
	public string SelectedType1;
	public string SelectedType2;
	public string SelectedType3;
	public string SelectedType4;
	public string SelectedType5;
	public string SelectedType6;
	public void OnClick (string Name) {
	
		switch (Name) {
		#region case
		case "Bravo":
			SelectedDatabase.SelectedDatabase = badata.b;
			SelectedType1 = "Rare";
			SelectedType2 = "Red";
			SelectedType3 = "";
			SelectedType4 = "Pink";
			SelectedType5 = "Purple";
			SelectedType6 = "Blue";
			break;
		case "Breakout":
			SelectedDatabase.SelectedDatabase = brdata.br;
			SelectedType1 = "Rare";
			SelectedType2 = "Red";
			SelectedType3 = "";
			SelectedType4 = "Pink";
			SelectedType5 = "Purple";
			SelectedType6 = "Blue";
			break;
		case "Cache":
			SelectedDatabase.SelectedDatabase = cadata.ca;
			SelectedType1 = "";
			SelectedType2 = "";
			SelectedType3 = "Purple";
			SelectedType4 = "Blue";
			SelectedType5 = "White Blue";
			SelectedType6 = "Grey";
			break;
		case "Cobble":
			SelectedDatabase.SelectedDatabase = cbdata.co;
			SelectedType1 = "Red";
			SelectedType2 = "Pink";
			SelectedType3 = "Purple";
			SelectedType4 = "Blue";
			SelectedType5 = "White Blue";
			SelectedType6 = "Grey";
			break;
		case "Dust2":
			SelectedDatabase.SelectedDatabase = d2data.d2;
			SelectedType1 = "";
			SelectedType2 = "";
			SelectedType3 = "Purple";
			SelectedType4 = "Blue";
			SelectedType5 = "White Blue";
			SelectedType6 = "Grey";
			break;
		case "e13":
			SelectedDatabase.SelectedDatabase = e2data.e1;
			SelectedType1 = "Rare";
			SelectedType2 = "Red";
			SelectedType3 = "";
			SelectedType4 = "Pink";
			SelectedType5 = "Purple";
			SelectedType6 = "Blue";
			break;
		case "eSummer":
			SelectedDatabase.SelectedDatabase = esdata.e3;
			SelectedType1 = "Rare";
			SelectedType2 = "Red";
			SelectedType3 = "";
			SelectedType4 = "Pink";
			SelectedType5 = "Purple";
			SelectedType6 = "Blue";
			break;
		case "eWinter":
			SelectedDatabase.SelectedDatabase = ewdata.e2;
			SelectedType1 = "Rare";
			SelectedType2 = "Red";
			SelectedType3 = "";
			SelectedType4 = "Pink";
			SelectedType5 = "Purple";
			SelectedType6 = "Blue";
			break;
		case "Falchion":
			SelectedDatabase.SelectedDatabase = fdata.f;
			SelectedType1 = "Rare";
			SelectedType2 = "Red";
			SelectedType3 = "";
			SelectedType4 = "Pink";
			SelectedType5 = "Purple";
			SelectedType6 = "Blue";
			break;
		case "Gamma2":
			SelectedDatabase.SelectedDatabase = g2data.g2;
			SelectedType1 = "Rare";
			SelectedType2 = "Red";
			SelectedType3 = "";
			SelectedType4 = "Pink";
			SelectedType5 = "Purple";
			SelectedType6 = "Blue";
			break;
		case "Gamma":
			SelectedDatabase.SelectedDatabase = gdata.g;
			SelectedType1 = "Rare";
			SelectedType2 = "Red";
			SelectedType3 = "";
			SelectedType4 = "Pink";
			SelectedType5 = "Purple";
			SelectedType6 = "Blue";
			break;
		case "GM":
			SelectedDatabase.SelectedDatabase = gmdata.god;
			SelectedType1 = "Red";
			SelectedType2 = "Pink";
			SelectedType3 = "Purple";
			SelectedType4 = "Blue";
			SelectedType5 = "White Blue";
			SelectedType6 = "Grey";
			break;
		case "Gloves":
			SelectedDatabase.SelectedDatabase = gldata.gl;
			SelectedType1 = "";
			SelectedType2 = "";
			SelectedType3 = "";
			SelectedType4 = "Pink";
			SelectedType5 = "Purple";
			SelectedType6 = "Blue";
			break;
		case "Huntsman":
			SelectedDatabase.SelectedDatabase = hdata.h;
			SelectedType1 = "Rare";
			SelectedType2 = "Red";
			SelectedType3 = "";
			SelectedType4 = "Pink";
			SelectedType5 = "Purple";
			SelectedType6 = "Blue";
			break;
		case "Chroma":
			SelectedDatabase.SelectedDatabase = cdata.c1;
			SelectedType1 = "Rare";
			SelectedType2 = "Red";
			SelectedType3 = "";
			SelectedType4 = "Pink";
			SelectedType5 = "Purple";
			SelectedType6 = "Blue";
			break;
		case "Chroma2":
			SelectedDatabase.SelectedDatabase = c2data.c2;
			SelectedType1 = "Rare";
			SelectedType2 = "Red";
			SelectedType3 = "";
			SelectedType4 = "Pink";
			SelectedType5 = "Purple";
			SelectedType6 = "Blue";
			break;
		case "Chroma3":
			SelectedDatabase.SelectedDatabase = c3data.c3;
			SelectedType1 = "Rare";
			SelectedType2 = "Red";
			SelectedType3 = "";
			SelectedType4 = "Pink";
			SelectedType5 = "Purple";
			SelectedType6 = "Blue";
			break;
		case "Mirage":
			SelectedDatabase.SelectedDatabase = mdata.m;
			SelectedType1 = "";
			SelectedType2 = "";
			SelectedType3 = "Purple";
			SelectedType4 = "Blue";
			SelectedType5 = "White Blue";
			SelectedType6 = "Grey";
			break;
		case "Nuke":
			SelectedDatabase.SelectedDatabase = ndata.n;
			SelectedType1 = "";
			SelectedType2 = "";
			SelectedType3 = "Purple";
			SelectedType4 = "Blue";
			SelectedType5 = "White Blue";
			SelectedType6 = "Grey";
			break;
		case "Overpass":
			SelectedDatabase.SelectedDatabase = odata.o;
			SelectedType1 = "";
			SelectedType2 = "Pink";
			SelectedType3 = "Purple";
			SelectedType4 = "Blue";
			SelectedType5 = "White Blue";
			SelectedType6 = "Grey";
			break;
		case "Phoenix":
			SelectedDatabase.SelectedDatabase = pdata.p;
			SelectedType1 = "Rare";
			SelectedType2 = "Red";
			SelectedType3 = "";
			SelectedType4 = "Pink";
			SelectedType5 = "Purple";
			SelectedType6 = "Blue";
			break;
		case "Revolver":
			SelectedDatabase.SelectedDatabase = rdata.r;
			SelectedType1 = "Rare";
			SelectedType2 = "Red";
			SelectedType3 = "";
			SelectedType4 = "Pink";
			SelectedType5 = "Purple";
			SelectedType6 = "Blue";
			break;
		case "Shadow":
			SelectedDatabase.SelectedDatabase = sdata.s;
			SelectedType1 = "Rare";
			SelectedType2 = "Red";
			SelectedType3 = "";
			SelectedType4 = "Pink";
			SelectedType5 = "Purple";
			SelectedType6 = "Blue";
			break;
		case "Vanguard":
			SelectedDatabase.SelectedDatabase = vdata.v;
			SelectedType1 = "Rare";
			SelectedType2 = "Red";
			SelectedType3 = "";
			SelectedType4 = "Pink";
			SelectedType5 = "Purple";
			SelectedType6 = "Blue";
			break;
		case "Weapon":
			SelectedDatabase.SelectedDatabase = wdata.w1;
			SelectedType1 = "Rare";
			SelectedType2 = "Red";
			SelectedType3 = "";
			SelectedType4 = "Pink";
			SelectedType5 = "Purple";
			SelectedType6 = "Blue";
			break;
		case "Weapon2":
			SelectedDatabase.SelectedDatabase = w2data.w2;
			SelectedType1 = "Rare";
			SelectedType2 = "Red";
			SelectedType3 = "";
			SelectedType4 = "Pink";
			SelectedType5 = "Purple";
			SelectedType6 = "Blue";
			break;
		case "Weapon3":
			SelectedDatabase.SelectedDatabase = w3data.w3;
			SelectedType1 = "Rare";
			SelectedType2 = "Red";
			SelectedType3 = "";
			SelectedType4 = "Pink";
			SelectedType5 = "Purple";
			SelectedType6 = "Blue";
			break;
		case "Wildfire":
			SelectedDatabase.SelectedDatabase = widata.wi;
			SelectedType1 = "Rare";
			SelectedType2 = "Red";
			SelectedType3 = "";
			SelectedType4 = "Pink";
			SelectedType5 = "Purple";
			SelectedType6 = "Blue";
			break;
		case "WO":
			SelectedDatabase.SelectedDatabase = wodata.w;
			SelectedType1 = "Rare";
			SelectedType2 = "Red";
			SelectedType3 = "";
			SelectedType4 = "Pink";
			SelectedType5 = "Purple";
			SelectedType6 = "Blue";
			break;
		case "Premium":
			SelectedDatabase.SelectedDatabase = prdata.pr;
			SelectedType1 = "";
			SelectedType2 = "";
			SelectedType3 = "";
			SelectedType4 = "";
			SelectedType5 = "Red";
			SelectedType6 = "Pink";
			break;
		case "UltraPremium":
			SelectedDatabase.SelectedDatabase = updata.up;
			SelectedType1 = "";
			SelectedType2 = "";
			SelectedType3 = "";
			SelectedType4 = "Pink";
			SelectedType5 = "Rare";
			SelectedType6 = "Red";
			break;
			#endregion
		}
	}
}		
