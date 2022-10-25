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

    private void Update()
    {
        BackButton.onClick.AddListener(LoadGameScene); //om man klicker på knappen gör den det ssom står på LoadGameScene()
    }
    void LoadGameScene()
    {
        SceneManager.LoadScene(1); //laddar scene 1
    }
}
