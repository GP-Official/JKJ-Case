using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
public class LOLLoader : MonoBehaviour {
	public LOLInventory lolinv;
	public LOLShop shop;

	void Awake()
	{
		string Data = PlayerPrefs.GetString ("jsoninv");
		if (Data == "")
			lolinv.lolinv = new List<LOLSkins> ();
		else
			lolinv.lolinv = JsonConvert.DeserializeObject<List<LOLSkins>> (Data);

		
	}
}
