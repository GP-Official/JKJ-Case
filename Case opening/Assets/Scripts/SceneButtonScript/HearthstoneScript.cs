using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class HearthstoneScript : MonoBehaviour
{

    public void OnClick()
    {
        Debug.Log("Hearthstone loaded");
        Application.LoadLevel("Hearthstone Menu Scene");

    }


}
