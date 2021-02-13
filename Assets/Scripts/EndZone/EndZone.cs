using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndZone : MonoBehaviour
{
    [SerializeField] private GameObject _defeatPanel;
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out Enemy enemy))
        {
            Time.timeScale = 0f;
            _defeatPanel.SetActive(true);
        }


    }
}
