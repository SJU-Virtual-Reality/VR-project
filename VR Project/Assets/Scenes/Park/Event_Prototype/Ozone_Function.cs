using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Ozone_Function : MonoBehaviour
{
    public UnityEvent EndEvent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //�÷��̾�� �浹 �� ���� ������ �̺�Ʈ
        if(other.tag == "Player")
        {
            EndEvent.Invoke();
        }
    }
}
