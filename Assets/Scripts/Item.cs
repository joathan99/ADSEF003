using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public Event dropped;
    public SpriteRenderer icon;

    void Start()
    {
        dropped.Occurred(this.gameObject);
    }


    void Update()
    {
        
    }
}
