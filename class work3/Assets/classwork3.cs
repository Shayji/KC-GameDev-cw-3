using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class classwork3 : MonoBehaviour

{
    int sumVal = 0;

    // hero things
    string heroName = "Angelo";
    int heroPower = 300;

    //villian things
    string villianName = "O'lie";
    int villianPower = 303;

    //playerSpeed
    float playerSpeed;


    // Start is called before the first frame update
    void Start()
    {

        if (villianPower > heroPower) 
        {
            print("YOU are WEAK");
        }
        else if (villianPower < heroPower) 
        {
            print("You made it");
        }
        else
        {
            print("Work harder" + heroName);
        }

        setSpeed(2.5f);

        sumVal = sum();
        print(sumVal);

    }

    
// Update is called once per frame
    void Update()
    {

    }

    void setSpeed(float speed)
    {   
    print(playerSpeed);
    playerSpeed = speed;
    print(playerSpeed);
    }

    int sum()
    {
    return villianPower + heroPower;
    }
}
