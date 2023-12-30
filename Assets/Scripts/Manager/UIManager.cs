using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI talkText;
    [SerializeField] private GameObject _chatWindow;

    public TalkManager TalkManager;
    public GameObject ScanObject;
    public Image PortratiImage;

    private bool isAction;
    public int talkIndex = 0;

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
            talkIndex = 0;
            return;
        }

        if (isNPC)
        {
            talkText.text = talkData.Split('/')[0];

            PortratiImage.sprite = TalkManager.GetPortrait(id, int.Parse(talkData.Split('/')[1]));
            PortratiImage.color = new Color(1, 1, 1, 1);
        }

        else
        {
            talkText.text = talkData;
            PortratiImage.color = new Color(1, 1, 1, 0);
        }

        isAction = true;
        talkIndex++;
    }
}
