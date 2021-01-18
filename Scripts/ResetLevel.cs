using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetLevel : MonoBehaviour
{
    // Update is called once per frame
    public string level;
    void Update()
    {
        
        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene(level);
        }
        
    }
}
