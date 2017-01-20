using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class HSOpenChange : MonoBehaviour {

	public Canvas MenuScene;
	public Canvas OpenScene;
	public Image OpenImage;
	public Button OpenButton;
	public void OnClick()
	{
		OpenScene.gameObject.SetActive (true);
		MenuScene.gameObject.SetActive (false);
		OpenImage.gameObject.SetActive (true);
		OpenButton.gameObject.SetActive (true);

	}
}
