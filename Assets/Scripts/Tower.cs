using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{

    public GameObject Missile; // 미사일 프리펩
    //public Tower tower;
    public Catsle catsle;
    public static float fPresseddiesize = 0.4f;
    public float fspeed;
    public bool bIfIchoose;
    public float fFireDeltaTime;
    public float fFireDelay;
    public Bullet[] bullets;
    public static int bulletcnt;

	public Vector3 v3ShootPos = Vector3.up;

    public float maxSpeed = 5f;
    void Start()
    {

        if (fFireDelay > 0)
            fFireDeltaTime = 0f;

   //     if (tower == null)
   //         tower = GameObject.Find("Tower").GetComponent<Tower>();
        catsle = GameObject.Find("Castle").GetComponent<Catsle>();
        //    transform.DOMoveX(5f, 4f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear); // 런쳐를 좌우로 반복 이동시킨다.
    }



   
    void setdirection()
    {
        Object Effect = null;
        Effect = Instantiate(Resources.Load("Effect/Effect_PlayerCrush"), transform.position, Quaternion.identity);  //부셔지는 이펙트 재생


        Destroy(this.gameObject);

    }
    void dieself()
    {
        Object Effect = null;
        Effect = Instantiate(Resources.Load("Effect/Effect_PlayerCrush"), transform.position, Quaternion.identity);  //부셔지는 이펙트 재생


        Destroy(this.gameObject);

    }
    public void Fire(Vector3 TargetPos)
    {
        if (fFireDeltaTime < 1)
        {
            // Bullet ObjBullet = new Bullet(bulletkind);
            //  Rigidbody clone;
            //  clone = Instantiate(bullets[1], transform.position, transform.rotation) as Rigidbody;
            //  clone.velocity = transform.TransformDirection(Vector3.forward * 10);
            Bullet ObjBullet = null;
            ObjBullet = Instantiate(bullets[0], transform.position + v3ShootPos, Quaternion.identity);
            fFireDeltaTime = 0f;

        }

    }

    public void RandFire()
    {

        
         int Dir = Random.Range(1,5);  


         Missile = Instantiate(Missile, transform.position, Quaternion.identity);	   
        switch(Dir)
         {
            case 1:
            Missile.GetComponent<Bullet>().SetDirection(Vector3.forward);
            Missile.GetComponent<Bullet>().BulletDir = Vector3.forward;
            break;
            
            case 2:
            Missile.GetComponent<Bullet>().SetDirection(Vector3.right);
            Missile.GetComponent<Bullet>().BulletDir = Vector3.right;
            break;

            case 3:
             Missile.GetComponent<Bullet>().SetDirection(Vector3.left);
             Missile.GetComponent<Bullet>().BulletDir = Vector3.left;
            break;

            case 4:
             Missile.GetComponent<Bullet>().SetDirection(Vector3.back);
             Missile.GetComponent<Bullet>().BulletDir = Vector3.back;
             
            break;


         }
	    
       


        fFireDeltaTime = 0f;
    }


    public void Update()
    {


        Vector3 followVec3;

        followVec3 = (catsle.transform.position - this.gameObject.transform.position).normalized;
        this.transform.Translate(followVec3* fspeed * Time.deltaTime);
       


        if (fFireDeltaTime >= fFireDelay)
        {  
    
                    RandFire();
                    fFireDeltaTime = 0f;

        }


        if (fFireDeltaTime < fFireDelay)
            fFireDeltaTime += Time.deltaTime;



    }

        void OnCollisionStay(Collision collisionInfo)
    {

    }
	void OnTriggerStay(Collider other)// void OnTriggerStay(Collider other)
	{


	}	
}
