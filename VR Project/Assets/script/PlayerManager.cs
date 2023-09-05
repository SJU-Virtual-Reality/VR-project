using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;
using UnityEngine.Events;
using System;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    private XRController left_Controller;
    private XRController right_Controller;
    public GameObject Player;

    IEnumerator Vibrate()
    {
        GameObject Camera = GameObject.FindGameObjectWithTag("Player");
        Quaternion quaterninon = Quaternion.identity;

        int cnt = 0;

        quaterninon.eulerAngles = new Vector3(Player.transform.rotation.x, Player.transform.rotation.y, Player.transform.rotation.z + 10);

        //20�� ���� �ݺ�
        while (cnt<20)
        {
            Debug.Log(12312);
            quaterninon.eulerAngles = new Vector3(Player.transform.rotation.x, Player.transform.rotation.y, Player.transform.rotation.z - 20);
            Player.transform.rotation =  quaterninon;
            yield return new WaitForSeconds(0.05f);
            quaterninon.eulerAngles = new Vector3(Player.transform.rotation.x, Player.transform.rotation.y, Player.transform.rotation.z - 20);
            Player.transform.rotation = quaterninon;
            yield return new WaitForSeconds(0.05f);
            cnt++;
        }

        quaterninon.eulerAngles = new Vector3(0, 0, 0);
    }

    //Scene �̵� �� ������Ʈ �ı� X
    private void Awake()
    {
        DontDestroyOnLoad(this);

        left_Controller = (XRController)GameObject.FindObjectsOfType(typeof(XRController))[0];
        right_Controller = (XRController)GameObject.FindObjectsOfType(typeof(XRController))[1];
    }

    //Scene ���� �� Player Controller ����
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

    //��Ʈ�ѷ��� ���� 
    public void ActivateHaptic()
    {
        //Debug.Log("Haptic");
        left_Controller.SendHapticImpulse(0.7f, 2f);
        right_Controller.SendHapticImpulse(0.7f, 2f);
    }
    
    //�÷��̾� ����
    public void VibratePlayer()
    {
        //StartCoroutine(Vibrate());
    }

    public void FallPlayer()
    {
        Player.AddComponent<Rigidbody>().useGravity = true;
    }
}
