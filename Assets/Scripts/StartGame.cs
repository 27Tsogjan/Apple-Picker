using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(UnityEngine.UI.Button))]
public class StartGame: MonoBehaviour
{
    [Header("Scene to load when the button is clicked")]
    [SerializeField] private string sceneToLoad = "_Scene_0";

    // Start is called before the first frame update
    private void Start()
    {        
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(StartGameOnClick);
    }

    private void StartGameOnClick()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
