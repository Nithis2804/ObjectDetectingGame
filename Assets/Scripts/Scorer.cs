using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits=50;
    void OnCollisionEnter(Collision other)
    {

        hits-=1;
        Debug.Log("Score:"+hits);
    }
}
