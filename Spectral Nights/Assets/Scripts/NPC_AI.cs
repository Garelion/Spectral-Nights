using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_AI : MonoBehaviour
{
    [SerializeField] 
    Animator anim;

    [SerializeField]
    GameObject Alert;
    [SerializeField]
    GameObject Question;

    [SerializeField]
    GameObject Worried;
    [SerializeField]
    GameObject Scaredy;
    [SerializeField]
    GameObject Fearful;
    [SerializeField]
    GameObject Trauma;
    [SerializeField]
    GameObject Neutral;

    [SerializeField]
    Sensor Sensor;

    [SerializeField]
    Ghost_Power Power;

    public int Huh_Count = 0;
    public int Scared_Count = 0;
    //bool Scared = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Stop_Huh()
    {
        anim.SetBool("Huh", false);
        Question.SetActive(false);
    }

    public void Hear_Something()
    {
        Huh_Count++;
        if (Huh_Count < 3)
        {
            anim.SetBool("Huh", true);
            Question.SetActive(true);
        }
        else
        {
            Scared_1();
        }
    }

    public void Scared_1()
    {
        Power.AddPower();
        Neutral.SetActive(false);
        Alert.SetActive(true);
        anim.SetBool("Scared", true);
    }

    public void S_Return()
    {
        Alert.SetActive(false);
        anim.SetBool("Scared", false);
    }

    public void Frightened()
    {
        Alert.SetActive(true);
        anim.SetBool("Frightened", true);
        if (Scared_Count == 1)
        {
            Power.AddPower();
            Worried.SetActive(false);
        }
    }

    public void Real_Frightened()
    {
        anim.SetBool("Extreme_Fear", true);
        if (Scared_Count >= 4)
        {
            Power.AddPower();
            Scaredy.SetActive(false);
        }
    }

    public void Huddled_Corner()
    {
        anim.SetBool("Corner", true);
        if (Scared_Count >= 9)
        {
            Power.AddPower();
            Fearful.SetActive(false);
        }
    }
}
