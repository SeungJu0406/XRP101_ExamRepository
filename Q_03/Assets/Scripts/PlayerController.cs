using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [field: SerializeField]
    [field: Range(0, 100)]
    public int Hp { get; private set; }

    private AudioSource _audio;
    private Coroutine _dieRoutine;

    private void Awake()
    {
        Init();
    }

    private void Init()
    {
        _audio = GetComponent<AudioSource>();
    }
    
    public void TakeHit(int damage)
    {
        Hp -= damage;

        if (Hp <= 0)
        {
            Hp = 0;
            Die();
        }
    }

    public void Die()
    {
        if (_dieRoutine == null)
        {
           _dieRoutine = StartCoroutine(DieRoutine());
        }
    }
    /// <summary>
    /// �׾��� �� ��ƾ
    /// </summary>
    /// <returns></returns>
    IEnumerator DieRoutine()
    {
        // ���� ���
        _audio.PlayOneShot(_audio.clip);
        yield return new WaitForSeconds(_audio.clip.length); // ���� �ð�
        _dieRoutine = null;
        gameObject.SetActive(false);
    }
}
