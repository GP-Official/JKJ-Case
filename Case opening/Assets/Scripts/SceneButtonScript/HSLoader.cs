using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
public class HSLoader : MonoBehaviour {
	public HSInventory hsinv;

	void Awake()
	{
		string HSData = PlayerPrefs.GetString ("hsinv");
		if (HSData == "")
			hsinv.hsinv = new List<HSCards> ();
		else
			hsinv.hsinv = JsonConvert.DeserializeObject<List<HSCards>> (HSData);


	}
}