using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session2Homework : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        //if function using condition
        int module1Score = 92;
        int module2Score = 97;
        int module3Score = 90;

        if (module1Score >= 60 && module2Score >= 60 && module3Score >= 60)
        {
            Debug.Log("Congratulations! The student has passed all the exams!");

            if (module1Score >= 90 && module2Score >= 90 && module3Score >= 90)
            {
                if (module1Score >= 95 || module2Score >= 95 || module3Score >= 95)
                {
                    Debug.Log("The final evaluation of the student is A+");
                }
                else
                {
                    Debug.Log("The final evaluation of the student is A");
                }
            }
            else if (module1Score >= 80 && module2Score >= 80 && module3Score >= 80)
            {
                Debug.Log("The final evaluation of the student is B");
            }
            else
            {
                Debug.Log("The final evaluation of the student is C");
            }
        }
        else
        {
             Debug.Log("Sorry, the student has to take the exams again !");
             Debug.Log("The final evaluation of the student is F");
        }


        //for loop of the fruits
        string[] fruits = { "orange", "peach", "apple", "lemon", "pear" };
        for (int i = 0; i < fruits.Length; i++)
        {
            Debug.Log("There is one "+fruits[i]+" in the NO."+i+" basket");
        }

        //for loop for adding the even numbers in 100
        int sum = 0;
        for (int i = 0; i <= 100; i=i+2)
        {
            sum += i;
        }
        Debug.Log(sum);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
