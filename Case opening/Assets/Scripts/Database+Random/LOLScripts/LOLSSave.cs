using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class LOLSSave : MonoBehaviour {
	public Button OpenButton;
	public Button DeleteButton;
	public Button SaveButton;
	public GameObject ImageGO;

	public void OnClick ()
	{
		OpenButton.gameObject.SetActive (true);
		DeleteButton.gameObject.SetActive (false);
		SaveButton.gameObject.SetActive (false);
		ImageGO.gameObject.SetActive (false);
	}
}
