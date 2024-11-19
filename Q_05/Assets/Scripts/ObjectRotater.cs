using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotater : MonoBehaviour
{
    private void Update()
    {
        if (Time.timeScale == 0f) return; // 타임 스케일이 0일때 정지

        transform.Rotate(Vector3.up * GameManager.Instance.Score);
    }
}
