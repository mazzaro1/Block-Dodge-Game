using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarraPonto : MonoBehaviour
{
    //velocidade da barra
    public float velocidade;

    
    void Update()
    {
        //movimenta a barra de acordo com a velocidade
        transform.Translate(new Vector2(0f, velocidade * Time.deltaTime));
    }
}
