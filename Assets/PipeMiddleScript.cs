using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript logic;
    void Start() 
    { 
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision){

        logic.addScore();
        // Debug.Log(logic.playerScore.ToString());
        
    }
    
}