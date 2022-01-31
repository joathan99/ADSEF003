using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject[] ObjectsPrefab;

    public GameObject exitPrefab;

    //public GameObject NormalPrefab;
    //public GameObject PeligroPrefab;
    //public GameObject CuracionPrefab;
    public Terrain terrain;
    TerrainData terrainData;


    void Start()
    {
        terrainData = terrain.terrainData;
        //Invoke("CreateNormal", 10);
        //Invoke("CreateCuracion", 10);
        //Invoke("CreatePeligro", 10);
        InvokeRepeating("CreateObjects", 1, 50);
        Invoke("CreateSalida", 1);


    }





    void CreateObjects()
    {
        int x = (int)Random.Range(0, terrainData.size.x);
        int z = (int)Random.Range(0, terrainData.size.z);
        Vector3 pos = new Vector3(x, 0, z);
        pos.y = terrain.SampleHeight(pos) + 1.2f;
        int i = Random.Range(0, ObjectsPrefab.Length);
        GameObject Ob = Instantiate(ObjectsPrefab[i], pos, Quaternion.identity);
    }

    void CreateSalida()
    {
        int x = (int)Random.Range(0, terrainData.size.x);
        int z = (int)Random.Range(0, terrainData.size.z);
        Vector3 pos = new Vector3(x, 0, z);
        pos.y = terrain.SampleHeight(pos) + 1.2f;
        GameObject exit = Instantiate(exitPrefab, pos, Quaternion.identity);
    }





}
