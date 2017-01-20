using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CSShopSelect : MonoBehaviour {

	public CSGOSkins SelectedSkin;
	public Image Icon;
	public Text Stattrak;
	public Text Condition;
	public Text Price;
	void Start () {

	}
	void Update()
	{
		if (SelectedSkin != null) {
			Stattrak.text = SelectedSkin.stattrak;
			Condition.text = SelectedSkin.condition;
			Price.text = SelectedSkin.prize.ToString ();
			Icon.GetComponent<Image> ().sprite = Resources.Load<Sprite> ("CSGO/" + SelectedSkin.firstname + " " + SelectedSkin.secondname);
		}
	}
}
