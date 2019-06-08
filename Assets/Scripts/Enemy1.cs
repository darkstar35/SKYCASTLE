using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{

    public GameObject Cathle;

    // Start is called before the first frame update
    void Start()
    {
        //Cathle = GameManager.FindObjectOfType(Cathle);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 followVec3;

        followVec3 = (Cathle.transform.position- this.gameObject.transform.position).normalized;
        this.transform.Translate(followVec3 * Time.deltaTime);
    }
}
