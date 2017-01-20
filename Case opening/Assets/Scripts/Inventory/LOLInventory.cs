using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using Newtonsoft.Json;
public class LOLInventory : MonoBehaviour {

	public GameObject slotPanel;
	public GameObject ScrollView;
	public GameObject inventorySlot;
	public GameObject inventoryItem;

	public List<LOLSkins> lolinv;
	public List<GameObject> slots = new List<GameObject>();

	int SlotAmount;
	public bool EditSkin{ get; set;}

	void Start()
	{
		//PlayerPrefs.DeleteAll ();
		lolinv.Capacity = 207;
		EditSkin = false;
	}
	 
	public void Slot()
	{
		SlotAmount = lolinv.Count;
		for (int i = 0; i < SlotAmount; i++) 
		{
			GameObject GO = GameObject.Instantiate (inventorySlot);
			GO.name = lolinv [i].name;
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
		itemGO.GetComponent<Image> ().sprite = Resources.Load<Sprite> ("LOL/Skins+Champions/" + lolinv [i].name);
	}
}