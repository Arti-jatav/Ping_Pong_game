using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesMangager : MonoBehaviour
{
    // Start is called before the first frame update
    public void MoveT0Scene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
    void Quit()
    {
        Application.Quit();
    }
    void Play()
    {
        SceneManager.LoadScene(1);
    }
  
}
