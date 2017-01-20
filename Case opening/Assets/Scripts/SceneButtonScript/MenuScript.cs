using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class MenuScript : MonoBehaviour
{

    public void OnClick()
    {
        Debug.Log("Menu loaded");
        Application.LoadLevel("Menu Scene");

    }


}
