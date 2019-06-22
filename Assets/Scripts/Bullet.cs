using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame updater

    public Vector3 BulletDir = Vector3.zero;
    public float fspeed = 2f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
   
       this.transform.Translate(BulletDir*fspeed*Time.deltaTime);
    }


    public void SetDirection(Vector3 Dir)
    {
        BulletDir = Dir;

    }
}
