using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClientInfoPanel : MonoBehaviour, IPanel
{
    [SerializeField] Text caseNumberTitle;
    [SerializeField] InputField firstName, LastName;

    public void ProcessInfo()
    {
        throw new System.NotImplementedException();
    }
}
