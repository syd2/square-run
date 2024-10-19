using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.Advertisements;
// using UnityEngine.Advertisements.Events;


public class Ads : MonoBehaviour
{
    // private string playstoreID = "3772833";
    // private string rewardedVideoAd = "rewardedVideo";

    // public GameObject adFailed;

    // private void Start()
    // {
    //     Advertisement.AddListener(this);
    //     Advertisement.Initialize(playstoreID, true);
        
        
    // }

    // public void non_rewardedAd()
    // {
    //     if(!Advertisement.IsReady("video"))
    //     {
    //         return;
    //     }
    //     Advertisement.Show("video");
    // }
    // public void ShowAd()
    // {
        
    //     Advertisement.Show(rewardedVideoAd);
        
    // }
    // public void OnUnityAdsReady(string placementId)
    // {

    // }
    // public void OnUnityAdsDidError(string message)
    // {
    //     adFailed.SetActive(true);
    //     Invoke("delay", 2f);
    // }
    // public void OnUnityAdsDidStart(string placementId)
    // {

    // }
    
    // public void OnUnityAdsDidFinish(string placementId, ShowResult finish)
    // {
    //     switch (finish)
    //     {
    //         case ShowResult.Finished:
    //             if(placementId == rewardedVideoAd)
    //             {
    //                 SaveManager.Instance.state.money += 20;
    //                 SaveManager.Instance.Save();
    //                 Debug.Log("15 earned");
    //             }
    //             break;
    //         case ShowResult.Failed:
    //             adFailed.SetActive(true);
    //             Invoke("delay", 2f);
    //             break;   
    //         case ShowResult.Skipped:
    //             break;    
                
    //     }
         
    // }
    // public void delay()
    // {
    //     adFailed.SetActive(false);
    // }
}
