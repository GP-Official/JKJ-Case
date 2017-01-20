using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class CSGOScript : MonoBehaviour
{

    public void OnClick()
    {
        Debug.Log("CSGO loaded");
        Application.LoadLevel("Counter Strike Menu Scene");

    }


}