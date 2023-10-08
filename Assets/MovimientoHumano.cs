using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoHumano : MonoBehaviour
{
    public float velocidad = 5.0f; // Velocidad de movimiento del cubo

    void Update()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal"); // Captura la entrada horizontal (A/D)
        float movimientoVertical = Input.GetAxis("Vertical");     // Captura la entrada vertical (W/S)

        // Calcula el desplazamiento en la dirección horizontal y vertical
        Vector3 movimiento = new Vector3(movimientoHorizontal, 0.0f, movimientoVertical) * velocidad * Time.deltaTime;

        // Aplica el desplazamiento al cubo
        transform.Translate(movimiento);
    }
}
