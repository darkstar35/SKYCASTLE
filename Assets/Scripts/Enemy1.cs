using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{

    public GameObject Cathle;
    public int HP = 1;
    private
    // Start is called before the first frame update

    void OnMouseDown()
    {
      //  transform.position = mousePosWorld + mOffset;
    }
    void OnMouseDrag()
    {
      //  transform.position = mousePosWorld + mOffset;
    }
    void Start()
    {
        //Cathle = GameManager.FindObjectOfType(Cathle);
    }

    // Update is called once per frame
    void Update()
    {

         if(HP <=0)
          {
             BalloonSound.instance.PlayGameOver_sigh();
            this.gameObject.SetActive(false);
            Object.Destroy(this);
          }

        Vector3 followVec3;

        followVec3 = (Cathle.transform.position- this.gameObject.transform.position).normalized;
        this.transform.Translate(followVec3 * Time.deltaTime);

     
    }


        void OnCollisionStay(Collision collisionInfo)
    {
        if(collisionInfo.transform.tag == "Bullet")
         HP -=1;
    }
	void OnTriggerStay(Collider other)// void OnTriggerStay(Collider other)
	{


	}	

        private void OnCollisionEnter(Collision collision) 
        {
        var player = collision.gameObject.GetComponentInParent<Catsle>();
        if (player != null && player.IsGameOver == false) {
            
                player.nHP -= 1;
                HP -=1;


        }
        
    }
}
