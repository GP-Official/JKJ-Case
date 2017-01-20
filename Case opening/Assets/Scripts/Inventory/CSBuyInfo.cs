using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Newtonsoft.Json;
using System.Collections.Generic;
public class CSBuyInfo : MonoBehaviour {
	CSGOSkins skin;
	public GameObject InfoPanel;
	public GameObject Shop;
	public GameObject ScriptHandler;
	public CSShopDatabase shopData;
	public CSShopSelect Selection;

	void Start()
	{
		Shop = this.gameObject.transform.parent.parent.parent.parent.parent.gameObject;
		InfoPanel = Shop.transform.FindChild ("Info").gameObject;
		Selection = InfoPanel.GetComponent<CSShopSelect> ();
		ScriptHandler = Shop.transform.FindChild ("ScriptHandler").gameObject;
		shopData = ScriptHandler.gameObject.GetComponent<CSShopDatabase> ();
	
	}

	public void OnClick () {
		foreach (Transform tr in Shop.transform) {
			if (tr.tag == "Info") {		
				tr.gameObject.SetActive (true);
				foreach (CSGOSkins skin in shopData.shop) {
					if (this.gameObject.transform.parent.gameObject.name == skin.stattrak + " " + skin.firstname + " " + skin.secondname + " " + skin.condition) {
						Selection.SelectedSkin = skin;

					}
				}
			}
		}
	}

}