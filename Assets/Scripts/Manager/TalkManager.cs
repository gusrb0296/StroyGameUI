using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
    Dictionary<int, string[]> TalkScript;
    Dictionary<int, Sprite> PortraitData;

    [SerializeField] private Sprite[] _portraitArr;

    private void Awake()
    {
        TalkScript = new Dictionary<int, string[]>();
        PortraitData = new Dictionary<int, Sprite>();
        GenerateScript();
    }

    private void GenerateScript()
    {
        TalkScript.Add(1, new string[] { "평범한 나무 상자다."});
        TalkScript.Add(10, new string[] { "안녕?/0", "만나서 반가워/1"});
        TalkScript.Add(20, new string[] { "처음 보는 얼굴이네/0", "너는 누구야?/1"});

        PortraitData.Add(10 + 0, _portraitArr[0]);
        PortraitData.Add(10 + 1, _portraitArr[1]);
        PortraitData.Add(10 + 2, _portraitArr[2]);
        PortraitData.Add(10 + 3, _portraitArr[3]);
        PortraitData.Add(20 + 0, _portraitArr[4]);
        PortraitData.Add(20 + 1, _portraitArr[5]);
        PortraitData.Add(20 + 2, _portraitArr[6]);
        PortraitData.Add(20 + 3, _portraitArr[7]);
    }

    public string GetTalk(int id, int talkIndex)
    {
        if (talkIndex == TalkScript[id].Length)
            return null;
        else
            return TalkScript[id][talkIndex];
    }

    public Sprite GetPortrait(int id, int portraitIndex)
    {
        return PortraitData[id + portraitIndex];
    }
}
