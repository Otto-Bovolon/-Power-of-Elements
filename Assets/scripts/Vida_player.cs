using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida_player : MonoBehaviour
{
    private int vidaAtual;
    private int vidaTotal = 100;

    [SerializeField]private Barra_vida BarraDeVida;
    private void Start()
    {
        vidaAtual = vidaTotal;

        BarraDeVida.AlterarBarraDeVida(vidaAtual,  vidaTotal);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AplicarDano(10);
        }
    }
    private void AplicarDano (int dano)
    {
        vidaAtual -= 10;
        BarraDeVida.AlterarBarraDeVida(vidaAtual, vidaTotal);
    }
}
