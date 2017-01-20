using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Newtonsoft.Json;
using System.Collections.Generic;
public class LOLBuyInfo : MonoBehaviour {

	public GameObject InfoPanel;
	public GameObject Shop;
	public GameObject ScriptHandler;
	public LOLShopDatabase shopData;
	public LOLSelect Selection;

	void Start()
	{
		Shop = this.gameObject.transform.parent.parent.parent.parent.parent.gameObject;
		InfoPanel = Shop.transform.FindChild ("Info").gameObject;
		Selection = InfoPanel.GetComponent<LOLSelect> ();
		ScriptHandler = Shop.transform.FindChild ("ScriptHandler").gameObject;
		shopData = ScriptHandler.gameObject.GetComponent<LOLShopDatabase> ();
	}

	public void OnClick () {
		foreach (Transform tr in Shop.transform) {
			if (tr.tag == "Info") {		
				tr.gameObject.SetActive (true);
				foreach (LOLSkins skin in shopData.shopskins) {
					if (this.gameObject.transform.parent.gameObject.name == skin.name) {
						Selection.SelectedSkin = skin;


					}
				}
			}
		}
	}

}
