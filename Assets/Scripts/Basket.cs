using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Basket : MonoBehaviour {
    // Update is called once per frame
    public ScoreCounter scoreCounter;
    public RoundCounter roundCounter;

    void Start()
    {
        GameObject scoreGO = GameObject.Find("ScoreCounter");
        scoreCounter = scoreGO.GetComponent<ScoreCounter>();
        GameObject roundGO = GameObject.Find("RoundCounter");
        roundCounter = roundGO.GetComponent<RoundCounter>();

    }
    void Update() {
        Vector3 mousePos2D = Input.mousePosition;
        mousePos2D.z = -Camera.main.transform.position.z;
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);
        Vector3 pos = transform.position;
        pos.x = mousePos3D.x;
        transform.position = pos;
    }

    void OnCollisionEnter(Collision coll) {
        GameObject collidedWith = coll.gameObject;
        if (collidedWith.tag == "Apple") {
            Destroy(collidedWith);
            scoreCounter.score += 100;
            HighScore.TRY_SET_HIGH_SCORE(scoreCounter.score);
            if (scoreCounter.score >= roundCounter.round * 100)
            {
                if (roundCounter.round < 4)
                    roundCounter.round += 1;
                else
                {
                    return;
                }
            }
           
        }
        if (collidedWith.tag == "Crapple")
        {
            Destroy(collidedWith);
            SceneManager.LoadScene("_Game_Over");
        }
    }   
}
