using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WhichMinLenShouldOpen : MonoBehaviour
{
    [SerializeField] private UnityEvent Ep3_MinLen_SetUp , Final1_MinLen_SetUp , Final2_MinLen_SetUp;

    void Start()
    {
        if(PlayerPrefs.GetInt("Ep3-MinLen") == 1)
        {
            Ep3_MinLen_SetUp.Invoke();
        }
        if (PlayerPrefs.GetInt("Final1-MinLen") == 1)
        {
            Final1_MinLen_SetUp.Invoke();
        }
        if (PlayerPrefs.GetInt("Final2-MinLen") == 1)
        {
            Final2_MinLen_SetUp.Invoke();
        }
    }
}
