using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundLoop : MonoBehaviour
{

    public static BackgroundLoop instance;

    private void Awake()
    {
       /* 
        if (instance != null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

         //bug idk why it doesn't reset the music
        DontDestroyOnLoad(instance); */
    }
}
