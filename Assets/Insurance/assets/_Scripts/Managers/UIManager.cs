using UnityEngine;
using _2MuchPines.Templates;

public class UIManager : MonoBehaviour
{
    public static UIManager _instance;

    public static UIManager Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.LogError("The UI Manager is NULL");
            }
            return _instance;
        }
    }



    public Case activeCase;

    #region MonoBehaviourMethods
    public void Awake()
    {
        _instance = this;
    }
    #endregion

    public void CreateNewCase()
    {
        activeCase = new Case()
        {
            caseID = GenerateCaseNumber().ToString("D10")
        };
    }

    int GenerateCaseNumber()
    {
        return Random.Range(0, 10000);
    }

    string IntCaseNumberToString(int number)
    {
        return number.ToString().PadLeft(10, '0');
    }
}