using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPala : MonoBehaviour
{
    public float velocidad;
    public bool JugadorB;
    // Start is called before the first frame update
    //float= numero decimal; bool=true/false
    //El simbolo "=" se pude usar para modificar un imput anterior
    //Debut.Log = rescata una varieble
    //if + () =ejecuta la orden de "bool", si es "true" lo ejecuta y si no ejecuta lo que está dentro del "else"
    //Input.GatAxis = depende de la orden del teclado ejecuta lo que pongas en parentesis
    //transform.position = es una suma de direccion y posicion que sirve para el movimiento del objeto

    void Start()
    {}
    // Update is called once per frame
    void Update()
    {
        float vertical = 0;
        float horizontal = 0;
       
        if (JugadorB)
        {
             vertical = Input.GetAxis("Vertical B");
             horizontal = Input.GetAxis("Horizontal B");

        }
        else
        {
             vertical = Input.GetAxis("Vertical A");
             horizontal = Input.GetAxis("Horizontal A");
        }

        transform.position = transform.position + new Vector3(horizontal,vertical,0) * velocidad * Time.deltaTime;
        
    }
}
