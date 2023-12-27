using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

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
    }

    void Start()
    {
        
    }
    void Update()
    {
        
    }
}
