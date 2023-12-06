using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistantGroup : MonoBehaviour
{
    public static PersistantGroup Instance;
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(this);
        DontDestroyOnLoad(gameObject);
    }


}