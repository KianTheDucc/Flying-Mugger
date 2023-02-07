using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class PipeMiddleScript : MonoBehaviour
{
    public static int scoreToAdd = 1;
    public LogicScript logic;
    public bool hasEntered = false;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!hasEntered)
        {
            Debug.Log("I am working");
            logic.AddScore();
            hasEntered = true;
        }
    }
}
