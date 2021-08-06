using System.Collections;
using UnityEngine;
using UnityEngine.Advertisements;


public class bannerads : MonoBehaviour
{

    public string gameId = "3550635";
    public string placementId = "bannerAd";
    public bool testMode = false;

    void Start()
    {
        Advertisement.Initialize(gameId, testMode);
        StartCoroutine(ShowBannerWhenReady());
    }

    IEnumerator ShowBannerWhenReady()
    {
        while (!Advertisement.IsReady(placementId))
        {
            yield return new WaitForSeconds(0.5f);
        }
        Advertisement.Banner.SetPosition(BannerPosition.TOP_CENTER);
        Advertisement.Banner.Show(placementId);
    }
}

