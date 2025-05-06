using System.Collections;
using UnityEngine;

public class PainelCristaisUI : MonoBehaviour
{
    public GameObject painelMensagem;
    public float tempoNaTela = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MostrarPainel();
    }

    // Update is called once per frame
    public void MostrarPainel() { 
    painelMensagem.SetActive(true);
        StartCoroutine(EsconderPainelDepois());
    }

    private IEnumerator EsconderPainelDepois()
    {
        yield return new WaitForSeconds(tempoNaTela);
        painelMensagem.SetActive(false);
    }
}
