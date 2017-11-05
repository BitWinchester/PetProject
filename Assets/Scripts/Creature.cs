using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour {

    public string creatureName;
    int hunger = 100;
    int energy = 100;
    int mood = 100;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void PriorityManager()
    {
        //Check if the creature needs to sleep 
        

        //Check to see if the creature needs to eat

        //Check if the creature wants to play
    }

    public void Eat()
    {
        // If hungery go find food 

        // Look for food objects 

        // Eat the food and update the food rating 
    }

    public void Sleep()
    {

    }

    public void Play()
    {

    }

    private void Death()
    {
        // check to see if the creature hasnt eaten in a set amount of time
    }




}
