using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
  public LayerMask Player;
  public string desiredScene;

    // Update is called once per frame
    void Update()
    {
      if(Physics2D.OverlapCircle(transform.position, 1f,Player)){
        SceneManager.LoadScene(desiredScene);
      }


    }
}
