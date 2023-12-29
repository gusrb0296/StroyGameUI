using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
    Dictionary<int, string[]> TalkScript;

    private void Awake()
    {
        TalkScript = new Dictionary<int, string[]>();
        GenerateScript();
    }

    private void GenerateScript()
    {
        TalkScript.Add(1, new string[] { "안녕?", "만나서 반가워"});
        TalkScript.Add(2, new string[] { "처음 보는 얼굴이네", "너는 누구야?"});
    }

    public string GetTalk(int id, int talkIndex)
    {
        if (talkIndex == TalkScript[id].Length)
            return null;
        else
            return TalkScript[id][talkIndex];
    }
}
