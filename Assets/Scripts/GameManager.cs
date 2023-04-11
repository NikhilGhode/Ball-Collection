using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject basket;
    //public StackingCubes stackScript;
    public SwervingScript swerveScript;
    public bool gamePlay = true;

    private void Awake()
    {
        instance = this;
    }
    
    void Start()
    {
        //stackScript = FindObjectOfType<StackingCubes>();
        swerveScript = basket.GetComponent<SwervingScript>();
    }
}
