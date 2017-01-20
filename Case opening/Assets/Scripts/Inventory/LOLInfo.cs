using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Newtonsoft.Json;
using System.Collections.Generic;
public class LOLInfo : MonoBehaviour {

	public GameObject InfoPanel;
	public GameObject Inventory;
	public GameObject ScriptHandler;
	public LOLInventory lolinv;
	public LOLSelect Selection;

	void Start()
	{
		Inventory = this.gameObject.transform.parent.parent.parent.parent.parent.gameObject;
		InfoPanel = Inventory.transform.FindChild ("Info").gameObject;
		Selection = InfoPanel.GetComponent<LOLSelect> ();
		ScriptHandler = Inventory.transform.FindChild ("ScriptHandler").gameObject;
		lolinv = ScriptHandler.gameObject.GetComponent<LOLInventory> ();
	}

	public void OnClick () {
			foreach (Transform tr in Inventory.transform) {
				if (tr.tag == "Info") {		
					tr.gameObject.SetActive (true);
				foreach (LOLSkins skin in lolinv.lolinv) {
					if (this.gameObject.transform.parent.gameObject.name == skin.name) {
						Selection.SelectedSkin = skin;

					
					}
				 }
			    }
			}
	}

}
	

