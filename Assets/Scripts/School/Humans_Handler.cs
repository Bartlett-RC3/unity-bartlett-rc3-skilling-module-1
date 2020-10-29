using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RC3_9;

public class Humans_Handler : MonoBehaviour
{
    // Variables
    Human_Class octavian, tyson, phil;
    Cyborg octavianCyborg;

    // Start is called before the first frame update
    void Start()
    {
        octavian = new Human_Class("Octavian Gheorghiu", 1.74f);
        tyson = new Human_Class("Tyson Hosmer", 1.82f);
        phil = new Human_Class("Phil", 1.75f);
        octavianCyborg = new Cyborg("CyOc", 1.74f);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(octavian.GetName());
        octavian.Walking();
        octavian.WorkOut();
        octavianCyborg.Scan();
    }
}
