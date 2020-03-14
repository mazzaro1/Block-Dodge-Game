using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    public float velocidade;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 20f);
    }

    // Update is called once per frame
    void Update()
    {
        //aumenta e diminui o tamanho do objeto no eixo x
        transform.localScale = new Vector2(Mathf.PingPong(Time.time, 1), transform.localScale.y);

        //movimenta o objeto no eixo y
        transform.Translate(new Vector2(0f, velocidade * Time.deltaTime));
    }
}
