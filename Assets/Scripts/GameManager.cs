using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public float deltatime;
    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        deltatime += Time.deltaTime;

        if(deltatime > 2)
        {
             Instantiate(Enemy1, this.transform.position + Vector3.forward*3, transform.rotation);
    }

        }
       
}
