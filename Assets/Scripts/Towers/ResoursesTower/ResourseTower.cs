using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourseTower : Tower
{
    [SerializeField] private List<Resourse> _resourses = new List<Resourse>();
    [SerializeField] private Transform _spawnPoint;

    private float _elapsedTime = 0f;

    private void FixedUpdate()
    {
        _elapsedTime += Time.deltaTime;
        if(_elapsedTime >= TimeBetweenAction)
        {
            CreateSun(_spawnPoint);
            _elapsedTime = 0;
        }
    }

    private void CreateSun(Transform spawnPoint)
    {
        int randomIndex = Random.Range(0, _resourses.Count);
        Vector2 position = new Vector2 (spawnPoint.position.x + Random.Range(-1f, 1f), spawnPoint.position.y);
        Resourse resourse = Instantiate(_resourses[randomIndex], position, Quaternion.identity);
        /*suns[randomIndex].gameObject.transform.position = position;
        suns[randomIndex].gameObject.SetActive(true);*/
        ActionAmount--;
        if (ActionAmount == 0)
            Die();
    }
}
