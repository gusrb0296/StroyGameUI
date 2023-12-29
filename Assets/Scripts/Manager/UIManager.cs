using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI talkText;
    [SerializeField] private GameObject _chatWindow;

    private bool isAction;

    public bool GetIsAction()
    {
        return isAction;
    }

    private void Awake()
    {
    }

    public void Action(GameObject scanObject)
    {
        if (isAction)
        {
            isAction = false;
        }
        else
        {
            isAction = true;
            talkText.text = "�̰��� �̸��� " + scanObject.name + "�̴�.";
        }
        _chatWindow.SetActive(isAction);
    }
}
