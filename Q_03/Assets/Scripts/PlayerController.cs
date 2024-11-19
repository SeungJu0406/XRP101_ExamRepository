using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [field: SerializeField]
    [field: Range(0, 100)]
    public int Hp { get; private set; }

    private AudioSource _audio;

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
            Die();
        }
    }

    public void Die()
    {             
        StartCoroutine(DieRoutine());
    }
    /// <summary>
    /// 죽었을 때 루틴
    /// </summary>
    /// <returns></returns>
    IEnumerator DieRoutine()
    {
        // 사운드 재생
        _audio.PlayOneShot(_audio.clip);
        yield return new WaitForSeconds(_audio.clip.length); // 사운드 시간
        gameObject.SetActive(false);
    }
}
