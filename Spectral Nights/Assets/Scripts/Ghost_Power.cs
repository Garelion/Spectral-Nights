using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost_Power : MonoBehaviour
{
    [SerializeField]
    GameObject Tier1;

    [SerializeField]
    GameObject Tier2;

    [SerializeField]
    GameObject Tier3;

    [SerializeField]
    GameObject Tier4;

    int Tier = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Tier++;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Tier--;
        }

        if (Tier == 0)
        {
            Tier1.SetActive(false);
            Tier2.SetActive(false);
            Tier3.SetActive(false);
            Tier4.SetActive(false);
        }
        else if (Tier == 1)
        {
            Tier1.SetActive(true);
            Tier2.SetActive(false);
            Tier3.SetActive(false);
            Tier4.SetActive(false);
        }
        else if (Tier == 2)
        {
            Tier1.SetActive(true);
            Tier2.SetActive(true);
            Tier3.SetActive(false);
            Tier4.SetActive(false);
        }
        else if (Tier == 3)
        {
            Tier1.SetActive(true);
            Tier2.SetActive(true);
            Tier3.SetActive(true);
            Tier4.SetActive(false);
        }
        else if (Tier >= 4)
        {
            Tier1.SetActive(true);
            Tier2.SetActive(true);
            Tier3.SetActive(true);
            Tier4.SetActive(true);
        }
    }
}
