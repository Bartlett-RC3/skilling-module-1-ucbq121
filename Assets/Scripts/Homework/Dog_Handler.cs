using System;
using UnityEngine;
using HomeWork_Dog;


namespace Assets.script
{
    class Dog_Handler : MonoBehaviour
    {
        //VARIABLES
        Dog Lucy, Peggy, Trump;
        
        public void Start()
        {
            Lucy = new Dog("Lucy", "poodle", 5, 22.0f);
            Peggy = new Dog("Peggy", "Schnauzer", 4, 16.8f);
            Trump = new Dog("Trump", "Husky", 6, 50.5f);

            string[] statement = 
                { "The name of the dog is ",
                "The breed of the dog is ",
                "The age of the dog is ",
                "The weight of the dog is " };

            Debug.Log(statement[0]+ Lucy.GetName());
            Lucy.Angry();

            Debug.Log(statement[0] + Peggy.GetName());
            Debug.Log(statement[1] + Peggy.GetBreed());
            Debug.Log(statement[2] + Peggy.GetAge());
            Peggy.Sleeping();

            Debug.Log(statement[0] + Trump.GetName());
            Debug.Log(statement[3] + Trump.GetWeight());
            Trump.Eating();

        }
        public void Update()
        {
            
        }
    }
}
