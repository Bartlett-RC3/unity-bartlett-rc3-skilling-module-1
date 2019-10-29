using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RC3Animals;

public class AnimalHandler : MonoBehaviour {

    Animals donkey, cat, ogre;

    private void Awake()
    {
        donkey = new Animals("Donkey", 1.2f);
        cat = new Animals("Cat", 0.2f);
        ogre = new Animals("Shrek", 2.4f);
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        donkey.GetDraggedAround();
	}
}
