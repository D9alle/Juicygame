using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartButtonScript : MonoBehaviour
{
    [SerializeField]
    Button startButton;

    private void Update()
    {
        startButton.onClick.AddListener(LoadGameScene);
    }
    void LoadGameScene()
    {
        SceneManager.LoadScene(1);
    }
}
