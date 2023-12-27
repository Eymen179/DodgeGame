using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class healthBar : MonoBehaviour
{
    public static int health = 3;
    public TextMeshProUGUI healthBarText;
    public GameObject gameOverPanel;
    // Update is called once per frame
    void Update()
    {
        healthBarText.text = "Can : " + health.ToString();

        if(health == 0)
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }
    }
}
