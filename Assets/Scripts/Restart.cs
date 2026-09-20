using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(UnityEngine.UI.Button))]
public class Restart : MonoBehaviour
{
    [Header("Scene to load when the button is clicked")]
        [SerializeField] private string sceneToLoad = "_Scene_0";

    // Start is called before the first frame update

    // Update is called once per frame

    public void HideScene(string)
    {
        
    }
    private void Start()
    {        
        
    }
    private void RestartGameOnClick()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
