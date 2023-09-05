using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.Events;
//using UnityEngine.InputSystem.XR;

public class GrabSword : MonoBehaviour
{
    //���߿� �� ������ ����� ��Ʈ�ѷ����� �� ����
    public GameObject Sword_Prefab;
    public GameObject GameManager;
    public GameObject newPrefab;    // ���ο� ��Ʈ�ѷ� �������� �Ҵ��մϴ�.
    public GameObject newPrefab2;    // ���ο� ��Ʈ�ѷ� �������� �Ҵ��մϴ�.

    public XRController controller;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            controller.gameObject.SetActive(false);

            // ���ο� �������� �ν��Ͻ�ȭ�Ͽ� ��Ʈ�ѷ��� �Ҵ��մϴ�.
            GameObject newModel = Instantiate(newPrefab, controller.transform);
            controller.model = newModel.transform;

            // ��Ʈ�ѷ��� Ȱ��ȭ�մϴ�.
            controller.gameObject.SetActive(true);

            GameManager.GetComponent<GameManager>().isGrabSword = true;
        }
        else if (Input.GetKeyDown(KeyCode.V))
        {
            controller.gameObject.SetActive(false);

            // ���ο� �������� �ν��Ͻ�ȭ�Ͽ� ��Ʈ�ѷ��� �Ҵ��մϴ�.
            GameObject newModel = Instantiate(newPrefab, controller.transform);
            controller.model = newModel.transform;

            // ��Ʈ�ѷ��� Ȱ��ȭ�մϴ�.
            controller.gameObject.SetActive(true);

            GameManager.GetComponent<GameManager>().isGrabSword = true;
        }
    }

    private void OnMouseDown()
    {
        Debug.Log("Click");
        Sword_Prefab.SetActive(true);
        GameManager.GetComponent<GameManager>().isGrabSword = true;

        Destroy(this.gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Click");

        controller.gameObject.SetActive(false);

        // ���ο� �������� �ν��Ͻ�ȭ�Ͽ� ��Ʈ�ѷ��� �Ҵ��մϴ�.
        GameObject newModel = Instantiate(newPrefab, controller.transform);
        controller.model = newModel.transform;

        // ��Ʈ�ѷ��� Ȱ��ȭ�մϴ�.
        controller.gameObject.SetActive(true);

        GameManager.GetComponent<GameManager>().isGrabSword = true;

        Destroy(this.gameObject);
    }

}
