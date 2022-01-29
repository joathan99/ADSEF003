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
        //Cuando hagamos clic accederemos a los datos que nos proporciona dicho objeto y se mostraran en pantalla
        io.OpenPanel();
        io.ObjName.text = info.Name;
        io.rarityLevel.text = info.Rarity.ToString();
        io.objImage.GetComponent<Image>().sprite = info.Icon;
    }



}
