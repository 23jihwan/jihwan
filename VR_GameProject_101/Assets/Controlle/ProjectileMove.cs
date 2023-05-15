using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMove : MonoBehaviour
{


    public enum PROJECTILETYPE                                      //�Ѿ� Ÿ�� ������ ���� Enum ����
    {
        PLAYER,
        ENEMY
    }


    public Vector3 launchDirection;
    public PROJECTILETYPE projectileType = PROJECTILETYPE.PLAYER;   //�Ѿ� Ÿ�� ����
    



    //private void OnCollisionEnter(Collision collision)

    private void OnTriggerEnter(Collider other)           //Trigger �Լ�
    {   //���� �浹�� �ı�
        if(other.gameObject.name=="Wall")         
        {
            Destroy(this.gameObject);
        }
        //���Ϳ� �浹��
        if (other.gameObject.name == "Monster" && projectileType == PROJECTILETYPE.PLAYER)
        {
            //���Ϳ��� �������� �ְ� �������.
            other.gameObject.GetComponent<MonsterController>().Damanged(1);
            Destroy(this.gameObject);
        }

        if (other.gameObject.tag == "Player" && projectileType == PROJECTILETYPE.ENEMY)
        {
            //�÷��̾�� �������� �ְ� �������
            other.gameObject.GetComponent<PlayerControlle>().Damanged(1);
            Destroy(this.gameObject);
        }
    }
    private void FixedUpdate()
    {
        //�ð���� �̵� �� float ������ ����
        float moveAmount = 3 * Time.fixedDeltaTime;
        //launchDirection �������� �߻�ü �̵� (Translate) �̵� ��Ű�� �Լ�
        transform.Translate(launchDirection * moveAmount);
    }
}
