using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//Theo
public class ControlsButtonScript : MonoBehaviour
{
    [SerializeField]
    Button controlsButton;

    private void Start()
    {
        controlsButton.onClick.AddListener(LoadControlsScene); //om man klicker på knappen gör den det ssom står på LoadControlsScene()
    }
    void LoadControlsScene()
    {
        SceneManager.LoadScene(2); //laddar scene 2
    }
}