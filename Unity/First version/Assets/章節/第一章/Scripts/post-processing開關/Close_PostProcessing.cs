using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Close_PostProcessing : MonoBehaviour
{
    public GameObject BlackWhite_post_processing;
    public void close()
    {
        BlackWhite_post_processing.SetActive(true);
    }
}
