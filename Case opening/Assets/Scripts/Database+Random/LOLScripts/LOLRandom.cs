using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class LOLRandom : MonoBehaviour {
	public Image SpawnImage;
	public GameObject ImageGO;
	public Image Case;
	public Button OpenButton;
	public Button DeleteButton;
	public Button SaveButton;
	public Text RPtext;
	public Text text;
	public Image Border;
	public GameObject BorderCon;
	public LOLDatabase lolData;
	public LOLSkins SelectedSkin;
	public Animator anim;

	float timer= 1.5175f;
	bool Spawner = false;

	void Start ()
	{
		anim.enabled = false;
	}
	public void OnClick()
	{
		Spawner = true;
		anim.enabled = true;
	}
	public void Update()
	{

		if (Spawner == true) {
			timer -= Time.deltaTime;
			if (timer <= 0) {
				SpawnCards();
				timer = 1.5175f;
				Case.gameObject.SetActive (false);
				anim.enabled = false;
				Spawner = false;
			}
		} 
	}
	public void SpawnCards()
	{
		ImageGO.gameObject.SetActive (true);	
		DeleteButton.gameObject.SetActive (true);
		SaveButton.gameObject.SetActive (true);
		OpenButton.gameObject.SetActive (false);

		int randomLOLSkins = Random.Range (0, lolData.skins.Count );
		for (int i = 0; i <= lolData.skins.Count; i++) {
			if (i == randomLOLSkins) {
				SelectedSkin = lolData.skins [i];
				SpawnImage = ImageGO.GetComponent<Image> ();
				Sprite Sprite = Resources.Load<Sprite> ("LOL/Skins+Champions/" + lolData.skins [i].name);
				SpawnImage.sprite = Sprite;
				text.text = "" + lolData.skins [i].name;
				RPtext.text = lolData.skins [i].prize + "RP";
				string SelectedBorder = ""; 
				if (lolData.skins [i].prize == 3250)
					SelectedBorder = "Ultimate";
				else if (lolData.skins [i].prize == 1820)
					SelectedBorder = "Legendary";
				else
					SelectedBorder = "Common";
			
				Border = BorderCon.GetComponent<Image> ();
				Sprite BorderSprite = Resources.Load<Sprite> (SelectedBorder);
				Border.sprite = BorderSprite;
			}
		}
	}
}
