using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotater : MonoBehaviour
{
    private void Update()
    {
        if (Time.timeScale == 0f) return; // Ÿ�� �������� 0�϶� ����

        transform.Rotate(Vector3.up * GameManager.Instance.Score);
    }
}
