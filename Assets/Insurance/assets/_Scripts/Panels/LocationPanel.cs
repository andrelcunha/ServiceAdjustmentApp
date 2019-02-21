using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocationPanel : MonoBehaviour,IPanel
{
    [SerializeField] RawImage map;
    [SerializeField] InputField locationNotes;

    public void ProcessInfo()
    {
        throw new System.NotImplementedException();
    }
}
