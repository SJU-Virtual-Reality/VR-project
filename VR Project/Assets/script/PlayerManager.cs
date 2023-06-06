using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;
using UnityEngine.Events;
using System;

public class PlayerManager : MonoBehaviour
{
    public UnityEvent Test;
    private XRController xr;

    //Scene 이동 시 오브젝트 파괴 X
    private void Awake()
    {
        xr = (XRController)GameObject.FindObjectOfType(typeof(XRController));
        DontDestroyOnLoad(this);
    }

    //Scene 시작 시 Player Controller 저장
    void Start()
    {

    }

    private void Update()
    {
        /*
        if(Input.GetKeyDown(KeyCode.Space)) {
            Test.Invoke();
        }
        */
    }

    //컨트롤러에 진동 
    public void ActivateHaptic()
    {
        //Debug.Log("Haptic");
        xr.SendHapticImpulse(0.7f, 2f);
    }
    
    //컨트롤러에 Red 이펙트
    public void EffectController(string color)
    {

        Debug.Log(color);
        switch (color)
        {
            case "red":
                break;
            case "yellow":
                break;
            case "green":
                break;

        }
    }
}
