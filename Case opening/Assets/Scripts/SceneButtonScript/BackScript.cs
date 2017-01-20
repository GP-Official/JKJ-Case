using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class BackScript : MonoBehaviour
{
	public Canvas MenuScene;
	public Canvas OpenScene;

	public void OnClick()
    {
		foreach (Transform tr in OpenScene.transform)
			if (tr.tag == "Panel")
				tr.gameObject.SetActive (false);
		MenuScene.gameObject.SetActive (true);
		OpenScene.gameObject.SetActive (false);

	}
}
