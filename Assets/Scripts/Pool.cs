using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class PoolItem
{
    public GameObject prefab;

    public int ca;
}

public class Pool : MonoBehaviour
{
    public static Pool singleton;

    public List<PoolItem> items;

    public List<GameObject> pooledItems;

    private void Awake()
    {
        if(singleton == null)
        {
            singleton = this;
        }
    }


    void Start()
    {
        pooledItems = new List<GameObject>();
        foreach(PoolItem item in items)
        {
            for(int i = 0; i < item.ca; i++)
            {
                GameObject obj = Instantiate(item.prefab);
                obj.SetActive(false);
                pooledItems.Add(obj);
            }
        }
    }

    public GameObject Get(string tag)
    {
        for(int i = 0; i < pooledItems.Count; i++)
        {
            if(!pooledItems[i].activeInHierarchy && pooledItems[i].tag ==tag)
            {
                return pooledItems[i];
            }
        }

        foreach(PoolItem item in items)
        {
            if(item.prefab.tag == tag)
            {
                GameObject obj = Instantiate(item.prefab);
                obj.SetActive(false);
                pooledItems.Add(obj);
                return obj;
            }
            
        }
        return null;
    }
    
}
