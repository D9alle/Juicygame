using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//Theo
public class StartButtonScript : MonoBehaviour
{
    [SerializeField]
    Button startButton;

    private void Start()
    {
        startButton.onClick.AddListener(LoadGameScene); //om man klicker på knappen gör den det ssom står på LoadGameScene()
    }
    void LoadGameScene()
    {
        SceneManager.LoadScene(1); //laddar scene 1
    }
}
