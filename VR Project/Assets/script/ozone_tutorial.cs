using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ozone_tutorial : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Ozone_Prefab;
    GameObject Ozone;
    public GameObject GameManager;

    private void Awake()
    {
        
    }

    void Start()
    {
        Ozone = Instantiate(Ozone_Prefab,this.transform);
    }

    // Update is called once per frame
    void Update()
    {
        //������ �ı��� ���¶�� Event �߻� �� ���� ���·� �Ѿ
        if(Ozone.activeSelf == false)
        {
            GameManager.GetComponent<GameManager>().isOzoneBroke = true;
            Destroy(this.gameObject);
        }
    }
}
