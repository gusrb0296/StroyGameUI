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
        TalkScript.Add(1, new string[] { "�ȳ�?", "������ �ݰ���"});
        TalkScript.Add(2, new string[] { "ó�� ���� ���̳�", "�ʴ� ������?"});
    }

    public string GetTalk(int id, int talkIndex)
    {
        if (talkIndex == TalkScript[id].Length)
            return null;
        else
            return TalkScript[id][talkIndex];
    }
}
