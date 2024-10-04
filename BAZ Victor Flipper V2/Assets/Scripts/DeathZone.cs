using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DeathZone : MonoBehaviour
{
   
    public int damage = 1;
    public int currentLife = 3;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public int currentHeart = 3;
    
    public void LoadsceneByName()
    {
        SceneManager.LoadScene("Game_Over");
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (currentLife > 0 )
        {
            other.transform.position = new Vector3(10.508f, 8.003f, 0.005f);
          
            currentLife = currentLife - damage;
            if (currentHeart == 3)
            {
                heart3.gameObject.SetActive((false));
            }

            if (currentHeart == 2) 
            {
                    heart2.gameObject.SetActive((false)); 
            }
            

            currentHeart = currentHeart - damage;
        }
        else
        {
            heart1.gameObject.SetActive((false));
            Destroy(other.gameObject);
            LoadsceneByName();

        }
        
        

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
