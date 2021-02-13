using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBuilder : MonoBehaviour
{
    [SerializeField] private LayerMask _whereNotCanBuild;
    [SerializeField] private Player _player;

    private TemporaryTower _flyingTower;
    private Tower _towerToBuild;
    private bool _isAviable;
    private PlayerInput _playerInput;
    private float position;
    private Ray ray;

    private void Awake()
    {
        _playerInput = new PlayerInput();
    }

    private void OnEnable()
    {
        _playerInput.Enable();
    }

    private void OnDisable()
    {
        _playerInput.Disable();
    }

    private void Update()
    {
        Vector2 mousePosition = _playerInput.Player.MousePosition.ReadValue<Vector2>();
        var groundPlane = new Plane(Vector3.forward, Vector3.zero);
        ray = Camera.main.ScreenPointToRay(mousePosition);
        RaycastHit2D raycast = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(mousePosition), new Vector2(0, 0), 0, _whereNotCanBuild);
        if (groundPlane.Raycast(ray, out position) && _flyingTower != null)
        {
            if (raycast.collider == null) 
                _isAviable = true;
            else
                _isAviable = false;
            Vector2 worldPosition = ray.GetPoint(position);
            _flyingTower.SetColor(_isAviable);
            _flyingTower.transform.position = worldPosition;
        }
    }


    public void Build()
    {
        if (_flyingTower != null && _isAviable)
        {
            Vector2 worldPosition = ray.GetPoint(position);
            Instantiate(_towerToBuild, new Vector3(worldPosition.x, worldPosition.y, 0), Quaternion.identity);
            _flyingTower.SetNormal();
            _player.SpendResourses(_towerToBuild.Cost);
            Destroy(_flyingTower.gameObject);
            _flyingTower = null;
        }
        else if (!_isAviable)
            Destroy(_flyingTower.gameObject);
    }

    
    public void Select(TemporaryTower tower)
    {
        if (_flyingTower != null)
             Destroy(_flyingTower.gameObject);

        _flyingTower = Instantiate(tower);
        _towerToBuild = _flyingTower.TowerToBuild;
        if(_player.ResoursesAmount < _towerToBuild.Cost)
        {
            Destroy(_flyingTower.gameObject);
            _towerToBuild = null;
        }
    }
}
