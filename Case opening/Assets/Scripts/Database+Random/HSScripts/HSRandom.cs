using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class HSRandom : MonoBehaviour {

	public List<HSCards> SelectedDatabase; 

	public Button OpenButton;
	public Button SaveButton;
	public Button BackButton;
	public Image Card1;
	public Image Card2;
	public Image Card3;
	public Image Card4;
	public Image Card5;
	public GameObject ImageGO1;
	public GameObject ImageGO2;
	public GameObject ImageGO3;
	public GameObject ImageGO4;
	public GameObject ImageGO5;
	public HSCards SelectedSkin;

	void SpawnCard(GameObject SelectedCard){
		float rndmNumber = Random.value;
		string SelectedType = "";
		if (rndmNumber < 0.01)
			SelectedType = "Legendary";
		else if (rndmNumber < 0.08)
			SelectedType = "Epic";
		else if (rndmNumber < 0.3)
			SelectedType = "Rare";
		else 
			SelectedType = "Common";

		bool hasBeenFound = false;

		int randomECard = Random.Range (0, SelectedDatabase.Count);
		for (int i = 0; i <= SelectedDatabase.Count; i++) {
			if (i == randomECard && SelectedDatabase[i].type == SelectedType) {
				hasBeenFound = true;
				Image CardFace = SelectedCard.GetComponent<Image> ();
				Sprite Sprite = Resources.Load<Sprite> ("Card Backs/Classic Back");
				CardFace.sprite = Sprite;
				SelectedCard.GetComponent<HSFlipper> ().SelectedCard = SelectedDatabase[i];
	
				Debug.Log (SelectedDatabase [i].name);

			}
			if (hasBeenFound != true && i == (SelectedDatabase.Count - 1)){
				randomECard = Random.Range (0, SelectedDatabase.Count);
				i = 0;
			}
		}
	}
		public void OnClick()
	{
		OpenButton.gameObject.SetActive (false);
		SaveButton.gameObject.SetActive (true);
		ImageGO1.gameObject.SetActive (true);
		ImageGO2.gameObject.SetActive (true);
		ImageGO3.gameObject.SetActive (true);
		ImageGO4.gameObject.SetActive (true);
		ImageGO5.gameObject.SetActive (true);
		BackButton.gameObject.SetActive (false);
		SpawnCard (ImageGO1);
		SpawnCard (ImageGO2);
		SpawnCard (ImageGO3);
		SpawnCard (ImageGO4);
		SpawnCard (ImageGO5);
	}
}
	
