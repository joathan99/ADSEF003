using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Con esto podremos crear facilmente un asset desde Unity e introducirle la informacion que deseamos a dicho objeto.
[CreateAssetMenu(fileName = "Objeto", menuName = "Datos del Objeto", order = 51)]

//Usaremos ScriptableObject ppara almacenar datos compartidos independiente de instancias de scripts.
public class Objetos : ScriptableObject
{
    public enum RARITY { Comun, Raro, Curativo}

    [SerializeField]
    string _objectName;

    [SerializeField]
    RARITY _objectRarity;

    [SerializeField]
    Texture _icon;

    //Contructores para crear el objeto

    public string Name { get { return _objectName; } }
    public RARITY Rarity { get { return _objectRarity; } }
    public Texture Icon { get { return _icon; } }
}
