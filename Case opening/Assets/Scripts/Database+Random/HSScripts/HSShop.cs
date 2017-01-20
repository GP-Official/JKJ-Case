using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using Newtonsoft.Json;
public class HSShop : MonoBehaviour {
	public GameObject slotPanel;
	public GameObject ScrollView;
	public GameObject inventorySlot;
	public GameObject inventoryItem;

	public LDatabase shopData;
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
		SlotAmount = shopData.lcards.Count;
		for (int i = 0; i < SlotAmount; i++) 
		{
			GameObject GO = GameObject.Instantiate (inventorySlot);
			GO.name = shopData.lcards [i].name;
			GO.transform.SetParent (slotPanel.transform, false);
			slot.Add (GO);
			AddItem (i,GO);
		}
	}
	public void DeleteSlots()
	{
		foreach (Transform tr in slotPanel.transform) {
			GameObject.Destroy (tr.gameObject);
		}
	}

	public void AddItem(int i,GameObject parent)
	{
		GameObject itemGO = GameObject.Instantiate (inventoryItem);
		itemGO.transform.SetParent (parent.transform, false);
		itemGO.GetComponent<Image> ().sprite = Resources.Load<Sprite> ("HS/" + shopData.lcards [i].name);
	}
}