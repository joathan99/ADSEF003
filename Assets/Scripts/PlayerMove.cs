using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    public Animator transAnim;
    public string NextScene;

    public CharacterController controller;
    public float speed = 5;

    public float turnSmoothTime = 0.1f;

    float turnSmoothVelocity;

    public Transform cam;
    //public int[] can;
    //public Text[] caRe;

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            //Rotacion del personaje
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;

            //Suavizar el movimiento del jugador para que no sea tan brusco el movimento 
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);

            //Para que el personaje se mueva en la direccion a la que camara esta apuntando
            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f)* Vector3.forward;

            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            //Movomiento
            controller.Move(moveDir.normalized * speed * Time.deltaTime);
        }

    }

    

    private void OnTriggerEnter(Collider other)
    {
        //Creamos la condicion para que cuando el jugador entre en el trigger, cargue la siguiente escena.
        if (other.tag == "Salida")
        {
            StartCoroutine(nextScene());
        }
    }





    IEnumerator nextScene()
    {
        transAnim.SetTrigger("End");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(NextScene, LoadSceneMode.Single);
    }
}
