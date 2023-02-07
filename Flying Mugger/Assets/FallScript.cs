using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallScript : MonoBehaviour
{
    public LogicScript logic;
    public MuggerScript mugger;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        mugger = GameObject.FindGameObjectWithTag("Mugger").GetComponent<MuggerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        mugger.birdIsAlive = false;
    }
}
