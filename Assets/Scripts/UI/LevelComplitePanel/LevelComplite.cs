using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelComplite : MonoBehaviour
{
    [SerializeField] private EnemySpawner _spawner;
    [SerializeField] private GameObject _levelComplitePanel;
 
    private void Awake()
    {
        _spawner.AllEnemiesSlained += OnAllEnemiesDying;
    }

    private void OnDisable()
    {
        _spawner.AllEnemiesSlained -= OnAllEnemiesDying;
    }

    private void OnAllEnemiesDying()
    {
        Time.timeScale = 0f;
        _levelComplitePanel.SetActive(true);
    }
}
