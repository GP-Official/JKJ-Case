using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class CSGOCoin : MonoBehaviour {
	public float coinNumber = 0;
	public Text CoinText;
	public Text CoinText2;
	void Start () {
		//PlayerPrefs.DeleteAll();
		coinNumber = PlayerPrefs.GetFloat ("CSGOCoin", 0);
	}


	void Update () {
		CoinText.text = coinNumber.ToString ();
		CoinText2.text = coinNumber.ToString ();
	}

	public void OnDestroy (){
		PlayerPrefs.SetFloat ("CSGOCoin", coinNumber);
		PlayerPrefs.Save ();
	}
}