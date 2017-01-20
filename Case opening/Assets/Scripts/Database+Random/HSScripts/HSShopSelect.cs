using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HSShopSelect : MonoBehaviour {

	public HSCards SelectedSkin;
	public Image Icon;

	void Start () {

	}
	void Update()
	{
		if (SelectedSkin != null) {
			Icon.GetComponent<Image> ().sprite = Resources.Load<Sprite> ("HS/" + SelectedSkin.name);
		}
	}
}

