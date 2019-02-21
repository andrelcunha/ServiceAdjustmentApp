using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OverviewPanel : MonoBehaviour, IPanel
{
    [SerializeField] Text caseNumberTitle;
    [SerializeField] Text nameTitle;
    [SerializeField] Text dateTitle;
    [SerializeField] Text locationTitle;
    [SerializeField] Text locationNotes;
    [SerializeField] RawImage photoTaken;
    [SerializeField] Text photoNotes;


    public void ProcessInfo()
    {
        throw new System.NotImplementedException();
    }
}
