using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Case : MonoBehaviour
{

	public Canvas MenuScene;
	public Canvas OpenScene;
	public GameObject CasePanel;
	public void OnClick()
	{

		MenuScene.gameObject.SetActive (false);
		OpenScene.gameObject.SetActive (true);
		CasePanel.gameObject.SetActive (true);
	}


}
