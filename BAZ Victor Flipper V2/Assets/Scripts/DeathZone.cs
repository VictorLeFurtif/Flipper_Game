using TMPro;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
   
    public int damage = 1;
    public int currentLife = 3;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public GameObject bwFilter;
    public GameObject gameOvertxt;
    public GameObject buttonRestart;
    public GameObject buttonMenu;
    public AudioSource audio;
    public AudioSource audio1;
    public compteur cpt;
    public GameObject compteurText;
    public GameObject gameoverTextMax;
    public PlayerSaveScore pss;
    
    
    
    void OnTriggerEnter(Collider other)
    {
        if (currentLife > 1 )
        {
            other.GetComponent<Rigidbody>().velocity = Vector3.zero;
            other.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            other.transform.position = new Vector3(10.508f, 8.003f, 0.005f);
            ScreenShacker.instance.Shake(2,1);
            
            
            
            if (currentLife == 3)
            {
                heart3.gameObject.SetActive((false));
            }

            if (currentLife == 2) 
            {
                    heart2.gameObject.SetActive((false)); 
            }
            currentLife = currentLife - damage;
        }
        else
        {
            pss.WhenDie();
            heart1.gameObject.SetActive((false));
            Destroy(other.gameObject);
            bwFilter.SetActive(true);
            gameOvertxt.SetActive(true);
            gameOvertxt.GetComponent<TMP_Text>().text = "your score is : "+cpt.currentValueCounter;
            compteurText.SetActive(false);
            gameoverTextMax.SetActive(true);
            gameoverTextMax.GetComponent<TMP_Text>().text = "your Highest score is : "+pss.score;
            buttonMenu.SetActive(true);
            buttonRestart.SetActive(true);
            audio.Stop();
            audio1.Play();
            

        }
        
        

    }

    
}
