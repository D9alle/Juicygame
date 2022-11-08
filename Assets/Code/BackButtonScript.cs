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
        BackButton.onClick.AddListener(LoadMainMenuScene); //om man klicker på knappen gör den det ssom står på LoadMainMenuScene()
    }
    void LoadMainMenuScene()
    {
        SceneManager.LoadScene(0); //laddar scene 0
    }
}
