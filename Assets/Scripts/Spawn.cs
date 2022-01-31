using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject NormalPrefab;
    public GameObject PeligroPrefab;
    public GameObject CuracionPrefab;
    public Terrain terrain;
    TerrainData terrainData;


    void Start()
    {
        terrainData = terrain.terrainData;
        Invoke("CreateNormal", 10);
        Invoke("CreateCuracion", 10);
        Invoke("CreatePeligro", 10);


    }


    void CreateNormal()
    {
        int x = (int)Random.Range(0, terrainData.size.x);
        int z = (int)Random.Range(0, terrainData.size.z);
        Vector3 pos = new Vector3(x, 0, z);
        pos.y = terrain.SampleHeight(pos) + 1.2f;
        GameObject normal = Instantiate(NormalPrefab, pos, Quaternion.identity);
    }

    void CreateCuracion()
    {
        int x = (int)Random.Range(0, terrainData.size.x);
        int z = (int)Random.Range(0, terrainData.size.z);
        Vector3 pos = new Vector3(x, 0, z);
        pos.y = terrain.SampleHeight(pos) + 1.2f;
        GameObject curacion = Instantiate(CuracionPrefab, pos, Quaternion.identity);
    }

    void CreatePeligro()
    {
        int x = (int)Random.Range(0, terrainData.size.x);
        int z = (int)Random.Range(0, terrainData.size.z);
        Vector3 pos = new Vector3(x, 0, z);
        pos.y = terrain.SampleHeight(pos) + 1.2f;
        GameObject peligro = Instantiate(PeligroPrefab, pos, Quaternion.identity);
    }
}
