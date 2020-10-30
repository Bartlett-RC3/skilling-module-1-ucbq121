using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session1Homework : MonoBehaviour
{
    // the declaration of Variables
    public string studentName = "Wang Jiaqi";
    public string country = "China";
    public int studentNumber = 20147364;
    public int age = 24;
    public float height = 1.75f;
    public float score = 99.999f;
    public bool hardWorking = true;
    public int yearOfStudy = 5;
    public int yearOfWork = 1;

    // the declaration of Array
    public int[] favoriteClusterList = new int[3];
    public string[] favoriteDrink = {"water", "colar", "juice", "milk"};
    public float[] favoriteNumber = {1.5f, 3.14f, 6.25f};

    // the declaration of List
    public List<string> favoriteFood = new List<string>();

    // the declaration of a function 
    public float CalculatorSum(float _FirstNumber, float _SecondNumber)
    {
        float Sum = _FirstNumber + _SecondNumber;
        return Sum;
    }

    // Use this for initialization
    void Start()
    {
        // the print of the Variables
        Debug.Log("This is my self introdution");
        Debug.Log("My name is " + studentName);
        Debug.Log("I'm " + age + " years old");
        
        // the print of the Calculation
        float year = CalculatorSum(yearOfStudy, yearOfWork);
        Debug.Log("I have been studying architecture for "+year.ToString( ) +" years");

        // add data to the Array
        // the print of the Calculation of the Array
        favoriteNumber[0] = 1.75f;
        float Sum = CalculatorSum(favoriteNumber[0],favoriteNumber[2]);
        Debug.Log("The sum of my two favorite numbers is "+Sum.ToString( ));

        // add data to the List
        favoriteFood.Add("beef");
        favoriteFood.Add("chicken");
        Debug.Log("My favorite food is "+favoriteFood[0]);


        // the creation of a dictionary
        var pets=new Dictionary<string,string>();
        pets.Add("DOG", "Hound, Dachshund, Akita, Collie");
        pets.Add("CAT", "Persian, Birman, Ragdoll, Forest Cat");
        pets.Add("MICE", "hamster, cavy, Chinchilla");

        Debug.Log(pets["DOG"]);
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
