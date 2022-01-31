using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Singleton para poder tener una instancia unica que nos permita acceder desde cualquier lugar.
public class ObjPerm : MonoBehaviour
{
    public static ObjPerm inst;


    private void Awake()
    {

        if (ObjPerm.inst == null)
        {
            
            ObjPerm.inst = this;
            //Hacer que se conserve el gameobject aunque cambiemos de escena
            DontDestroyOnLoad(gameObject);
        }

        else
        {
            //Al tener ya una instancia y evitara que se cree otra y la destruira.
            Destroy(gameObject);
        }
        
    }
}
