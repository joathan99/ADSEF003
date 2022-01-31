using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RadarObject
{
    public SpriteRenderer icon { get; set; }
    public GameObject owner { get; set; }
}
public class Radar : MonoBehaviour
{
    public Transform playerPos;


    
    public static List<RadarObject> radObjects = new List<RadarObject>();

    public static void RegisterRadarObject(GameObject o, SpriteRenderer i)
    {
        SpriteRenderer sprite = Instantiate(i);
        radObjects.Add(new RadarObject() { owner = o, icon = sprite });
    }



    void DrawRadarDots()
    {
        foreach (RadarObject ro in radObjects)
        {
            Vector3 radarPos = (ro.owner.transform.position - playerPos.position);

            ro.icon.transform.SetParent(this.transform);
            RectTransform rt = this.GetComponent<RectTransform>();
            ro.icon.transform.position = new Vector3(radarPos.x + rt.pivot.x, radarPos.z + rt.pivot.y, -0.5f) + this.transform.position;
        }
    }

    void Update()
    {
        DrawRadarDots();
    }

    public void ItemDropped(GameObject go)
    {
        RegisterRadarObject(go, go.GetComponent<Item>().icon);
    }
}
