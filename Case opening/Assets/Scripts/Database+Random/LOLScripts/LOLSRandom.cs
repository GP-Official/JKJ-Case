using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class LOLSRandom : MonoBehaviour {
	public Image SpawnImage;
	public GameObject ImageGO;
	public Button OpenButton;
	public Button DeleteButton;
	public Button SaveButton;
	public Text RPtext;
	public Text text;
	public LOLSDatabase lolsData;
	public void OnClick()
	{
		OpenButton.gameObject.SetActive(false);
		DeleteButton.gameObject.SetActive (true);
		SaveButton.gameObject.SetActive (true);
		ImageGO.gameObject.SetActive (true);		
		int randomLOLSSkins = Random.Range (0, lolsData.sskins.Count );
		for (int i = 0; i <= lolsData.sskins.Count; i++) {
			if (i == randomLOLSSkins) {
				SpawnImage = ImageGO.GetComponent<Image> ();
				Sprite Sprite = Resources.Load<Sprite> ("LOL/Skins+Champions/" + lolsData.sskins [i].name);
				SpawnImage.sprite = Sprite;
				Debug.Log (lolsData.sskins [i].name);
				text.text = "" + lolsData.sskins [i].name;
				RPtext.text = lolsData.sskins [i].prize + "RP";
			}
		}					
	}

}
