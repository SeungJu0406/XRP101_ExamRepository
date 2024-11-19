using UnityEngine;

public class SingletonBehaviour<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _instance;
    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<T>();
                DontDestroyOnLoad(_instance.gameObject);
            }

            return _instance;
        }
    }

    protected void SingletonInit()
    {
        if (_instance != null)
        {
            Destroy(gameObject);
            return;
        }
        _instance = GetComponent<T>();
        DontDestroyOnLoad(gameObject);

    }
}
