using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipsSystem : MonoBehaviour
{

    private Vector2 initialPos;                              //iniaialPos선언
    public GameObject Character;                             //Character 프리팹 선언

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0)) initialPos = Input.mousePosition;               //눌렀을 때 마우스 위치를 저장한다.
        if (Input.GetMouseButtonUp(0)) Caloulate(Input.mousePosition);                    //마우스가 Up 되었을때 인수로는 마우스 위치를 입력하고 함수를 호출한다.
    }
    void Caloulate(Vector3 finalPos)
    {
        float disX = Mathf.Abs(initialPos.x - finalPos.x);              //절대값 (Mathf.Abs) disX는 distance의 약자 (거리)
        float disY = Mathf.Abs(initialPos.y - finalPos.y);              //절대값 (Mathf.Abs)

        if (disX > disY)
        {
            if (initialPos.x > finalPos.x)
            {
                Character.transform.position += new Vector3(-1.0f, 0.0f, 0.0f); //왼쪽
            }
            else
            {
                Character.transform.position += new Vector3(1.0f, 0.0f, 0.0f);     //오른쪽
            }
        }
        else
        {
            if (initialPos.y > finalPos.y)
            {
                Character.transform.position += new Vector3(0.0f, 0.0f, -1.0f); //뒤쪽
            }
            else
            {
                Character.transform.position += new Vector3(0.0f, 0.0f, 1.0f); //앞쪽
             }
            }
        }   
    }


