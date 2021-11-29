using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChecaColisao : MonoBehaviour
{
    [Header("Vida Jogador")]
    [SerializeField] int quantidadeCoracao;
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.CompareTag("Obstaculo"))
        {
            LevouDano();
            Destroy(other.gameObject);
        }
    }

    private void LevouDano()
    {
        quantidadeCoracao -= 1;
        UIManager.instance.DesativaCoracao(quantidadeCoracao);

        if(quantidadeCoracao == 0)
        {
            UIManager.instance.AtivaPainel();
        }
    }
}
