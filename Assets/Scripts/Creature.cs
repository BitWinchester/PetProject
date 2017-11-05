using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour {

    public string creatureName;
    private int hunger = 100;
    private int energy = 100;
    private int energyMin= 0;
    private int mood = 100;
    private int hungerMin = 25;
    private int moodMin = 10;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        PriorityManager();
	}

    private void PriorityManager()
    {
        //Check if the creature needs to sleep 
        if (energy <= energyMin)
        {
            Sleep();
        }
        //If they dont need to sleep then they should go find food
        else if (hunger <= hungerMin)
        {
            Eat();
        }
        //If they dont need to sleep or eat then check if they want to play 
        else if (mood <= moodMin)
        {
            Play();
        }
        else Wander();

        //Check to see if the creature needs to eat

        //Check if the creature wants to play
    }

    private void Wander()
    {
        //Move around in a random direction when not hungery,tired,or wants to play
        throw new NotImplementedException();
    }

    public void Eat()
    {

        Debug.Log("Eating");
        // If hungery go find food 

        // Look for food objects 

        // Eat the food and update the food rating 
    }

    public void Sleep()
    {
        Debug.Log("Sleeping");

        //Regain energy over time
    }

    public void Play()
    {
        Debug.Log("Playing");

        //Regain mood over time
    }

    private void Death()
    {
        Debug.Log("Dead");

        // check to see if the creature hasnt eaten in a set amount of time. Check hunger and energy
    }

    private void Hunger()
    {
        Debug.Log("Hungery");

        //Use this method for making our creature to become hungery and need to eat 
    }

    private void LossEnergy()
    {
        Debug.Log("Lossing Energy");

        //Call this method when the creature moves or plays reducing energy
    }




}
