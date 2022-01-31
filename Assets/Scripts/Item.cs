using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    //Hacemos referencia para poder obtener datos de los diferentes spcrits y poder usarlos en este.
    [SerializeField] Objetos info;
    InfoObjetos io;

    public Event dropped;
    public SpriteRenderer icon;

    void Start()
    {
        io = GameObject.FindGameObjectWithTag("InfoObjeto").GetComponent<InfoObjetos>();
        dropped.Occurred(this.gameObject);
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
