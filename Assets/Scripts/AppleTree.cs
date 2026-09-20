using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour {
[Header("Inscribed")]
	//Prefab for instantiating apples
	public GameObject applePrefab;
    public GameObject crapplePrefab;
	//Speed	at which the AppleTree moves
	public float speed = 10f;
	//Distance where AppleTree turns around
	public float leftAndRightEdge =	24f;
	//Chance that the AppleTree will change directions
	public float changeDirChance =	0.02f;
	//	Rate at which Apples will be instantiated
	public float AppleDropDelay = 1f;
    public float CrappleDropDelay = 3f;
    // Start is called before the first frame update
    void Start() {
    //Dropping apples
        Invoke("DropApple", 2f);
        Invoke("DropCrapple", 4f);
    }

    void DropApple() {
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position;
        Invoke("DropApple", AppleDropDelay);
    }

    void DropCrapple() {
        GameObject crapple = Instantiate<GameObject>(crapplePrefab);
        crapple.transform.position = transform.position;
        Invoke("DropCrapple", CrappleDropDelay);
    }

    // Update is called once per frame
    void Update() {
    //Basic Movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if (pos.x <-leftAndRightEdge) {
            speed = Mathf.Abs(speed); // Move right
        }
        else if (pos.x > leftAndRightEdge) {
            speed = -Mathf.Abs(speed); // Move left
        }
        /*else if (Random.value < changeDirChance) {
            speed *= -1; // Change direction
        }
        */
    }
    void FixedUpdate() {
        //Changing direction randomly
        if (Random.value < changeDirChance) {
            speed *= -1; // Change direction
        }
    }
}
