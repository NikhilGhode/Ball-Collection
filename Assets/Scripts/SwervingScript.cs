using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwervingScript : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    [SerializeField] float controlSpeed;
    private float xMin = -1.9f, xMax = 1.9f;

    //Touch Settings
    public bool gamePlay = true;
    [SerializeField] bool isTouching;
    [SerializeField] bool screenTouched;
    float touchPosX;
    float xPos;
    Vector3 direction;
    private float velocity = 0f;
    public float smoothTime;
    
    void Start()
    {
        
    }

    void Update()
    {
        GetInput();
    }

    private void FixedUpdate()
    {
        if (GameManager.instance.gamePlay)
        {
            if (isTouching)
            {
                touchPosX += Input.GetAxis("Mouse X") * controlSpeed * Time.fixedDeltaTime;
            }

            float xPos = Mathf.Clamp(touchPosX, xMin, xMax);
            xPos = Mathf.SmoothDamp(transform.position.x, xPos, ref velocity, smoothTime);
            transform.position = new Vector2(xPos, transform.position.y);            
        }
    }

    void GetInput()
    {
        if (Input.GetMouseButton(0))
        {
            isTouching = true;
        }
        else
        {
            isTouching = false;
        }
    }
}
