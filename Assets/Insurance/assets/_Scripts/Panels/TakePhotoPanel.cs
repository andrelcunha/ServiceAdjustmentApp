using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TakePhotoPanel : MonoBehaviour, IPanel
{
    [SerializeField] RawImage photoTaken;
    [SerializeField] InputField photoNotes;

    public void ProcessInfo()
    {
        throw new System.NotImplementedException();
    }
}
