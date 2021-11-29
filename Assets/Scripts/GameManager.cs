using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Controla Dificuldade")]
    [SerializeField] float tempoEntreDificuldade;
    [SerializeField] float valorAumentadoDificuldade;

    private void Start()
    {
        InvokeRepeating(nameof(AumentaDificuldadeJogo), tempoEntreDificuldade, tempoEntreDificuldade);
    }
    void AumentaDificuldadeJogo()
    {
        float timeScale = Time.timeScale;
        timeScale += valorAumentadoDificuldade;
        timeScale = Mathf.Clamp(timeScale, 1, 3);
        Time.timeScale = timeScale;
    }
}
