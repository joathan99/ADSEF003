using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoObjetos : MonoBehaviour
{
    public GameObject objInfoPanel;
    public GameObject objImage;
    public Text ObjName;
    public Text rarityLevel;

    public void OpenPanel()
    {
        objInfoPanel.SetActive(true);
    }
    public void closePanel()
    {
        objInfoPanel.SetActive(false);
    }

}
