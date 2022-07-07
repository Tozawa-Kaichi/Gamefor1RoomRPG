using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageCreate : MonoBehaviour
{
    [SerializeField] int row = 0;
    [SerializeField] int columns = 0;
    [SerializeField] GameObject _massObject;
    GameObject[,] _mass;
    // Start is called before the first frame update
    void Start()
    {
        _mass = new GameObject[row,columns];
        for (var r = 0; r < _mass.GetLength(0); r++)
        {
            for (var c = 0; c < _mass.GetLength(1); c++)
            {
                Vector3 pos = new Vector3(r, c, 0);
                var obj = Instantiate(_massObject, pos, Quaternion.identity);
                _mass[r, c] = obj;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
