using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LOLSelect : MonoBehaviour {

	public LOLSkins SelectedSkin;
	public Text Input_Name;
	public Text Type;
	public Text Price;
	public Text Sellprice;
	public Image Icon;

	void Start () {
	
	
	}
	void Update()
	{
		if (SelectedSkin != null) {
			Input_Name.text = SelectedSkin.name;
			Icon.GetComponent<Image> ().sprite = Resources.Load<Sprite> ("LOL/Skins+Champions/" + SelectedSkin.name);
			Price.text = "Price: " + SelectedSkin.prize;
			Sellprice.text = "Sellprice: " + SelectedSkin.sellprize;

			if (SelectedSkin.prize == 3250)
				Type.text = "Type: Ultimate";
			else if (SelectedSkin.prize == 1820)
				Type.text = "Type: Legendary";
			else
				Type.text = "Type: Common";
		}
	}
}
