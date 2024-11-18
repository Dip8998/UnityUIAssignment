using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    public Button button;
    public string backSceneName;
    void Start()
    {
        button.onClick.AddListener(OnButtonClick);
    }
    public void OnButtonClick()
    {
        Debug.Log("Back Button Pressed!");
        SceneManager.LoadScene(backSceneName);

    }
}
