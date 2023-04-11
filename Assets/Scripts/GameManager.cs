using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject basket;
    //public StackingCubes stackScript;
    public SwervingScript swerveScript;
    public bool gamePlay = false;
    public TMP_Text scoretxt;
    public TMP_Text highscoretxt;
    public int score = 0;
    public int highscore = 0;
    public bool gameover = false;
    public GameObject gameoverpanel;
    public GameObject SpawnerObject;
    public GameObject StartButton;

    private void Awake()
    {
        instance = this;
    }
    
    void Start()
    {
        highscoretxt.text = PlayerPrefs.GetInt("highscore").ToString();
        highscore = PlayerPrefs.GetInt("highscore");
    }

    public void StartGame()
    {
        SpawnerObject.SetActive(true);
        StartButton.SetActive(false);
        gamePlay = true;
    }
}
