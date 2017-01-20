using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class LOLDelete : MonoBehaviour {
	public Button OpenButton;
	public Button DeleteButton;
	public Button SaveButton;
	public GameObject ImageGO;
	public Image Chest;

	public void OnClick ()
	{
		OpenButton.gameObject.SetActive (true);
		DeleteButton.gameObject.SetActive (false);
		SaveButton.gameObject.SetActive (false);
		ImageGO.gameObject.SetActive (false);
		Chest.gameObject.SetActive (true);
	}

}
