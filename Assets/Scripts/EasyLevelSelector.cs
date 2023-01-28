using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyLevelSelector : MonoBehaviour
{
    [SerializeField] private enum _DifficultySelector
    {
        easy,normal,hard
    }
    [SerializeField] private _DifficultySelector _selector;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(" Your difficulty is " + _selector);
        }
    }
}
