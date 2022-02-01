using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FormulaExercise : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Question2();
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

    void Question2()
    {
        /*
         A 0.170kg pool ball travelling 6 ms hits 
        another 0.170kg ball at rest.  If the first ball stops 
        after the collision, how fast is the second ball moving?
        vf2?
        formula: m1v1i + m2v2i = m1v1f + m2v2f
         */

        float m1=0.17f, vi1=6, m2 = 0.17f, vi2=0, vf1=0, vf2;
        float m1vi1 = m1 * vi1;
        float m2vi2 = m2 * vi2;
        float m1vf2 = m1 * vf1;
        vf2 = (m1vi1 + m2vi2) / m2;

        print($"final velocity = {vf2} ms");
    }
}
