using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    [Tooltip("In seconds")][SerializeField] float loadDelay = 2.5f;

    // Use this for initialization
    void Start()
    {
        Invoke("LoadFirstScene", loadDelay);
    }

    void LoadFirstScene()
    {
        SceneManager.LoadScene(1);
    }
}
