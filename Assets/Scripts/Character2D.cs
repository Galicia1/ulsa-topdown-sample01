using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character2D : MonoBehaviour
{
    //Encapsular pero seguir usandolo, para usar un get set para verlo en el inspector
    //si no quieres se vea en el inspector poner
    //float moveSpeed {get; set;}
   [SerializeField]
   float moveSpeed = 5f;
   void Update()
   {
       transform.Translate(Axis *2f * Time.deltaTime);
   }
    //funcion regresa un resultado
    Vector2 Axis
    {
        // get es exclusivo para regresar algo, la flecha indica lo que se intrucira en el paquetito
        get => new Vector2(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"));
    }
    public float MoveSpeed { get => moveSpeed; set => moveSpeed = value; }

    //forma insegura de hacerlo
    /*
    Vector2 Axis2()
    {
        return new Vector2();
    }
    */

}
