using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{

    public float deltatime;
    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;
    int DirE;
    public GameObject Pos1;
    public GameObject Pos2;
    public GameObject Pos3;
    public GameObject Pos4;
    public enum Driection {NORTH, SOUTH, WEST, EAST}
    // Start is called before the first frame update
    Driection dir;

    void Start()
    {
        
    }
    public GameObject explosionPrefab;

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if(Input.GetMouseButtonDown(0))
        {if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
        {
            Instantiate(explosionPrefab,hit.point, Quaternion.identity);
        }}
        
        deltatime += Time.deltaTime;
        if(deltatime > 2)
        {              
         DirE = UnityEngine.Random.RandomRange(1,4);

            if(DirE == 1)
             Instantiate(Enemy1, Pos1.transform.position, transform.rotation);
            if(DirE == 2)
            Instantiate(Enemy1, Pos2.transform.position, transform.rotation);
            if(DirE == 3)
            Instantiate(Enemy1, Pos3.transform.position, transform.rotation);
                  if(DirE == 4)
            Instantiate(Enemy1, Pos4.transform.position, transform.rotation);
            
             deltatime = 0f;
        }

    }
       
}
