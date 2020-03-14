using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    //referencia objeto prefab a ser instanciado na cena
    public GameObject plataformaPrefab;

    //variavel de controle para o tempo
    float tempo;
    //variavel para contador de tempo minimo
    public float tempoMin;
    //variavel para contador de tempo maximo
    public float tempoMax;
    //variavel que recebe resultado random entre min e max
    float tempoTotal;
    
    
    void Start()
    {
        //tempoTotal recebe valor randomico entre tempomMin e tempoMax
        tempoTotal = Random.Range(tempoMin, tempoMax);
    }

    
    void Update()
    {
        //aqui o tempo é somado em tempo real
        tempo += Time.deltaTime;

        //contador de tempo
        if(tempo >= tempoTotal)
        {
            //instancia um novo objeto na cena
            Instantiate(plataformaPrefab, transform.position, transform.rotation);
            tempoTotal = Random.Range(tempoMin, tempoMax);
            tempo = 0f;
        }
    }
}
