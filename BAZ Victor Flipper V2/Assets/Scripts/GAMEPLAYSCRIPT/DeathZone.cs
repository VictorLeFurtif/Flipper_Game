using System.Collections;
using TMPro;
using Unity.Collections;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
   
    public int damage = 1;
    public int currentLife = 3;
    public GameObject heart1;
    public GameObject vfx1;
    public GameObject heart2;
    public GameObject vfx2;
    public GameObject heart3;
    public GameObject vfx3;
    public GameObject gameOvertxt;
    public GameObject buttonRestart;
    public GameObject buttonMenu;
    public Compteur cpt;
    public GameObject compteurText;
    public GameObject gameoverTextMax;
    public PlayerSaveScore pss;
    public AudioSource loosingAudio;
    public AudioSource loosingALifeAudio;
    public float newPitch = 0.5f;
    public GameObject planeLifeLoose;
    public GameObject planeGameLoose;

    public TrailRenderer trail;
    public Transform ball;
    
    void Teleport()
    {
        trail.SetPositions(new Vector3[]{ball.position});
    }
    
    IEnumerator WaitForTrailReset()
    {
        yield return new WaitForSeconds(1); 
        Teleport();
        trail.enabled = true;
        planeLifeLoose.SetActive(false);
    }
    
    
    void OnTriggerEnter(Collider other)
    {
        
        
        if (currentLife > 1 )
        {
            planeLifeLoose.SetActive(true);
            trail.enabled = false;
            other.GetComponent<Rigidbody>().velocity = Vector3.zero;
            other.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            other.transform.position = new Vector3(10.508f, 8.003f, 0.005f);
            StartCoroutine(WaitForTrailReset());
            ScreenShacker.instance.Shake(2,1);
            loosingALifeAudio.Play();
            
            
            
            if (currentLife == 3)
            {
                heart3.gameObject.SetActive((false));
                vfx3.gameObject.SetActive(false);
            }

            if (currentLife == 2) 
            {
                    heart2.gameObject.SetActive((false)); 
                    vfx2.gameObject.SetActive(false);
            }
            currentLife = currentLife - damage;
        }
        else
        {
            pss.WhenDie();
            heart1.gameObject.SetActive((false));
            Destroy(other.gameObject);
            gameOvertxt.SetActive(true);
            gameOvertxt.GetComponent<TMP_Text>().text = "your score is : "+cpt.currentValueCounter;
            compteurText.SetActive(false);
            gameoverTextMax.SetActive(true);
            gameoverTextMax.GetComponent<TMP_Text>().text = "your Highest score is : "+pss.score;
            buttonMenu.SetActive(true);
            buttonRestart.SetActive(true);
            vfx1.SetActive(false);
            loosingAudio.Play();
            ScreenShacker.instance.Shake(2,1);
            planeGameLoose.SetActive(true);



        }
        
        

    }

    
}
