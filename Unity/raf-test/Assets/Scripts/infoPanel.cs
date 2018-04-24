using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infoPanel : MonoBehaviour {

    public GameObject Panel;

    void Start()
    {
        Panel.SetActive(false);
    }


    public void TogglePanel()
    {
        Panel.SetActive(!Panel.activeSelf);
    }
}
