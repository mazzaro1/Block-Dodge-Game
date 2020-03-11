using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RotacionarBolas : MonoBehaviour
{
    //velocidade do movimento
    public float velocidade;
    //controle da direcao
    bool direita = false;

    //objeto que e o gameover
    public GameObject gameOver;
    //sua pontuacao
    public int pontuacao;

    //objeto text que referencia o texto
    public Text pontuacaoTexto;


    void Update()
    {
        //se clicar com o botão esquerdo do mouse
        if(Input.GetMouseButtonDown(0))
        {
            //inverte valor do booleno
            direita = !direita;
        }

        //se o boleeano for falso
        if(direita == false)
        {
            //se a condicao for atendida, executa isso aqui
            transform.Rotate(new Vector3(0f, 0f, velocidade * Time.deltaTime));
        }
        else
        {
            //se a condicao nao for atendida, executa isso aqui
            transform.Rotate(new Vector3(0f, 0f, -velocidade * Time.deltaTime));
        }

        
    }

    //metodo que ativa o objeto do gameover
    public void ChamarGameOver()
    {
        gameOver.SetActive(true);
    }

    //metodo que recarrega a cena
    public void ReiniciarGame()
    {
        SceneManager.LoadScene(0);
    }

    //metodo que atualiza a pontuacao
    public void AtualizarPontuacao()
    {
        pontuacao++;
        pontuacaoTexto.text = pontuacao.ToString(); 
    }

}
