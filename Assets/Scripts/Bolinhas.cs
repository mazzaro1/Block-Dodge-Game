using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolinhas : MonoBehaviour
{
    //variavel que pega referencia do objeto RotacionarBolas
    public RotacionarBolas controlador;

    //Esse metodo é chamado todas as vezes que a bolinha bate em algum objeto na cena
    void OnCollisionEnter2D(Collision2D colisor)
    {
        //se bater em um objeto com a tag Ponto-
        if(colisor.gameObject.tag == "Ponto")
        {
            //soma ponto
            Destroy(colisor.gameObject);
            controlador.AtualizarPontuacao();
        }

        //se bater em um objeto com a tag Plataforma
        if (colisor.gameObject.tag == "Plataforma")
        {
            //game over
            controlador.ChamarGameOver();
        }
    }
}
