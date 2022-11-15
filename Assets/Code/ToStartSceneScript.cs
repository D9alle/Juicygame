using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//Theo
public class ToStartSceneScript : MonoBehaviour
{
    [SerializeField]
    Button toStartScene;

    private void Start()
    {
        toStartScene.onClick.AddListener(LoadMainMenuScene); //om man klickar på knappen gör den det ssom står på LoadMainMenuScene()
    }
    void LoadMainMenuScene()
    {
        SceneManager.LoadScene(0); //laddar scene 0
    }
}
