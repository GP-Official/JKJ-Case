using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using Newtonsoft.Json;
public class LOLSell : MonoBehaviour {

	public LOLInventory lolinv;
	public LOLCoin lolcoin;
	public LOLSelect lolslt;
	public GameObject Parent;
	public void OnClick()
	{
		
		lolcoin.coinNumber += lolslt.SelectedSkin.sellprize;
		lolinv.lolinv.Remove (lolslt.SelectedSkin);
		LOLSave ();

		foreach (Transform slot in Parent.transform) {
			if (slot.name == lolslt.SelectedSkin.name) {
				
				GameObject.Destroy (slot.gameObject);
				lolinv.slots.Remove (slot.gameObject);
			}
		
		}
	}

	public void LOLSave()
	{
		string Data = JsonConvert.SerializeObject (lolinv.lolinv, Formatting.None, new JsonSerializerSettings {
			NullValueHandling = NullValueHandling.Ignore,
			Formatting = Formatting.Indented
		});


		PlayerPrefs.SetString ("jsoninv",Data);
		PlayerPrefs.Save ();

	}

}

