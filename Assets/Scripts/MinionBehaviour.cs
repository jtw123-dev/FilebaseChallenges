using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionBehaviour : MonoBehaviour
{
    [SerializeField] private Transform _spawnLocation;
    [SerializeField] private float _speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * _speed *Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag =="End")
        {
            Destroy(this.gameObject);
        }
    }
}
