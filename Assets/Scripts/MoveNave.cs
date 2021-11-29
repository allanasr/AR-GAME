using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNave : MonoBehaviour
{
    [Header("Componentes")]
    [SerializeField] Rigidbody _rigidbody;

    [Header("Variáveis")]
    [SerializeField] float velocidadeMovimento;
    [SerializeField] float rotacaoEsquerda;
    [SerializeField] float rotacaoDireita;
    [SerializeField] float velocidadeRotacao;

    float rotacaoZ;
    Vector3 direcao;

    // Update is called once per frame
    void Update()
    {
        
        if(Input.touchCount>0)
        {
            Touch touch = Input.GetTouch(0);
            if(touch.position.x > Screen.width /2)
            {
                direcao = Vector3.right;
                rotacaoZ = Mathf.Lerp(rotacaoZ, rotacaoDireita, Time.deltaTime * velocidadeRotacao);
            }  
            else if(touch.position.x < Screen.width /2)
            {
                direcao = -Vector3.right;
                rotacaoZ = Mathf.Lerp(rotacaoZ, rotacaoEsquerda, Time.deltaTime * velocidadeRotacao);
            }
            else
            {
                direcao = Vector3.zero;
                rotacaoZ = Mathf.Lerp(rotacaoZ, 0, Time.deltaTime * velocidadeRotacao);
            }
        }
        
        transform.eulerAngles = new Vector3(0, 0, rotacaoZ);
    }

    private void FixedUpdate()
    {
        _rigidbody.velocity = Time.fixedDeltaTime * velocidadeMovimento * direcao;
    }
}
