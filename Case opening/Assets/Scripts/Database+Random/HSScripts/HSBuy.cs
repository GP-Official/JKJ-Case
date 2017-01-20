using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using Newtonsoft.Json;
public class HSBuy : MonoBehaviour {

	public HSInventory hsinv;
	public HSCoin hscoin;
	public HSShopSelect hsslt;
	public LDatabase hsshop;
	public void OnClick()
	{
		if (hscoin.coinNumber >= hsslt.SelectedSkin.prize) {
			hscoin.coinNumber -= hsslt.SelectedSkin.prize;
			hsinv.hsinv.Add (hsslt.SelectedSkin);
			Buy ();
		}
	}
	public void Buy()
	{
		string HSData = JsonConvert.SerializeObject (hsinv.hsinv, Formatting.None, new JsonSerializerSettings {
			NullValueHandling = NullValueHandling.Ignore,
			Formatting = Formatting.Indented
		});
		PlayerPrefs.SetString ("hsinv",HSData);
		PlayerPrefs.Save ();
	}

}
