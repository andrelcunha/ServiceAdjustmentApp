using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocationPanel : MonoBehaviour,IPanel
{
    [SerializeField] RawImage mapImg;
    [SerializeField] InputField locationNotes;
    [SerializeField] string apiKey;
    [SerializeField] string url = "https://maps.googleapis.com/maps/api/staticmap?";

    public float xCord, yCord;
    [SerializeField] int zoom;
    [SerializeField] int imgSize;


    public void OnEnable()
    {
        UrlConstructor();
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
        using (WWW wwwMap = new WWW(url))
        {
            yield return wwwMap;
            if(wwwMap.error != null)
            {
                Debug.LogError("WWW Error: " + wwwMap.error);
            }
            mapImg.texture = wwwMap.texture;
        }
    }
}
