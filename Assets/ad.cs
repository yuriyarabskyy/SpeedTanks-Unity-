using UnityEngine;
using System.Collections;

public class ad : MonoBehaviour {

	private UnityEngine.iOS.ADInterstitialAd fullscreenAd = null;
	void Start()
	{
		fullscreenAd = new UnityEngine.iOS.ADInterstitialAd();
		UnityEngine.iOS.ADInterstitialAd.onInterstitialWasLoaded  += OnFullscreenLoaded;
	}
	void Update(){
		if(GameObject.FindGameObjectsWithTag("Player").Length<2)
			fullscreenAd.Show();
	}
	
	void OnFullscreenLoaded()
	{
		if(GameObject.FindGameObjectsWithTag("Player").Length<2)
		fullscreenAd.Show();
	}
}
