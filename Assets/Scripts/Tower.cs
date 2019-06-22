using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{

    public GameObject Missile; // 미사일 프리펩
    public Tower tower;
    public static float fPresseddiesize = 0.4f;
    public float fTowerMaintiantime;
    public bool bIfIchoose;
    public float fFireDeltaTime;
    public float fFireDelay;
    public Bullet[] bullets;
    public static int bulletcnt;

	public Vector3 v3ShootPos = Vector3.up;

    void Start()
    {
        if (fTowerMaintiantime <= 0)
            fTowerMaintiantime = 3;

        if (fFireDelay > 0)
            fFireDeltaTime = 0f;

        if (tower == null)
            tower = GameObject.Find("Tower").GetComponent<Tower>();
        //    transform.DOMoveX(5f, 4f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear); // 런쳐를 좌우로 반복 이동시킨다.
    }

    void OnCollisionStay(Collision collisionInfo)
    {

    }
	void OnTriggerStay(Collider other)// void OnTriggerStay(Collider other)
	{


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

    private float hue;
    public float bulletIntensity;
    public float maxSpeed = 5f;
    public void RandFire()
    {
       
       
	     Instantiate(Missile, transform.position, Quaternion.identity);	   
     //   bulletLight.intensity = bulletIntensity;
     //   bulletLight.color = Color.HSVToRGB(hue, 1f, 1f);
     //   bulletLight.sr.color = bulletLight.color;
     //
     //   hue = (hue + 0.15f) % 1.0f;

     //   Destroy(ObjBullet, 4.0f);
        fFireDeltaTime = 0f;
    }


    public void Update()
    {


        Vector3 followVec3;

        followVec3 = (Catsle.FindObjectOfType<Transform>().position - this.gameObject.transform.position).normalized;
        this.transform.Translate(followVec3 * Time.deltaTime);


        if (fFireDeltaTime >= fFireDelay)
        {
                    RandFire();
                    fFireDeltaTime = 0f;

        }


        if (fFireDeltaTime < fFireDelay)
            fFireDeltaTime += Time.deltaTime;



    }
}
