using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FormulaExercise : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Question1();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void Question1()
    {
        /*
         Consider a car of mass 1 000 kg with a velocity of 8 ms 
        (about 30 kmh) East. The momentum of the car is therefore.

        Formula: p = mv
         */

        float p, m = 1000, v = 8;
        p = m * v;
        print($"p = {p} kgm/s");
    }
}
