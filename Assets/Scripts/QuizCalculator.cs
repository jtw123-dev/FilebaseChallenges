using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class QuizCalculator : MonoBehaviour
{
    [SerializeField] private List<int> _quizGrades = new List<int>();
    private float _totalGrade;
    private float _averageGrade;
    private int _index;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(_quizGrades.Count);
        for(int i=0; i<_quizGrades.Count;i++)
        {           
            _quizGrades[i] = Random.Range(0, 100);
        }
       
        _totalGrade = _quizGrades.Sum(itm => itm);
        _averageGrade = _totalGrade / _quizGrades.Count;

      if (_averageGrade>=90&&_averageGrade<=100)
        {
            Debug.Log("A");
        }
      else if (_averageGrade>=80 && _averageGrade<=89)
        {
            Debug.Log("B");
        }

      else if (_averageGrade>=70 && _averageGrade<=79)
        {
            Debug.Log("C");
        }

      else if (_averageGrade<70)
        {
            Debug.Log("F");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
