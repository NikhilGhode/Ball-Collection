using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Pool;

public class SpawnBalls : MonoBehaviour
{
    // Start is called before the first frame update
    //[SerializeField] private GameObject ball;    
    public GameObject[] balls;
    bool pause = true;
    void Start()
    {
        Debug.Log("Hello");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (pause && !GameManager.instance.gameover)
        {
            pause = false;
            float delay = Random.Range(0.3f, 1);
            StartCoroutine(WaitAndSpawn(delay));
        }     
    }

    IEnumerator WaitAndSpawn(float x)
    {
        yield return new WaitForSeconds(x);
        float value = Random.Range(-2, 3);
        int index = Random.Range(0, 5);
        //Instantiate(balls[index], new Vector2(value, 5.88f), Quaternion.identity);
        LeanPool.Spawn(balls[index], new Vector2(value, 5.88f), Quaternion.identity);        
        pause = true;
    }

    
}
