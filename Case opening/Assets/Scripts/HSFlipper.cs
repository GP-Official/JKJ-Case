using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using Newtonsoft.Json;
public class HSFlipper : MonoBehaviour {

	public HSRandom random;
	public HSInventory hsinv;
	public Animator anim;
	public Button Card;
	public HSCards SelectedCard;
	public Canvas OpenPacks;
	public Button SaveButton;
	bool Spawner = false;
	float changetimer = 0.53f;
	float stoptimer = 1f;

	void Start(){
		//PlayerPrefs.DeleteAll ();
		anim.enabled = false;
	
	}

	public void OnClick() {
		Spawner = true;
		anim.enabled = true;
		hsinv.hsinv.Add (SelectedCard);
		Add ();
	}
	public void Update()
	{
		if (Spawner == true) {
			changetimer -= Time.deltaTime;
			stoptimer -= Time.deltaTime;
			if (changetimer <= 0) {
				SpawnCard ();
			}
			if (stoptimer <= 0) {
				changetimer = 0.53f;
				stoptimer = 1f;
				anim.enabled = false;
				Spawner = false;
		  }
		}
	}
	public void SpawnCard(){
		for (int i = 0; i <= random.SelectedDatabase.Count; i++) {
			Image CardFace = Card.GetComponent<Image> ();
			Sprite Sprite = Resources.Load<Sprite> ("HS/" + SelectedCard.name);
			CardFace.sprite = Sprite;

		}
	}
	public void Add(){
		string HSData = JsonConvert.SerializeObject (hsinv.hsinv, Formatting.None, new JsonSerializerSettings {
			NullValueHandling = NullValueHandling.Ignore,
			Formatting = Formatting.Indented
		});

		PlayerPrefs.SetString ("hsinv", HSData);
		PlayerPrefs.Save ();
		Debug.Log (PlayerPrefs.GetString ("hsinv"));
	
	
	
	
	
	
	}
	}
