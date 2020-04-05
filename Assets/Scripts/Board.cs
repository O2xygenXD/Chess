using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    const int FIELD_SIZE = 8;
    public Cell[,] field = new Cell[FIELD_SIZE, FIELD_SIZE];
    public Cell cell_whitePrefab, cell_blackPrefab;
    public Transform parent;
    void Start()
    {
        cellPlacer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void cellPlacer()
    {
        Vector3 pos;
        for (int z = 0; z < FIELD_SIZE; z++)
        {
            for (int x = 0; x < FIELD_SIZE; x++)
            {
                pos.x = x * 4 - 14;
                pos.z = z * 4 - 14;
                pos.y = -2;
                if ((x % 2 == 0 && z % 2 == 0) || (x % 2 == 1 && z % 2 == 1))
                {
                    Cell BlackCell = Instantiate(cell_blackPrefab, pos, Quaternion.identity);
                    BlackCell.transform.SetParent(parent);
                    field[x, z] = BlackCell;
                }
                else if ((x % 2 == 0 && z % 2 == 01) || (x % 2 == 1 && z % 2 == 0))
                {
                    Cell WhiteCell = Instantiate(cell_whitePrefab, pos, Quaternion.identity);
                    WhiteCell.transform.SetParent(parent);
                    field[x, z] = WhiteCell;
                }

            }
        }
        Debug.Log(field[1, 5].transform.position);
    }
}
