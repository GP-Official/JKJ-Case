using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class SceneChanger : MonoBehaviour
{
	public Canvas ChangeScene;
	public Canvas DeleteScene;

	public void OnClick()
	{
		if (DeleteScene.name == "Inventory") {
			foreach (Transform tr in DeleteScene.gameObject.transform) {
				if (tr.name == "ScriptHandler") {
					LOLInventory inv = tr.GetComponent<LOLInventory> ();
					inv.DeleteSlots ();
				}
			}
		}
		if (DeleteScene.name == "Shop") {
			foreach (Transform tr in DeleteScene.gameObject.transform) {
				if (tr.name == "ScriptHandler") {
					LOLShop shop = tr.GetComponent<LOLShop> ();
					shop.DeleteSlots ();
				}
			}
		}	
		//if (DeleteScene.name == "Collection") {
			//foreach (Transform tr in DeleteScene.gameObject.transform) {
				//if (tr.name == "ScriptHandler") {
					//HSShop hsshop = tr.GetComponent<HSShop> ();
					//hsshop.DeleteSlots ();
				//}
			//}
		//}	
		if (DeleteScene.name == "HSShop") {
			foreach (Transform tr in DeleteScene.gameObject.transform) {
				if (tr.name == "ScriptHandler") {
					HSShop hsshop = tr.GetComponent<HSShop> ();
					hsshop.DeleteSlots ();
				}
			}
		}
			if (DeleteScene.name == "CSShop") {
				foreach (Transform tr in DeleteScene.gameObject.transform) {
					if (tr.name == "ScriptHandler") {
						CSShop csshop = tr.GetComponent<CSShop> ();
						csshop.DeleteSlots ();
					}
				}
		}	

		ChangeScene.gameObject.SetActive (true);
		DeleteScene.gameObject.SetActive (false);
		
		}

}
