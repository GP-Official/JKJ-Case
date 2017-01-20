using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using Newtonsoft.Json;
public class CSInventory : MonoBehaviour {

	public GameObject slotPanel;
	public GameObject ScrollView;
	public GameObject inventorySlot;
	public GameObject inventoryItem;
	public GameObject Type;
	public GameObject Condition;
	public List<CSGOSkins> csinv;
	public List<GameObject> slots = new List<GameObject>();

	int SlotAmount;
	public bool EditSkin{ get; set;}

	void Start()
	{
		//PlayerPrefs.DeleteAll ();
		csinv.Capacity = 250;
		EditSkin = false;
	}

	public void Slot()
	{
		SlotAmount = csinv.Count;
		for (int i = 0; i < SlotAmount; i++) 
		{
			GameObject GO = GameObject.Instantiate (inventorySlot);
			GO.name = csinv [i].firstname + " " + csinv[i].secondname;
			GO.transform.SetParent (slotPanel.transform, false);
			slots.Add (GO);
			AddItem (i,GO);
		}
	}
	public void DeleteSlots()
	{
		foreach (Transform tr in slotPanel.transform) {
			GameObject.Destroy (tr.gameObject);
			slots.Remove (tr.gameObject);
		}
	}
	public void AddItem(int i,GameObject parent)
	{
		GameObject itemGO = GameObject.Instantiate (inventoryItem);
		itemGO.transform.SetParent (parent.transform, false);
		itemGO.GetComponent<Image> ().sprite = Resources.Load<Sprite> ("CSGO/" + csinv [i].firstname + " " + csinv[i].secondname);
		GameObject itemGO2 = GameObject.Instantiate (Type);
		itemGO2.transform.SetParent (parent.transform, false);
		itemGO2.GetComponent<Text> ().text = csinv[i].stattrak;
		GameObject itemGO3 = GameObject.Instantiate (Condition);
		itemGO3.transform.SetParent (parent.transform, false);
		itemGO3.GetComponent<Text> ().text = csinv[i].condition;
	
	}
}

