using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClientInfoPanel : MonoBehaviour, IPanel
{
    [SerializeField] Text caseNumberTitle;
    [SerializeField] InputField firstName, LastName;
    [SerializeField] Button nextButton;

    public void ProcessInfo()
    {
        UIManager.Instance.activeCase.name = string.Format("{0} {1}", firstName.text, LastName.text);
    }

    public void OnEnable()
    {
        UIManager.Instance.CreateNewCase();
        caseNumberTitle.text = "CASE NUMBER " + UIManager.Instance.activeCase.caseID;
    }

    public void EnableButton() 
    {
        if (string.IsNullOrEmpty( firstName.text) || string.IsNullOrEmpty(LastName.text))
        {
            nextButton.interactable = false;
        }
        else 
        {
            nextButton.interactable = true;
        }
    }

}
