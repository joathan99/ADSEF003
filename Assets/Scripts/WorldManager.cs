using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldManager : MonoBehaviour
{
    public GameObject[] objects;

    public Terrain terrain;

    void Start()
    {
        Objects();
    }



    void Objects()
    {
        //Obtendremos los datos donde se colocaran los objetos aleatoriamente y dejaremos un espacio entre ellos para que se queden muy pegados o uno encima del otro
        TerrainData terrainData = terrain.terrainData;
        int objectsSpacing = 50;
        for(int z = 0; z < terrainData.size.z; z += objectsSpacing)
        {
            for (int x = 0; x < terrainData.size.x; x += objectsSpacing)
            {
                Vector3 pos = new Vector3(x, 0, z);
                pos.y = terrain.SampleHeight(pos);
                int i = Random.Range(0, objects.Length);
                Instantiate(objects[i], pos, Quaternion.identity);
            }
        }
    }

    



    
}
