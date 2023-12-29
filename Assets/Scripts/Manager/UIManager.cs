using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI talkText;
    [SerializeField] private GameObject _chatWindow;

    public TalkManager TalkManager;
    public GameObject ScanObject;

    private bool isAction;
    public int talkIndex;

    public bool GetIsAction()
    {
        return isAction;
    }

    private void Awake()
    {
    }

    public void Action(GameObject scanObject)
    {
        ScanObject = scanObject;
        ObjectData objData = scanObject.GetComponent<ObjectData>();
        Talk(objData.id, objData.isNPC);

        _chatWindow.SetActive(isAction);
    }

    void Talk(int id, bool isNPC)
    {
        string talkData = TalkManager.GetTalk(id, talkIndex);

        if(talkData == null)
        {
            isAction = false;
            return;
        }

        if (isNPC)
            talkText.text = talkData;
        else
            talkText.text = talkData;

        isAction = true;
        talkIndex++;
    }
}
