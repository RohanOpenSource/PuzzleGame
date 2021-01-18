using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
  public Button play;
  public Text playtext;
    void Start()
    {
      play.onClick.AddListener(TaskOnClick);

    }
    void TaskOnClick()
    {
      playtext.text="Loading...";
      SceneManager.LoadScene(1);
    }
}
