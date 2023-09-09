using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManagers : MonoBehaviour
{
    // Start is called before the first frame update
    public void ClickToRetry()
    {
        Debug.Log("Ngulang");
        SceneManager.LoadScene(2);
    }

    // Update is called once per frame
    public void ClickToQuit()
    {
        Debug.Log("Keluar");
        Application.Quit(); 
    }

    public void ClickToStart()
    {
        SceneManager.LoadScene(2);
    }

    public void ToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
