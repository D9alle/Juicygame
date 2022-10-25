using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControlsButtonScript : MonoBehaviour
{
    [SerializeField]
    Button controlsButton;

    private void Update()
    {
        controlsButton.onClick.AddListener(LoadControlsScene);
    }
    void LoadControlsScene()
    {
        SceneManager.LoadScene(2);
    }
}