using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using Newtonsoft.Json;
public class CSShop : MonoBehaviour {
	public GameObject slotPanel;
	public GameObject ScrollView;
	public GameObject inventorySlot;
	public GameObject inventoryItem;
	public GameObject Type;
	public GameObject Condition;
	public CSShopDatabase shopData;
	public List<GameObject> slot = new List<GameObject> ();

	int SlotAmount;
	public bool EditSkin{ get; set;}

	void Start()
	{
		EditSkin = false;
		Slot ();
	}

	public void Slot()
	{
		SlotAmount = shopData.shop.Count;
		foreach (CSGOSkins skin in shopData.shop) 
		{

			GameObject GO = GameObject.Instantiate (inventorySlot);
			GO.name = skin.stattrak + " " + skin.firstname + " " + skin.secondname + " " + skin.condition;
			GO.transform.SetParent (slotPanel.transform, false);
			slot.Add (GO);
			AddItem (skin,GO);
		
		}
	}
	public void DeleteSlots()
	{
		foreach (Transform tr in slotPanel.transform) {
			GameObject.Destroy (tr.gameObject);
		}
	}

	public void AddItem(CSGOSkins skin,GameObject parent)
	{
		GameObject itemGO = GameObject.Instantiate (inventoryItem);
		itemGO.transform.SetParent (parent.transform, false);
		itemGO.GetComponent<Image> ().sprite = Resources.Load<Sprite> ("CSGO/" + skin.firstname + " " + skin.secondname);
		GameObject itemGO2 = GameObject.Instantiate (Type);
		itemGO2.transform.SetParent (parent.transform, false);
		itemGO2.GetComponent<Text> ().text = skin.stattrak;
		GameObject itemGO3 = GameObject.Instantiate (Condition);
		itemGO3.transform.SetParent (parent.transform, false);
		itemGO3.GetComponent<Text> ().text = skin.condition;
	}
}