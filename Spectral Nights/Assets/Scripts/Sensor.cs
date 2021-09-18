using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour   
{
    public GameObject Ghost_Powerr;
    Ghost_Power GP_script; 
    
    [SerializeField]
    GameObject Text;

    TextMesh T_Mesh;

    [SerializeField]
    GameObject Door;
    [SerializeField]
    GameObject Open_Door;
    [SerializeField]
    GameObject Door2;
    [SerializeField]
    GameObject Open_Door2;
    [SerializeField]
    GameObject Lamp;
    [SerializeField]
    GameObject Plate;
    [SerializeField]
    GameObject Plate2;
    [SerializeField]
    GameObject Plate3;
    [SerializeField]
    GameObject Plate4;
    [SerializeField]
    GameObject Pillow;
    [SerializeField]
    GameObject Pillow2;
    [SerializeField]
    GameObject Fridge_Door;
    [SerializeField]
    GameObject Fridge_Open;
    [SerializeField]
    GameObject SinkOff;
    [SerializeField]
    GameObject SinkOn;
    [SerializeField]
    GameObject PizzaClose;
    [SerializeField]
    GameObject PizzaOpen;
    [SerializeField]
    GameObject Cup;
    [SerializeField]
    GameObject NoodleBox;
    


    [SerializeField]
    Animator lamp_anim;
    [SerializeField]
    Animator plate_anim;
    [SerializeField]
    Animator plate_anim2;
    [SerializeField]
    Animator plate_anim3;
    [SerializeField]
    Animator plate_anim4;   
    [SerializeField]
    Animator cup_anim;
    [SerializeField]
    Animator noodlebox_anim;

    bool door = false;
    bool door2 = false;
    bool open_door = false;
    bool open_door2 = false;
    bool lamp = false;
    bool plate = false;
    bool plate2 = false;
    bool plate3 = false;
    bool plate4 = false;
    bool cup = false;
    bool noodles = false;
    bool pillow = false;
    bool pillow2 = false;
    bool fridge = false;
    bool open_fridge = false;
    bool sinkon = false;
    bool sinkoff = false;
    bool pizzaopen = false;
    bool pizzaclose = false;
    //Start is called before the first frame update
    void Start()
    {
        T_Mesh = Text.GetComponent<TextMesh>();
        GP_script = Ghost_Powerr.GetComponent<Ghost_Power>();
    }

    //Update is called once per frame
    void Update()
    {
        if (GP_script.GetTier() > 0)
       {
            if (Input.GetKeyDown(KeyCode.E) && door == true)
            {
                Door.SetActive(false);
                Open_Door.SetActive(true);
                GP_script.DeductPower();
            }

            if (Input.GetKeyDown(KeyCode.E) && open_door == true)
            {
                Open_Door.SetActive(false);
                Door.SetActive(true);
                GP_script.DeductPower();
            }

            if (Input.GetKeyDown(KeyCode.E) && door2 == true)
            {
                Door2.SetActive(false);
                Open_Door2.SetActive(true);
                GP_script.DeductPower();
            }

            if (Input.GetKeyDown(KeyCode.E) && open_door2 == true)
            {
                Open_Door2.SetActive(false);
                Door2.SetActive(true);
                GP_script.DeductPower();
            }

            if (Input.GetKeyDown(KeyCode.E) && lamp == true)
            {
                if (lamp_anim.GetBool("is_On") == false)
                {
                    lamp_anim.SetBool("is_On", true);
                    GP_script.DeductPower();
                }
                else
                {
                    lamp_anim.SetBool("is_On", false);
                    GP_script.DeductPower();
                }
            }

            if (Input.GetKeyDown(KeyCode.E) && plate == true)
            {
                if (plate_anim.GetBool("Rattle") == false)
                {
                    //plate_anim.SetBool("Rattle", true);
                    StartCoroutine(DelayThrow(Plate));
                }

            }

            if (Input.GetKeyDown(KeyCode.E) && plate2 == true)
            {
                if (plate_anim2.GetBool("Rattle") == false)
                {
                    //plate_anim2.SetBool("Rattle", true);
                    StartCoroutine(DelayThrow(Plate2));
                }
            }

            if (Input.GetKeyDown(KeyCode.E) && plate3 == true)
            {
                if (plate_anim3.GetBool("Rattle") == false)
                {
                    //plate_anim3.SetBool("Rattle", true);
                    StartCoroutine(DelayThrow(Plate3));
                }
            }

            if (Input.GetKeyDown(KeyCode.E) && plate4 == true)
            {
                if (plate_anim4.GetBool("Rattle") == false)
                {
                    //plate_anim4.SetBool("Rattle", true);
                    StartCoroutine(DelayThrow(Plate4));
                }
            }
            
            if (Input.GetKeyDown(KeyCode.E) && cup == true)
            {
                if (cup_anim.GetBool("Rattle") == false)
                {
                    cup_anim.SetBool("Rattle", true);
                    GP_script.DeductPower();

                }
            }

            if (Input.GetKeyDown(KeyCode.E) && noodles == true)
            {
                if (plate_anim4.GetBool("Rattle") == false)
                {
                    noodlebox_anim.SetBool("Rattle", true);
                    GP_script.DeductPower();

                }
            }

            if (Input.GetKeyDown(KeyCode.E) && pillow == true)
            {
                Pillow.transform.Translate((GameObject.Find("Throw_Target")).transform.localPosition);
                GP_script.DeductPower();
            }

            if (Input.GetKeyDown(KeyCode.E) && pillow2 == true)
            {
                Pillow2.transform.Translate((GameObject.Find("Throw_Target_1")).transform.localPosition);
                GP_script.DeductPower();
            }

            if (Input.GetKeyDown(KeyCode.E) && fridge == true)
            {
                Fridge_Door.SetActive(false);
                Fridge_Open.SetActive(true);
                GP_script.DeductPower();
            }

            if (Input.GetKeyDown(KeyCode.E) && open_fridge == true)
            {
                Fridge_Open.SetActive(false);
                Fridge_Door.SetActive(true);
                GP_script.DeductPower();
            }

            if (Input.GetKeyDown(KeyCode.E) && sinkon == true)
            {
                SinkOn.SetActive(false);
                SinkOff.SetActive(true);
                GP_script.DeductPower();
            }

            if (Input.GetKeyDown(KeyCode.E) && sinkoff == true)
            {
                SinkOff.SetActive(false);
                SinkOn.SetActive(true);
                GP_script.DeductPower();
            }

            if (Input.GetKeyDown(KeyCode.E) && pizzaopen == true)
            {
                PizzaOpen.SetActive(false);
                PizzaClose.SetActive(true);
                GP_script.DeductPower();
            }

            if (Input.GetKeyDown(KeyCode.E) && pizzaclose == true)
            {
                PizzaClose.SetActive(false);
                PizzaOpen.SetActive(true);
                GP_script.DeductPower();
            }
     }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Interactables")
        {
            Debug.Log("Item Found");
            T_Mesh.text = "Press E";

            if (other.gameObject == Door)
            {
                door = true;
            }

            if (other.gameObject == Open_Door)
            {
                open_door = true;
            }

            if (other.gameObject == Door2)
            {
                door2 = true;
            }

            if (other.gameObject == Open_Door2)
            {
                open_door2 = true;
            }

            if (other.gameObject == Door)
            {
                door = true;
            }

            if (other.gameObject == Lamp)
            {
                lamp = true;
            }

            if (other.gameObject == Plate)
            {
                plate = true;
            }

            if (other.gameObject == Plate2)
            {
                plate2 = true;
            }

            if (other.gameObject == Plate3)
            {
                plate3 = true;
            }

            if (other.gameObject == Plate4)
            {
                plate4 = true;
            }

            if (other.gameObject == Pillow)
            {
                pillow = true;
            }

            if (other.gameObject == Pillow2)
            {
                pillow2 = true;
            }

            if (other.gameObject == Fridge_Door)
            {
                fridge = true;
            }

            if (other.gameObject == Fridge_Open)
            {
                open_fridge = true;
            }

            if (other.gameObject == SinkOff)
            {
                sinkoff = true;
            }

            if (other.gameObject == SinkOn)
            {
                sinkon = true;
            }

            if (other.gameObject == PizzaClose)
            {
                pizzaclose = true;
            }

            if (other.gameObject == PizzaOpen)
            {
                pizzaopen = true;
            }
            if (other.gameObject == Cup)
            {
                cup = true;
            }

            if (other.gameObject == NoodleBox)
            {
                noodles = true;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Interactables")
        {
            Debug.Log("Item Found");
            T_Mesh.text = "";
        }

        door = false;
        door2 = false;
        open_door = false;
        open_door2 = false;
        lamp = false;
        plate = false;
        plate2 = false;
        plate3 = false;
        plate4 = false;
        pillow = false;
        pillow2 = false;
        fridge = false;
        open_fridge = false;
        sinkoff = false;
        sinkon = false;
        pizzaopen = false;
        pizzaclose = false;
        cup = false;
        noodles = false;
    }
    IEnumerator DelayThrow(GameObject gp)
    {
        yield return new WaitForSeconds(1.0f);
        GameObject target=null;
        if (gp == Plate) { target = GameObject.Find("Throw_Target_2"); }
        else if (gp == Plate2) { target = GameObject.Find("Throw_Target_3"); }
        else if (gp == Plate3) { target = GameObject.Find("Throw_Target_4"); }
        else if (gp == Plate4) { target = GameObject.Find("Throw_Target_5"); }
        if (target != null)
        {
            gp.GetComponent<Animator>().enabled = false;
            gp.GetComponent<BoxCollider2D>().enabled = false;
            gp.transform.Translate(target.transform.localPosition);
            GP_script.DeductPower();
        }
        yield break;
    }
}
