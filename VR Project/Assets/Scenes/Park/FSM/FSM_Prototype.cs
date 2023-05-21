using MonsterLove.StateMachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using MonsterLove.StateMachine;
using UnityEngine.Events;
using Unity.EditorCoroutines;

public class FSM_Prototype : MonoBehaviour
{
    /*
    public GameObject GameManager;

    public UnityEvent Init_Start;
    public UnityEvent Init_End;
    public UnityEvent Prepare;
    public UnityEvent Grab_Sword;
    public UnityEvent Tutorial_Start;
    public UnityEvent Start_Start;

    public enum States
    {
        Init,
        Tutorial,
        Start,
        End
    }

    IEnumerator Create_Sword()
    {
        yield return new WaitForSeconds(3f);
        //���� ���� �� �� �������� ����Ʈ 
        //�� ���� ����
        //��Ʈ�ѷ� ���� ����
        Prepare.Invoke();
    }

    StateMachine<States> fsm;
    */

    private void Awake()
    {
        //fsm = StateMachine<States>.Initialize(this);

        //fsm.ChangeState(States.Init);
        
    }

    private void Init_Enter()
    {
        /*
        Debug.Log("Init");
        //��Ʈ�ѷ� ���� �� ���� 
        Init_Start.Invoke();
        StartCoroutine(Create_Sword());
        Init_End.Invoke();
        */
    }

    private void Init_Update()
    {
        /*
        //����ڰ� �˰� ��ȣ�ۿ��� ���
        if (GameManager.GetComponent<GameManager>().isGrabSword == true)
        {
            //����Ǿ�� �ϴ� �Լ�
            //��Ʈ�ѷ� 1�ʰ� ����
            //�˿� ���� �� ����Ʈ
            //��Ʈ�ѷ��� �� ����
            Grab_Sword.Invoke();
            fsm.ChangeState(States.Tutorial);
        }
        */
    }

    private void Tutorial_Enter()
    {
        //���� ����
        //���� �ı��϶�� �ڸ� ����
        //Tutorial_Start.Invoke();
    }

    private void Tutorial_Update() 
    {
        /*
        //ù ������ �ı��� ���
        if (GameManager.GetComponent<GameManager>().isOzoneBroke == true)
        {
            fsm.ChangeState(States.Start);
        }
        */
    }

    private void Start_Enter()
    {
        //���� �ı� ������ UI ����
        //�ʿ��� �� ���� �����ϴ� ������Ʈ Ȱ��ȭ ��ų �� ���� (coroutin Ȱ���Ͽ� ���� �ֱ� ����� ����)
        //Start_Start.Invoke();
    }

    private void Start_Update()
    {
        /*
        //�������� �� ä�����ٸ�
        if (GameManager.GetComponent<GameManager>().ifFullGauge == true)
        {
            fsm.ChangeState(States.End);
        }
        */
    }
}
