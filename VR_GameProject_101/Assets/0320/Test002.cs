using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test002 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int answer;                 //���� int answer ����
        answer = 1 + 2;             //answer�� 1 + 2 �� �Է� 
        Debug.Log(answer);           //Console.log() answer ���� ������ 

        int n1 = 8;                 //���� int ���� �̸��� n1�̰� 8�� ���� �Է�
        int n2 = 9;                 //���� int ���� �̸��� n1�̰� 9�� ���� �Է�
        int answer2;                 //Consle.log() answer2 ���� ������
        answer2 = n1 + n2;          //answer2�� ���� n1 ���� n2 ���� ���� ���� �Է�
        Debug.Log(answer2);         //Console.log() answer2 ���� ������

        answer2 += 5;               //answer2 = answer2 + 5�� ���
        Debug.Log(answer2);         //Console.log() answer2 ���� ������
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
