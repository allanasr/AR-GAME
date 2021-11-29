using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstaculo : MonoBehaviour
{
    [SerializeField] float velocidadeMovimento;
    ParticleSystem efeitoParticula;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.z -= Time.deltaTime * velocidadeMovimento;
        transform.position = pos;
    }
}
