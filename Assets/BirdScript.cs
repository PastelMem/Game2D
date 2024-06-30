using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flyStep = 10;
    public LogicScript logic;
    public bool birdIsalive = true;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && birdIsalive )
        {
            myRigidbody.velocity = Vector2.up * flyStep;
        }
            // Debug.Log(logic.playerScore.ToString());
    }
    private void OnCollisionEnter2D()
    {
        logic.gameOver();
        birdIsalive = false;
    }
}
