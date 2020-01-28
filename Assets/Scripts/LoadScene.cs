using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Invoke("LoadTheScene", 1f);
        }
    }

    public void LoadTheScene()
    {
        SceneManager.LoadScene(1);
    }
}
