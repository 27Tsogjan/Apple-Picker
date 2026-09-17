using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour {

    public static float bottomY = -20f; //Y pos where Apple is destroyed
    // Update is called once per frame
    void Update()
    {
        //Destroy Apple if it falls below bottomY
        if (transform.position.y < bottomY) {
            Destroy(this.gameObject);
        }
    }
}
