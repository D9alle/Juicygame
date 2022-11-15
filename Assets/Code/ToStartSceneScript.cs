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
        toStartScene.onClick.AddListener(LoadMainMenuScene); //om man klickar p� knappen g�r den det ssom st�r p� LoadMainMenuScene()
    }
    void LoadMainMenuScene()
    {
        SceneManager.LoadScene(0); //laddar scene 0
    }
}
