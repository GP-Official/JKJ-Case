using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class LOLScript : MonoBehaviour
{

    public void OnClick()
    {
        Debug.Log("League of Legends loaded");
        Application.LoadLevel("League of Legends Menu Scene");

    }


}