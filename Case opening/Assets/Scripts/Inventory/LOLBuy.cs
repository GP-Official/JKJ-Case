using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using Newtonsoft.Json;
public class LOLBuy : MonoBehaviour {

	public LOLInventory lolinv;
	public LOLCoin lolcoin;
	public LOLSelect lolslt;
	public LOLShopDatabase lolshop;
	public void OnClick()
	{
		if (lolcoin.coinNumber >= lolslt.SelectedSkin.prize) {
			lolcoin.coinNumber -= lolslt.SelectedSkin.prize;
			lolinv.lolinv.Add (lolslt.SelectedSkin);
			Buy ();
		}
	}
	public void Buy()
	{
		string Data = JsonConvert.SerializeObject (lolinv.lolinv, Formatting.None, new JsonSerializerSettings {
			NullValueHandling = NullValueHandling.Ignore,
			Formatting = Formatting.Indented
		});
		PlayerPrefs.SetString ("jsoninv",Data);
		PlayerPrefs.Save ();
	}

}
