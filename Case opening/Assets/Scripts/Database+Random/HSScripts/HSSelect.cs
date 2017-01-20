using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class HSSelect : MonoBehaviour {

	public HSRandom SelectedDatabase;
	public ClassicDatabase cdata;
	public GGDatabase ggdata;
	public GTDatabase gtdata;
	public WDatabase wdata;
	public MSGDatabase msgdata;
	public EDatabase edata;
	public LDatabase ldata;


	public void OnClick(string Name)
	{
		switch (Name) {
		case "Classic":
			SelectedDatabase.SelectedDatabase = cdata.ccards;
			break;
		case "Goblin":
			SelectedDatabase.SelectedDatabase = ggdata.ggcards;
			break;
		case "Tournament":
			SelectedDatabase.SelectedDatabase = gtdata.gtcards;
			break;
		case "Whisper":
			SelectedDatabase.SelectedDatabase = wdata.wcards;
			break;
		case "Mean Streets":
			SelectedDatabase.SelectedDatabase = msgdata.msgcards;
			break;
		case "E":
			SelectedDatabase.SelectedDatabase = edata.ecards;
			break;
		case "L":
			SelectedDatabase.SelectedDatabase = ldata.lcards;
			break;
		}
	}
}
