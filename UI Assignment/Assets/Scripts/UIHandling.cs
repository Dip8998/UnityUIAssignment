using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIHandling : MonoBehaviour
{
    public Button button;
    public string sceneName;
    void Start()
    {
        button.onClick.AddListener(OnButtonClick);
    }
    public void OnButtonClick()
    {
        Debug.Log("Button pressed!");
        SceneManager.LoadScene(sceneName);
    }
}
