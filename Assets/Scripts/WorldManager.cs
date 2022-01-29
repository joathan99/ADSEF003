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
        //Obtendremos los datos de nuestro terrain para posicionarlos sobre el terrain que tenemos
        TerrainData terrainData = terrain.terrainData;
        int objectsSpacing = 10;
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
