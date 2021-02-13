using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resourse : MonoBehaviour
{
    [SerializeField] private int _amount;

    private PlayerInput _playerInput;
    private Player _player;
    private float _lifeTime = 5.5f;
    private Vector2 _position;

    private void Awake()
    {
        _playerInput = new PlayerInput();
        _playerInput.Enable();
        _player = FindObjectOfType<Player>();        
    }

    
    private void OnEnable()
    {
        _playerInput.Player.Collect.performed += ctx => Collect();
        StartCoroutine(Disactivation());
    }

    private void OnDisable()
    {
        _playerInput.Disable();
        _playerInput.Player.Collect.performed -= ctx => Collect();
    }

    private void Update()
    {
        Vector2 currentPosition =_playerInput.Player.MousePosition.ReadValue<Vector2>();
        Vector2 position = Camera.main.ScreenToWorldPoint(currentPosition);
        _position.x = Mathf.RoundToInt(position.x);
        _position.y = Mathf.RoundToInt(position.y);

       
    }

    private void Collect()
    {
        Vector2 position = new Vector2(Mathf.RoundToInt(transform.position.x), Mathf.RoundToInt(transform.position.y));
        if(_position == position)
        {
            _player.IncreaseResoursesAmount(_amount);
            Destroy(gameObject);
        }
    }

    private IEnumerator Disactivation()
    {
        yield return new WaitForSeconds(_lifeTime);
        Destroy(gameObject);
    }
}
