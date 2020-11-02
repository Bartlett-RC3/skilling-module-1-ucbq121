using System;
using UnityEngine;

namespace HomeWork_Dog
{
    public class Dog : MonoBehaviour
    {
        //VARIABLES
        string name;
        string breed;
        string color;

        int age;
        float weight;
        float height;

        bool healthy;
        bool getVaccinated;

        //CONSTRUCTOR
        public Dog(string _name,string _breed,int _age,float _weight)
        {
            name = _name;
            breed = _breed;
            age = _age;
            weight = _weight;
        }
        //FUNCTIONS
        public string GetName()
        {
            return name;
        }
        public string GetBreed()
        {
            return breed;
        }
        public int GetAge()
        {
            return age;
        }
        public float GetWeight()
        {
            return weight;
        }
        public void SetColor(string _color)
        {
            color = _color;
        }
        public void SetHeight(float _height)
        {
            height = _height;
        }
        public void Sleeping()
        {
            Debug.Log("zzz...zzz...zzz...");
        }
        public void Running()
        {
            Debug.Log("as fast as a shot");
        }
        public void Eating()
        {
            Debug.Log("The food is very great! yummy! yummy!");
        }
        public void Angry()
        {
            Debug.Log("Leave me alone! woof! woof! woof!");
        }
    }
}
