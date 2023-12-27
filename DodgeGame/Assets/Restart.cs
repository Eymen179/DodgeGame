using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{
    public void RestartEvent()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        healthBar.health = 3;
        Time.timeScale = 1;
    }
}
