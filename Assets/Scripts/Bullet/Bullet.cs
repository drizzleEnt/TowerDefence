using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _showDuration;

    private void OnEnable()
    {
        StartCoroutine(Disactivation());
    }

    private IEnumerator Disactivation()
    {
        yield return new WaitForSeconds(_showDuration);
        gameObject.SetActive(false);
    }
    public void Move(Vector2 targetPosition)
    {
        transform.DOMove(targetPosition, _showDuration);
    }
}
