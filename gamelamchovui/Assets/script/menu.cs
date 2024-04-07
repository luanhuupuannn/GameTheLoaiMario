using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class menu : MonoBehaviour
{
 public void Play()
    {
        SceneManager.LoadScene(2);
    }
  public  void Exit()
    {
        Application.Quit();
    }
    public void ExitMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Playgame1()
    {
        SceneManager.LoadScene(2);
    }

}
