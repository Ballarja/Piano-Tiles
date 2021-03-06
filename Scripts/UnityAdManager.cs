using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class UnityAdManager : MonoBehaviour
{
    public static UnityAdManager instance;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
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

    public void ShowAd()
    {
        if (PlayerPrefs.HasKey("Adcount"))
        {
            if (PlayerPrefs.GetInt("Adcount") == 5)
                //Show Ad
            {
                if (Advertisement.IsReady("video"))
                {
                    Advertisement.Show("video");
                }
                PlayerPrefs.SetInt("Adcount", 0);
            }
            else
            {
                PlayerPrefs.SetInt("Adcount", PlayerPrefs.GetInt("Adcount") + 1);
            }
        }
        else
        {
            PlayerPrefs.SetInt("Adcount", 0);
        }

    }
}
