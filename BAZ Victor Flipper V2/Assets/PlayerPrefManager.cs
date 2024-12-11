using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefManager : MonoBehaviour
{
    
    
    bool DoesPlayerPrefIntExist(string key)
    {
        return PlayerPrefs.HasKey(key);
    }


    void Start()
    {
        if (DoesPlayerPrefIntExist("Max Score"))
        {
            int value = PlayerPrefs.GetInt("Max Score");
            Debug.Log($"La clé '{"Max Score"}' existe avec la valeur : {value}");
        }
        else
        {
            Debug.Log($"La clé '{"Max Score"}' n'existe pas.");
            PlayerPrefs.SetInt("Max Score",0);
        }
    }
}