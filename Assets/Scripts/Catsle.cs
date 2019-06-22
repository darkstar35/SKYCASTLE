using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Catsle : MonoBehaviour
{
    public int nHP = 7;
    public bool IsGameOver = false;
    [SerializeField] AudioClip gameOver = null;
    [SerializeField] AudioClip startBoost = null;

    public GameObject tower; 

    public int gold = 10;

    // Start is called before the first frame update
    void Start()
    {

   //     if(tower == null)
   //     tower = gameObject.GetComponent<Tower>();

        IsGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position +=  transform.forward * Time.deltaTime;
        transform.Find("HPText").GetComponent<TextMesh>().text = nHP.ToString();
        if(nHP <= 0)
          SceneManager.LoadScene("Fail");


    }

    public void MakeTower()
    {
        Instantiate(tower , transform.position + new Vector3(10,10,10),  Quaternion.identity);




    }
}
