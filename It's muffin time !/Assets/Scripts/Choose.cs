using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class Choose : MonoBehaviour
{
    private int Test = 6;
    public GameObject First;
    public GameObject Second;
    public GameObject Third;
    public GameObject Fourth;
    public GameObject Fifth;
    public GameObject Sixth;
    public GameObject Blue;
    public GameObject Red;
    public GameObject Green;
    public GameObject Grey;
    public GameObject Orange;
    public GameObject Drone;
    public GameObject CameraViewAll;
    private GameObject selected;
    // Start is called before the first frame update
    void Start()
    {
        if (Test == 0)
        {
            selected = null;
        }
        else if (Test == 1)
        {
            selected = Blue;
        } else if (Test == 2)
        {
            selected = Red;
        }
        else if (Test == 3)
        {
            selected = Green;
        }
        else if (Test == 4)
        {
            selected = Grey;
        }
        else if (Test == 5)
        {
            selected = Orange;
        }
        else if (Test == 6)
        {
            selected = Drone;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            if (Input.GetKey(KeyCode.LeftShift) ) { 
                if (Test > 0) { 
                    Test -= 1;
                } else
                {
                    Test = 6;
                }
            } else
            {
                if (Test <= 5){
                    Test += 1;
                } else {
                    Test = 0;
                }
            }
        }
        if (Test == 0)
        {
            First.SetActive(false);
            Second.SetActive(false);
            Third.SetActive(false);
            Fourth.SetActive(false);
            Fifth.SetActive(false);
            Sixth.SetActive(false);
            CameraViewAll.SetActive(true);
            Blue.GetComponent<PrometeoCarController>().enabled = false;
            Red.GetComponent<PrometeoCarController>().enabled = false;
            Green.GetComponent<PrometeoCarController>().enabled = false;
            Grey.GetComponent<PrometeoCarController>().enabled = false;
            Orange.GetComponent<PrometeoCarController>().enabled = false;
            Drone.GetComponent<DroneMovement>().enabled = false;
            selected = null;
        }
        else if (Test == 1)
        {
            First.SetActive(true);
            Second.SetActive(false);
            Third.SetActive(false);
            Fourth.SetActive(false);
            Fifth.SetActive(false);
            Sixth.SetActive(false);
            CameraViewAll.SetActive(false);
            Blue.GetComponent<PrometeoCarController>().enabled = true;
            Red.GetComponent<PrometeoCarController>().enabled = false;
            Green.GetComponent<PrometeoCarController>().enabled = false;
            Grey.GetComponent<PrometeoCarController>().enabled = false;
            Orange.GetComponent<PrometeoCarController>().enabled = false;
            Drone.GetComponent<DroneMovement>().enabled = false;
            selected = Blue;
        }
        else if (Test == 2)
        {
            First.SetActive(false);
            Second.SetActive(true);
            Third.SetActive(false);
            Fourth.SetActive(false);
            Fifth.SetActive(false);
            Sixth.SetActive(false);
            CameraViewAll.SetActive(false);
            Blue.GetComponent<PrometeoCarController>().enabled = false;
            Red.GetComponent<PrometeoCarController>().enabled = true;
            Green.GetComponent<PrometeoCarController>().enabled = false;
            Grey.GetComponent<PrometeoCarController>().enabled = false;
            Orange.GetComponent<PrometeoCarController>().enabled = false;
            Drone.GetComponent<DroneMovement>().enabled = false;
            selected = Red;
        }
        else if (Test == 3)
        {
            First.SetActive(false);
            Second.SetActive(false);
            Third.SetActive(true);
            Fourth.SetActive(false);
            Fifth.SetActive(false);
            Sixth.SetActive(false);
            CameraViewAll.SetActive(false);
            Blue.GetComponent<PrometeoCarController>().enabled = false;
            Red.GetComponent<PrometeoCarController>().enabled = false;
            Green.GetComponent<PrometeoCarController>().enabled = true;
            Grey.GetComponent<PrometeoCarController>().enabled = false;
            Orange.GetComponent<PrometeoCarController>().enabled = false;
            Drone.GetComponent<DroneMovement>().enabled = false;
            selected = Green;
        }
        else if (Test == 4)
        {
            First.SetActive(false);
            Second.SetActive(false);
            Third.SetActive(false);
            Fourth.SetActive(true);
            Fifth.SetActive(false);
            Sixth.SetActive(false);
            CameraViewAll.SetActive(false);
            Blue.GetComponent<PrometeoCarController>().enabled = false;
            Red.GetComponent<PrometeoCarController>().enabled = false;
            Green.GetComponent<PrometeoCarController>().enabled = false;
            Grey.GetComponent<PrometeoCarController>().enabled = true;
            Orange.GetComponent<PrometeoCarController>().enabled = false;
            Drone.GetComponent<DroneMovement>().enabled = false;
            selected = Grey;
        }
        else if (Test == 5)
        {
            First.SetActive(false);
            Second.SetActive(false);
            Third.SetActive(false);
            Fourth.SetActive(false);
            Fifth.SetActive(true);
            Sixth.SetActive(false);
            CameraViewAll.SetActive(false);
            Blue.GetComponent<PrometeoCarController>().enabled = false;
            Red.GetComponent<PrometeoCarController>().enabled = false;
            Green.GetComponent<PrometeoCarController>().enabled = false;
            Grey.GetComponent<PrometeoCarController>().enabled = false;
            Orange.GetComponent<PrometeoCarController>().enabled = true;
            Drone.GetComponent<DroneMovement>().enabled = false;
            selected = Orange;
        }
        else if (Test == 6)
        {
            First.SetActive(false);
            Second.SetActive(false);
            Third.SetActive(false);
            Fourth.SetActive(false);
            Fifth.SetActive(false);
            Sixth.SetActive(true);
            CameraViewAll.SetActive(false);
            Blue.GetComponent<PrometeoCarController>().enabled = false;
            Red.GetComponent<PrometeoCarController>().enabled = false;
            Green.GetComponent<PrometeoCarController>().enabled = false;
            Grey.GetComponent<PrometeoCarController>().enabled = false;
            Orange.GetComponent<PrometeoCarController>().enabled = false;
            Drone.GetComponent<DroneMovement>().enabled = true;
            selected = Drone;
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            selected.transform.position = new Vector3(((-1 * Test * 10) + 10), 1, 0);
            selected.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
