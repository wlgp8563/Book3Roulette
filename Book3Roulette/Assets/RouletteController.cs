using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0;  // ȸ�� �ӵ�  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Ŭ���ϸ� ȸ�� �ӵ��� �����Ѵ�
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10;
        }

        // ȸ�� �ӵ���ŭ �귿�� ȸ����Ų��
        transform.Rotate(0, 0, this.rotSpeed);

        // �귿�� ���ӽ�Ų��(�߰�)
        this.rotSpeed *= 0.96f;
    }
}
