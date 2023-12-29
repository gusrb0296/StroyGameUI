using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    FadeInOut FadeInOut { get; set; }

    public static GameManager Instance
    {
        get
        {
            if(!_instance)
            {
                _instance = FindObjectOfType(typeof(GameManager)) as GameManager;

                if( _instance == null ) 
                {
                    Debug.Log("No Singleton object");
                }
            }
            return _instance;
        }
    }

    private void Awake()
    {
        if (!_instance)
        {
            _instance = this;
        }
        else if( _instance != this )  // �ν��Ͻ��� �����ϴ� ��� ���� ����� �ν��Ͻ��� �����Ѵ�.
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);

        FadeInOut = GetComponent<FadeInOut>();
    }

    void Start()
    {
        
    }
    void Update()
    {
        
    }

    public void NextSceneString()
    {
        FadeInOut.StartFadeOut();
        StartCoroutine(SceneLoad());

    }

    IEnumerator SceneLoad()
    {
        float waitTime = FadeInOut.GetFadeTime();
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene("MainScene");
        FadeInOut.StartFadeIn();
    }
}
