using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MainMenu : MonoBehaviour
{
    public void ToggleButton(GameObject obj)
    {
        obj.GetComponent<Button>().interactable
        = !obj.GetComponent<Button>().interactable;
    }

    public void MyTestButton()
    {
        print("hej");
    }
}