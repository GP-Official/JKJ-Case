using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class BackButton : MonoBehaviour {

	public Canvas MenuScene;
	public Canvas OpenScene;
	public Image WImage;
	public Image CImage;
	public Image GTImage;
	public Image GGImage;
	public Image EImage;
	public Image LImage;
	public Image MSGImage;
	public Button HSButton;

	public void OnClick()
	{
		OpenScene.gameObject.SetActive (false);
		MenuScene.gameObject.SetActive (true);
		WImage.gameObject.SetActive (false);
		CImage.gameObject.SetActive (false);
		GTImage.gameObject.SetActive (false);
		GGImage.gameObject.SetActive (false);
		EImage.gameObject.SetActive (false);
		LImage.gameObject.SetActive (false);
		MSGImage.gameObject.SetActive (false);
		HSButton.gameObject.SetActive (false);
			
	}
}