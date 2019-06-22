using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishLine : MonoBehaviour {
    [SerializeField] Transform balloon = null;
    [SerializeField] Catsle hotairBalloon = null;

    void Awake() {
        balloon = FindObjectOfType<Catsle>().transform;
        hotairBalloon = FindObjectOfType<Catsle>();
    }

    void Update() {
        if (balloon.position.z > transform.position.z ) {
         
            BalloonSound.instance.PlayGoalIn();
            BalloonSound.instance.PlayCheer();
            SceneManager.LoadScene("Ending");
        }
    }
}
