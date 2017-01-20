using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
public class CSRandom : MonoBehaviour {

	public List<CSGOSkins> SelectedDatabase;
	float timer = 7.834f;
	bool Spawner = false;
	public CSSelect slc;
	public Animator anim;
	public AudioSource aud;
	public GameObject Parent;
	public CSGOSkins SelectedSkin;
	public Image Icon;
	public Text Stattrak;
	public Text Condition;
	public Text Price;
	public Button Save;
	public Button Delete;
	public GameObject Panel;
	public GameObject OpenScene;
	public Button OpenButton;
	public Image Unlocking;
	void Start () {
		anim.enabled = false;
		aud.enabled = false;
	}
	public void OnClick(){
		Spawner = true;
		LoadAll ();
		anim.enabled = true;
		aud.enabled = true;
	}

	void Update(){
		if (Spawner == true)
			timer -= Time.deltaTime;
		if (timer <= 0) {
			timer = 7.834f;
			AfterSelect ();
			aud.enabled = false;
			anim.enabled = false;
			Spawner = false;
		}
	}
	public void LoadAll(){
		foreach (Transform tr in Parent.transform) {
			   if(tr.tag == "Skin")
			     SpawnSkin (tr.gameObject);
		}
}
	void SpawnSkin(GameObject SelectedSkin){
		Debug.Log ("Ahoj");
		int rndmNumber = Random.Range (0, 1000);
         string SelectedType = "";
		if (rndmNumber < 5)
			SelectedType = slc.SelectedType1;
		else if (rndmNumber < 20 && rndmNumber > 4)
			SelectedType = slc.SelectedType2;
		else if (rndmNumber < 80 && rndmNumber > 19)
			SelectedType = slc.SelectedType3;
		else if (rndmNumber < 200 && rndmNumber > 79)
			SelectedType = slc.SelectedType4;
		else if (rndmNumber < 600 && rndmNumber > 199)
			SelectedType = slc.SelectedType5;
		else 
			SelectedType = slc.SelectedType6;

		bool hasBeenFound = false;
		int randomCSSkin = Random.Range (0, SelectedDatabase.Count);
		for (int i = 0; i <= SelectedDatabase.Count; i++) {
			if (i == randomCSSkin && SelectedDatabase[i].type == SelectedType  ) {                                  
				hasBeenFound = true;
				Image CardFace = SelectedSkin.GetComponent<Image> ();
				Sprite Sprite = Resources.Load<Sprite> ("CSGO/" + SelectedDatabase[i].firstname + " " + SelectedDatabase[i].secondname);
				CardFace.sprite = Sprite;
				Debug.Log (SelectedDatabase [i].firstname + " " + SelectedDatabase [i].secondname);
			}
			if (hasBeenFound != true && i == (SelectedDatabase.Count - 1)){
				randomCSSkin = Random.Range (0, SelectedDatabase.Count);
				i = 0;
			}
		}
	}
	public void AfterSelect()
	{
		for (int i = 0; i <= SelectedDatabase.Count; i++) {
			foreach (Transform tr in OpenScene.transform) {
				if (tr.tag == "Panel")
					tr.gameObject.SetActive (false);
			}
			Unlocking.gameObject.SetActive (false);
			OpenButton.gameObject.SetActive (false);
			Panel.gameObject.SetActive (true);

	
		
		
		}
	}
}