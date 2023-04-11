using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Pool;

public class BombCatched : MonoBehaviour
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
            GameManager.instance.gameover = true;
            GameManager.instance.gamePlay = false;
            Debug.Log("Game Over");
            GameManager.instance.gameoverpanel.SetActive(true);
            LeanPool.Despawn(this);
        }
    }
}
