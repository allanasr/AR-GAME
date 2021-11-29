using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaSpawn : MonoBehaviour
{
    [SerializeField] GameObject prefabObstaculo;
    [SerializeField] Transform[] posicoes;

    [SerializeField] float tempoEntreObstaculos;

    float tempo;
    // Start is called before the first frame update
    void Start()
    {
        SpawnObstaculo();
    }

    // Update is called once per frame
    void Update()
    {
        tempo += Time.deltaTime;

        if (tempo > tempoEntreObstaculos)
        {
            tempo = 0;
            SpawnObstaculo();
        }

    }

    void SpawnObstaculo()
    {
        int random = Random.Range(0, posicoes.Length);

        Instantiate(prefabObstaculo, posicoes[random].position , Quaternion.identity);
    }
}
