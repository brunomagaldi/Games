using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int pontuacaoDoJogador1;
    public int pontuacaoDoJogador2;
    public Text textoDePontuacao;
    public Text textoWin;
    public int SetDoJogador1;
    public int SetDoJogador2;
    
    public AudioSource somDoGol;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("Saiu do jogo");
        }

    }

    public void AumentarPontoSets()
    {
        if (SetDoJogador2 == 2 && SetDoJogador1 == 0)
        {
            SetDoJogador1 = 0;
            SetDoJogador2 = 0;
            textoWin.text = "Jogador 2 Win!!";
        }
        else if (SetDoJogador1 == 2 && SetDoJogador2 == 0)
        {
            SetDoJogador1 = 0;
            SetDoJogador2 = 0;
            textoWin.text = "Jogador 1 Win!!";
        }
        else if (SetDoJogador1 == 2 && SetDoJogador2 == 1)
        {
            SetDoJogador1 = 0;
            SetDoJogador2 = 0;
            textoWin.text = "Jogador 1 Win!!";
        }
        else if (SetDoJogador2 == 2 && SetDoJogador1 == 1)
        {
            SetDoJogador1 = 0;
            SetDoJogador2 = 0;
            textoWin.text = "Jogador 2 Win!!";
        }
    }


    public void AumentarPontuacaoDoJogador1()
    {
        pontuacaoDoJogador1 += 1;
        if(pontuacaoDoJogador1 == 10)
        {
            SetDoJogador1 += 1;
            pontuacaoDoJogador1 = 0;
            pontuacaoDoJogador2 = 0;
        }
        AtualizarTextoDePontuacao();
        AumentarPontoSets();

    }
    public void AumentarPontuacaoDoJogador2()
    {
        pontuacaoDoJogador2 += 1;
        if(pontuacaoDoJogador2 == 10)
        {
            SetDoJogador2 += 1;
            pontuacaoDoJogador1 = 0;
            pontuacaoDoJogador2 = 0;
        }
        AtualizarTextoDePontuacao();
        AumentarPontoSets();
    }

    public void AtualizarTextoDePontuacao()
    {
        textoDePontuacao.text = pontuacaoDoJogador1 + " X " + pontuacaoDoJogador2 + "\n" + SetDoJogador1 + "X" + SetDoJogador2;
        
        somDoGol.Play(); //inclusão do som
    }
}
