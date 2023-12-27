using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class badItems : MonoBehaviour
{
    private static int score;
    public TextMeshProUGUI scoreText, gameOverText;
    private void Start()
    {
        score = 0;
    }

    void Update()
    {
        scoreText.text = score.ToString();
        gameOverText.text = "Oyun Bitti!\nSkor : " +score.ToString();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        float x_Range = Random.Range(-8f, 8f);
        float y_Range = Random.Range(6.5f, 15f);

        if (collision.gameObject.tag == "Control_Floor")
        {
            transform.position = new Vector2(x_Range, y_Range);
            score += 10;
        }
        else if (collision.gameObject.tag == "Character")
        {
            transform.position = new Vector2(x_Range, y_Range);
            score -= 10;
            healthBar.health--;
        }
    }
}
