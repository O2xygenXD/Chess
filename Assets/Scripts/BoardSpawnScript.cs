using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardSpawnScript : MonoBehaviour
{

    public GameObject cell_whitePrefab, cell_blackPrefab;
    public Vector3 pos;
    public Transform parent;
    // Start is called before the first frame update
    void Start()
    {
        for (int z = 0; z < 8; z++)
        {
            for (int x = 0; x < 8; x++)
            {
                pos.x = x * 4 - 14;
                pos.z = z * 4 - 14;
                pos.y = -2;
                if((x % 2 == 0 && z % 2 == 0) || (x % 2 == 1 && z % 2 == 1))
                {
                    GameObject BlackCell = Instantiate(cell_blackPrefab, pos, Quaternion.identity);
                    BlackCell.transform.SetParent(parent);
                    
                }
                else if ((x % 2 == 0 && z % 2 == 01) || (x % 2 == 1 && z % 2 == 0))
                {
                    GameObject WhiteCell = Instantiate(cell_whitePrefab, pos, Quaternion.identity);
                    WhiteCell.transform.SetParent(parent);
                }
                
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
