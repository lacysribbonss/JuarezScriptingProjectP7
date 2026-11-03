using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //This if statement will call the temperature test functionand check if the coffee is  too hot or too cold 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TemperatureTest();
        }
        //decrease the temperature of the coffee over time
        coffeeTemperature -= Time.deltaTime * 5f;
    }
    void TemperatureTest()
    {
        //This if statement will  check if the coffee is too hot 
        if (coffeeTemperature > hotLimitTemperature)
        {
            // ... do this.
            print("Coffee is too hot.");
        }
        //This if statement will check if the coffee is too cold
        else if (coffeeTemperature < coldLimitTemperature)
        {
            // ... do this.
            print("Coffee is too cold.");
        }
        //This if statement will check is neither too hot or cold 
        else
        {
            // ... do this.
            print("Coffee is just right.");
        }
    }
}