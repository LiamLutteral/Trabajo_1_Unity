
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dani : MonoBehaviour
{
    int edadUsuario;
    float sueldousuario;
    string domicilio;
    bool estaAprobado;
    // Start is called before the first frame update
    void Start()
    {
        edadUsuario = 45;
        sueldousuario = 1000.00f;
        domicilio = "quesadas 1553";
        estaAprobado = true;

        Debug.Log(edadUsuario);
        Debug.Log(sueldousuario);
        Debug.Log(domicilio);
        Debug.Log(estaAprobado);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
