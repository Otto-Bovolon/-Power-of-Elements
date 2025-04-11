using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Barra_vida : MonoBehaviour
{
    [SerializeField]private Image BarraDeVidaImagem;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AlterarBarraDeVida (int VidaAtual, int VidaMaxima)
    {
        BarraDeVidaImagem.fillAmount = (float)VidaAtual / VidaMaxima;
    }
}
