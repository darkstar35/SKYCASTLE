﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;using UnityEngine.SceneManagement;

public class Catsle : MonoBehaviour
{
    public int nHP = 7;
    public bool IsGameOver = false;
    [SerializeField] AudioClip gameOver = null;
    [SerializeField] AudioClip startBoost = null;

    // Start is called before the first frame update
    void Start()
    {
        IsGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position +=  transform.forward * Time.deltaTime;
        transform.Find("HPText").GetComponent<TextMesh>().text = nHP.ToString();
        if(nHP <= 0)
          SceneManager.LoadScene("Ending");
        


    }
}
