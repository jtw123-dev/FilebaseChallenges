using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMinion : MonoBehaviour
{
    [SerializeField] private GameObject _minion;
    [SerializeField] private Transform _spawnLocation;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
          var _clone  = Instantiate(_minion, _spawnLocation.position, Quaternion.identity);
            
        }
        
    }
}
