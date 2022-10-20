using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    [SerializeField]
    Button startButton;
    [SerializeField]
    Button controlsButton;

    private void Update()
    {
        startButton.onClick.AddListener(LoadGameScene);
        controlsButton.onClick.AddListener(LoadControlsScene);
    }
    void LoadGameScene()
    {
        SceneManager.LoadScene(1);
    }
    void LoadControlsScene()
    {
        SceneManager.LoadScene(2);
    }
}
