using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AudioManager theAudio;
        theAudio = GetComponent<AudioManager>();
        theAudio.PlayBGM("BGM0");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
