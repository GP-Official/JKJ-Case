using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Newtonsoft.Json;
using System.Collections.Generic;
public class HSInfo : MonoBehaviour {

	public GameObject InfoPanel;
	public GameObject Collection;
	public GameObject ScriptHandler;
	public HSInventory hsinv;
	public HSShopSelect Selection;

	void Start()
	{
		Collection = this.gameObject.transform.parent.parent.parent.parent.parent.gameObject;
		InfoPanel = Collection.transform.FindChild ("Info").gameObject;
		Selection = InfoPanel.GetComponent<HSShopSelect> ();
		ScriptHandler = Collection.transform.FindChild ("ScriptHandler").gameObject;
		hsinv = ScriptHandler.gameObject.GetComponent<HSInventory> ();
	}

	public void OnClick () {
		foreach (Transform tr in Collection.transform) {
			if (tr.tag == "Info") {		
				tr.gameObject.SetActive (true);
				foreach (HSCards skin in hsinv.hsinv) {
					if (this.gameObject.transform.parent.gameObject.name == skin.name) {
						Selection.SelectedSkin = skin;


					}
				}
			}
		}
	}

}

