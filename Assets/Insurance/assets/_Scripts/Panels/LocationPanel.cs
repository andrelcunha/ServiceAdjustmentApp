using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocationPanel : MonoBehaviour, IPanel
{
    [SerializeField] RawImage mapImg;
    [SerializeField] InputField locationNotes;
    [SerializeField] string apiKey;
    [SerializeField] string url = "https://maps.googleapis.com/maps/api/staticmap?";

    public float xCord, yCord;
    [SerializeField] int zoom;
    [SerializeField] int imgSize;


    IEnumerator Start()
    {
        yield return StartCoroutine(FetchGeoData());
        StartCoroutine(GetLocationRoutine());
    }

    public void ProcessInfo()
    {
        throw new System.NotImplementedException();
    }

    public void UrlConstructor()
    {
        url += "&center=" + xCord + "," + yCord;
        url += "&zoom=" + zoom;
        url += "&size=" + imgSize + "x" + imgSize;
        url += "&key=" + apiKey;
    }

    IEnumerator GetLocationRoutine()
    {
        UrlConstructor();
        Debug.Log("URL: " + url);
        using (WWW wwwMap = new WWW(url))
        {
            yield return wwwMap;
            if (wwwMap.error != null)
            {
                Debug.LogError("WWW Error: " + wwwMap.error);
            }
            mapImg.texture = wwwMap.texture;
        }
    }

    IEnumerator FetchGeoData() 
    {
        if ((Input.location.isEnabledByUser == true))
        {
            //start service
            Input.location.Start();
            int maxWait = 20;
            while (Input.location.status == LocationServiceStatus.Initializing
                && maxWait > 0)
            {
                yield return new WaitForSeconds(1.0f);
                maxWait--;
            }

            if (maxWait < 1)
            {
                Debug.Log("Time out");
                yield break;
            }

            if (Input.location.status == LocationServiceStatus.Failed)
            {
                Debug.Log("Unable to determine device location...");
            }
            else
            {
                xCord = Input.location.lastData.latitude;
                yCord = Input.location.lastData.longitude;
            }

            Input.location.Stop();
        }
        else
        {
            Debug.Log("Location services are not Enabled");
        }
    }
}
