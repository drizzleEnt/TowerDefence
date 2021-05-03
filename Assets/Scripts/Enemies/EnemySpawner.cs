using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private List<Wave> _waves;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private Transform[] _wayPoints;
    [SerializeField] private float _timeBetweenWave;

    private List<Enemy> _enemies = new List<Enemy>();
    private Wave _currentWave;
    private int _currentWaveNumber = 0;
    private float _timeAfterLastSpawn;
    private int _spawned;
    private float _timeAfterWave;

    public event UnityAction AllEnemiesSpawned;
    public event UnityAction AllEnemiesSlained;

    private void Start()
    {
        SetWave(_currentWaveNumber);
    }

    private void Update()
    {
        /*_timeAfterWave += Time.deltaTime;
        if (_timeAfterWave <= _timeBetweenWave)
            return;*/
        if (_currentWave == null)
            return;
        _timeAfterLastSpawn += Time.deltaTime;

        if(_timeAfterLastSpawn >= _currentWave.Deley)
        {
            InstantiateEnemy();
            _spawned++;
            _timeAfterLastSpawn = 0;
        }

        if(_currentWave.Count <= _spawned)
        {
            if (_waves.Count > _currentWaveNumber + 1)
                AllEnemiesSpawned?.Invoke();

            _currentWave = null;
        }

    }

    private void InstantiateEnemy()
    {
        Enemy enemy = Instantiate(_currentWave.Tamplate, _spawnPoint.position, _spawnPoint.rotation, _spawnPoint).GetComponent<Enemy>();
        enemy.Init(_wayPoints);
        enemy.IsDead += OnEnemyDying;
        _enemies.Add(enemy);
    }

    private void SetWave(int index)
    {
        _currentWave = _waves[index];
    }

    private void OnEnemyDying(Enemy enemy)
    {
        enemy.IsDead -= OnEnemyDying;
        _player.IncreaseResoursesAmount(enemy.Reward);
        if (_waves.Count == _currentWaveNumber + 1 && _spawned == _enemies.Count)
            AllEnemiesSlained?.Invoke();
        _enemies.Remove(enemy);
    }

    public void NextWave()
    {
        SetWave(++_currentWaveNumber);
        _spawned = 0;
    }
}

[System.Serializable]
public class Wave
{
    public GameObject Tamplate;
    public float Deley;
    public int Count;
}
