using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GGSave : MonoBehaviour {
	public Button OpenButton;
	public Button SaveButton;
	public GameObject ImageGO1;
	public GameObject ImageGO2;
	public GameObject ImageGO3;
	public GameObject ImageGO4;
	public GameObject ImageGO5;
	public Button BackButton;
	public void OnClick()
	{
		OpenButton.gameObject.SetActive (true);
		SaveButton.gameObject.SetActive (false);
		ImageGO1.gameObject.SetActive (false);
		ImageGO2.gameObject.SetActive (false);
		ImageGO3.gameObject.SetActive (false);
		ImageGO4.gameObject.SetActive (false);
		ImageGO5.gameObject.SetActive (false);
		BackButton.gameObject.SetActive (true);
	}
}