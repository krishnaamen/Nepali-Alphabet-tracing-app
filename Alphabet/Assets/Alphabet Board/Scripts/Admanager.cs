using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class Admanager : MonoBehaviour
{
    public static Admanager instance;
    private string appID = "ca-app-pub-3940256099942544~3347511713";
    private BannerView bannerView;
    private string bannerID = "ca-app-pub-3940256099942544/6300978111";
    private InterstitialAd fullScreenAd;
    private string fullScreenAdID;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        } else
        {
            Destroy(this);
        }
    }
    public void RequestBanner()
    {
        bannerView = new BannerView(bannerID, AdSize.Banner, AdPosition.Bottom);
        AdRequest request = new AdRequest.Builder().Build();
        bannerView.LoadAd(request);
        bannerView.Show();

    }
}
