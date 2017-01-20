using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Newtonsoft.Json;
using System.Collections.Generic;
public class LOLSave : MonoBehaviour {
	public Button OpenButton;
	public Button DeleteButton;
	public Button SaveButton;
	public GameObject ImageGO;
	public Image Chest;
	public LOLInventory lolinv;
	public LOLRandom lolrandom;

	public void OnClick()
	{


		lolinv.lolinv.Add(lolrandom.SelectedSkin);

		string Data = JsonConvert.SerializeObject (lolinv.lolinv, Formatting.None, new JsonSerializerSettings {
			NullValueHandling = NullValueHandling.Ignore,
			Formatting = Formatting.Indented
		});
			
	
		PlayerPrefs.SetString ("jsoninv",Data);
		PlayerPrefs.Save ();
		Debug.Log(PlayerPrefs.GetString("jsoninv"));

	
		OpenButton.gameObject.SetActive (true);
		DeleteButton.gameObject.SetActive (false);
		SaveButton.gameObject.SetActive (false);
		ImageGO.gameObject.SetActive (false);
		Chest.gameObject.SetActive (true);
	
	}

}
