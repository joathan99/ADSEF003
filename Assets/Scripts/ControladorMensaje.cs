using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorMensaje : MonoBehaviour
{
    Text message;
    void Start()
    {
        message = this.GetComponent<Text>();
        message.enabled = false;
    }

    public void SetMessage(GameObject go)
    {
        message.text = "Recogido el objeto";
        message.enabled = true;
        Invoke("TurnOff", 2);
    }

    void TurnOff()
    {
        message.enabled = false;
    }
    
}
