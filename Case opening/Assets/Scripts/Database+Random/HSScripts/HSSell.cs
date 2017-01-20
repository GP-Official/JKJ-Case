using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using Newtonsoft.Json;
public class HSSell : MonoBehaviour {

	public HSInventory hsinv;
	public HSCoin hscoin;
	public HSShopSelect hsslt;
	public GameObject Parent;
	public void OnClick()
	{
		 
			hscoin.coinNumber += hsslt.SelectedSkin.sellprize;
			hsinv.hsinv.Remove (hsslt.SelectedSkin);
			HSSave ();

			foreach (Transform slot in Parent.transform) {
				if (slot.name == hsslt.SelectedSkin.name) {

					GameObject.Destroy (slot.gameObject);
					hsinv.slots.Remove (slot.gameObject);
				}
			}
		}

	public void HSSave()
	{
		string HSData = JsonConvert.SerializeObject (hsinv.hsinv, Formatting.None, new JsonSerializerSettings {
			NullValueHandling = NullValueHandling.Ignore,
			Formatting = Formatting.Indented
		});


		PlayerPrefs.SetString ("hsinv",HSData);
		PlayerPrefs.Save ();

	}

}