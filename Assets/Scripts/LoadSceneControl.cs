using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadSceneControl : MonoBehaviour
{

    public string levelToLoad;
    // Start is called before the first frame update
    // Update is called once per frame

    public void LoadScene()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}

