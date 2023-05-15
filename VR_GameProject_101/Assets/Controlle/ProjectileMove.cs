using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMove : MonoBehaviour
{


    public enum PROJECTILETYPE                                      //총알 타입 구분을 위해 Enum 선언
    {
        PLAYER,
        ENEMY
    }


    public Vector3 launchDirection;
    public PROJECTILETYPE projectileType = PROJECTILETYPE.PLAYER;   //총알 타입 선언
    



    //private void OnCollisionEnter(Collision collision)

    private void OnTriggerEnter(Collider other)           //Trigger 함수
    {   //벽에 충돌시 파괴
        if(other.gameObject.name=="Wall")         
        {
            Destroy(this.gameObject);
        }
        //몬스터에 충돌시
        if (other.gameObject.name == "Monster" && projectileType == PROJECTILETYPE.PLAYER)
        {
            //몬스터에게 데미지를 주고 사라진다.
            other.gameObject.GetComponent<MonsterController>().Damanged(1);
            Destroy(this.gameObject);
        }

        if (other.gameObject.tag == "Player" && projectileType == PROJECTILETYPE.ENEMY)
        {
            //플레이어에게 데미지를 주고 사라진다
            other.gameObject.GetComponent<PlayerControlle>().Damanged(1);
            Destroy(this.gameObject);
        }
    }
    private void FixedUpdate()
    {
        //시간대비 이동 량 float 값으로 선언
        float moveAmount = 3 * Time.fixedDeltaTime;
        //launchDirection 방향으로 발사체 이동 (Translate) 이동 시키는 함수
        transform.Translate(launchDirection * moveAmount);
    }
}
