using System;
using UnityEngine;

// FIRST CREATE THE LIBRARY(NAMESPACE)
namespace RC3Animals
{
    // THEN SERIALIZE YOUR CLASS
    [System.Serializable]
    public class Animals
    {
        // VARIABLES/PROPERTIES
        public string type;
        public int noLegs;
        public int age;
        public float height;
        public float mass;
        public MeshFilter shape;
        MeshRenderer renderer;
        Transform transform;
        GameObject gameObject;

        // CONSTRUCTOR
        public Animals(string _type, float _height)
        {
            type = _type;
            age = 0;
            mass = 1.0f;
            height = _height;

            gameObject = new GameObject();
            transform = gameObject.AddComponent<Transform>();
            shape = gameObject.AddComponent<MeshFilter>();
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            shape = sphere.GetComponent<MeshFilter>();
            GameObject.Destroy(sphere);
            //transform.localScale += new Vector3(height, height, height);
            renderer = gameObject.AddComponent<MeshRenderer>();

            gameObject.name = type;

        }

        // METHODS/FUNCTIONS/BEHAVIOURS
        void Eat()
        {
            // Code for eating 
        }

        void Walking()
        {
            // Code for walking
        }

        void Sleeping()
        {
            // Code for sleeping
        }

        void Upset()
        {
            // Code for upset
            Debug.Log("Stop dragging me!!!!");
        }

        public void GetDraggedAround()
        {
            Walking();
            Upset();
        }
    }

    /*
    public class Human : Animals{
        // VARIABLES/PROPERTIES

        // CONSTRUCTOR
        public Human(string _type, float _height){
            type = _type;
            height = _height;
        }

        //METHODS
    }
    */
}




