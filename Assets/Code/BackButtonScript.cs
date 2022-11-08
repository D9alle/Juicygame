using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//Theo
public class BackButtonScript : MonoBehaviour
{
    [SerializeField]
    Button BackButton;

    private void Start()
    {
        BackButton.onClick.AddListener(LoadMainMenuScene); //om man klicker p� knappen g�r den det ssom st�r p� LoadMainMenuScene()
    }
    void LoadMainMenuScene()
    {
        SceneManager.LoadScene(0); //laddar scene 0
    }
}
