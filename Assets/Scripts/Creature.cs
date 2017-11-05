using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour {

    public string creatureName;
    private int hunger = 15;
    private int hungerMax = 100;
    private int energy = 100;
    private int energyMin= 0;
    private int mood = 100;
    private int hungerMin = 25;
    private int moodMin = 10;
    


    public float speed = 60.0F;
    public GameObject targetObject;


    // Update is called once per frame
    void Update()
    {
        PriorityManager();
        float distance = Vector3.Distance(transform.position, targetObject.transform.position);

       


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
            FindFood();
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


        bool hasTempLocation = false;
        Vector3 tempLocation;
        
        if ( hasTempLocation == false)
        {
            hasTempLocation = true;
            tempLocation = new Vector3(transform.position.x + UnityEngine.Random.Range(-5, 5),transform.position.y + UnityEngine.Random.Range(-5, 5),transform.position.z + UnityEngine.Random.Range(-5, 5));
            transform.position = Vector3.MoveTowards(transform.position, tempLocation, (speed * Time.deltaTime));

            if ((Vector3.Distance(transform.position, tempLocation) <= 5))
            {
                hasTempLocation = true;
            }
        }

       

        
        //Move around in a random direction when not hungery,tired,or wants to play

        if (Vector3.Distance(transform.position, targetObject.transform.position) <= 5)
        {
            hunger = hungerMax;
            Debug.Log("hunger is : " + hunger);
        }

    }



    private void FindFood()
    {
        Food[] foods = FindObjectsOfType(typeof(Food)) as Food[];

        if (foods != null)
        {
            targetObject = foods[0].gameObject;
            Debug.Log("Target Object is " + targetObject);
            Eat();
        }
   

    }
    public void Eat()
    {
        Debug.Log("Eating");      

        transform.position = Vector3.MoveTowards(transform.position,targetObject.transform.position, (speed * Time.deltaTime));

        if ( Vector3.Distance(transform.position,targetObject.transform.position) <= 5)
        {
            hunger = hungerMax;
            Debug.Log("hunger is : " + hunger);
        }


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
