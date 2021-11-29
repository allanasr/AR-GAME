using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    [Header("Componentes")]
    [SerializeField] Image[] coracoes;
    [SerializeField] GameObject painelRestart;
    
    private void Awake()
    {
        if(!instance)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    public void DesativaCoracao(int index)
    {
        coracoes[index].enabled = false;
    }

    public void RecarregaCena()
    {
        Time.timeScale = 1;
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    public void AtivaPainel()
    {
        painelRestart.SetActive(true);
        Time.timeScale = 0;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
