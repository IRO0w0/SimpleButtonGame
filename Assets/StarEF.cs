using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI ���ӽ����̽��� �߰��ؾ� �մϴ�.

public class StarEF : MonoBehaviour
{
    public GameObject star; // ������ �� ������Ʈ
    public Button starButton; // UI ��ư

    void Start()
    {
        // ��ư�� Ŭ�� �̺�Ʈ�� ����
        starButton.onClick.AddListener(MakeStar);
    }

    void MakeStar()
    {
        // ���콺 ��ġ�� �� ����
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouse.z = 0;
        Instantiate(star, mouse, Quaternion.identity);
    }
}
