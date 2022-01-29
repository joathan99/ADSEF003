using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Objeto : MonoBehaviour
{

    [SerializeField] Objetos info;
    InfoObjetos io;


    // Start is called before the first frame update
    void Start()
    {
        io = GameObject.FindGameObjectWithTag("InfoObjeto").GetComponent<InfoObjetos>();
    }

    private void OnMouseDown()
    {
        io.OpenPanel();
        io.ObjName.text = info.Name;
        io.rarityLevel.text = info.Rarity.ToString();
        io.objImage.GetComponent<RawImage>().texture = info.Icon;
    }



}
