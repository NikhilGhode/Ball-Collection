using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Pool;

public class BallCatched : MonoBehaviour
{
    // Start is called before the first frame update    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.gameover)
        {
            LeanPool.Despawn(this);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameManager.instance.score++;
            if(GameManager.instance.highscore < GameManager.instance.score)
            {
                GameManager.instance.highscore++;
                PlayerPrefs.SetInt("highscore", GameManager.instance.highscore);
                GameManager.instance.highscoretxt.text = PlayerPrefs.GetInt("highscore").ToString();
            }
            Debug.Log("Scored" +  " " + GameManager.instance.score);
            GameManager.instance.scoretxt.text = GameManager.instance.score.ToString();
            LeanPool.Despawn(this);
        }
    }
}
