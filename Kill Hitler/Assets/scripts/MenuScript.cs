using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class MenuScript : MonoBehaviour
{
    bool boss;
    private void Start()
    {
        boss = true;
        Advertisement.Initialize("1290840", false);
    }

    public void ChangeScene()
    {
        gameManager.ShowAd = false;
        backred.btnads = true;
        FadeInOut.sceneEnd = true;
    }

    public void ChangeScene2()
    {
        gameManager.ShowAd = false;
        backred.btnads = true;
        FadeInOut.sceneEnd2 = true;
    }

    public void ShowRewardedAd()
    {
        const string RewardedPlacementId = "rewardedVideo";
        var options = new ShowOptions { resultCallback = HandleShowResult };
        to:
        if (!Advertisement.IsReady(RewardedPlacementId))
        {
            Debug.Log(string.Format("Ads not ready for placement '{0}'", RewardedPlacementId));
            goto to;
        }
        Advertisement.Show(RewardedPlacementId, options);
    }

    private void HandleShowResult(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Finished:
                Debug.Log("The ad was successfully shown.");
                gameManager.ShowAd = true;
                backred.btnads = false;
                if((gameManager.score >= 1000)&&(boss))
                {
                    boss = false;
                    Application.LoadLevel("boss");
                } else Application.LoadLevel("mainScene");
                break;
            case ShowResult.Skipped:
                Debug.Log("The ad was skipped before reaching the end.");
                Application.LoadLevel("die");
                break;
            case ShowResult.Failed:
                Debug.LogError("The ad failed to be shown.");
                Application.LoadLevel("die");
                break;
        }
    }
}