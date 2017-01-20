using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class HSCoin : MonoBehaviour {
	public int coinNumber = 0;
	public Text CoinText;
	public Text CoinText2;
	void Start () {
		//PlayerPrefs.DeleteAll();
		coinNumber = PlayerPrefs.GetInt ("HSCoin", 0);
	}


	void Update () {
		CoinText.text = coinNumber.ToString ();
		CoinText2.text = coinNumber.ToString ();
	}

	public void OnDestroy (){
		PlayerPrefs.SetInt ("HSCoin", coinNumber);
		PlayerPrefs.Save ();
	}

}
