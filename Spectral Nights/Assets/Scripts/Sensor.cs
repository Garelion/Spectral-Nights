using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour
{
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
    Animator lamp_anim;
    [SerializeField]
    Animator plate_anim;
    [SerializeField]
    Animator plate_anim2;
    [SerializeField]
    Animator plate_anim3;
    [SerializeField]
    Animator plate_anim4;

    bool door = false;
    bool door2 = false;
    bool open_door = false;
    bool open_door2 = false;
    bool lamp = false;
    bool plate = false;
    bool plate2 = false;
    bool plate3 = false;
    bool plate4 = false;
    bool pillow = false;
    bool pillow2 = false;
    bool fridge = false;
    bool open_fridge = false;

    // Start is called before the first frame update
    void Start()
    {
        T_Mesh = Text.GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && door == true)
        {
            Door.SetActive(false);
            Open_Door.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.E) && open_door == true)
        {
            Open_Door.SetActive(false);
            Door.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.E) && door2 == true)
        {
            Door2.SetActive(false);
            Open_Door2.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.E) && open_door2 == true)
        {
            Open_Door2.SetActive(false);
            Door2.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.E) && lamp == true)
        {
            if (lamp_anim.GetBool("is_On") == false)
            {
                lamp_anim.SetBool("is_On", true);
            }
            else
            {
                lamp_anim.SetBool("is_On", false);
            }
        }

        if (Input.GetKeyDown(KeyCode.E) && plate == true)
        {
            if (plate_anim.GetBool("Rattle") == false)
            {
                plate_anim.SetBool("Rattle", true);
            }
        }

        if (Input.GetKeyDown(KeyCode.E) && plate2 == true)
        {
            if (plate_anim2.GetBool("Rattle") == false)
            {
                plate_anim2.SetBool("Rattle", true);
            }
        }

        if (Input.GetKeyDown(KeyCode.E) && plate3 == true)
        {
            if (plate_anim3.GetBool("Rattle") == false)
            {
                plate_anim3.SetBool("Rattle", true);
            }
        }

        if (Input.GetKeyDown(KeyCode.E) && plate4 == true)
        {
            if (plate_anim4.GetBool("Rattle") == false)
            {
                plate_anim4.SetBool("Rattle", true);
            }
        }

        if (Input.GetKeyDown(KeyCode.E) && pillow == true)
        {

        }

        if (Input.GetKeyDown(KeyCode.E) && pillow2 == true)
        {

        }

        if (Input.GetKeyDown(KeyCode.E) && fridge == true)
        {
            Fridge_Door.SetActive(false);
            Fridge_Open.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.E) && open_fridge == true)
        {
            Fridge_Open.SetActive(false);
            Fridge_Door.SetActive(true);
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
    }
}
