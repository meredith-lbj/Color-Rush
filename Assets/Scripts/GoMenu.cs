using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GoMenu : MonoBehaviour
{
    public void ReStart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quit() {
        Application.Quit();
    }

    public void Restart_from_end() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void Restart_from_level() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
}
