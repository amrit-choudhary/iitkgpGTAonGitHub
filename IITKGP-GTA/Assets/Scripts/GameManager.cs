using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    public GameObject first, third, car, jet;
    Vector3 firstT, thirdT, carT, jetT;
    public Text help;


    void Awake() {
        instance = this;
    }

    // Use this for initialization
    void Start() {
        firstT = first.transform.position;
        thirdT = third.transform.position;
        carT = car.transform.position;
        jetT = jet.transform.position;
    }

    // Update is called once per frame
    void Update() {

    }

    public void StartGame() {

    }

    public void ChangeMode(string mode) {
        if (mode == "Jet") {
            jet.SetActive(true);
            jet.transform.position = jetT;
            first.SetActive(false);
            third.SetActive(false);
            car.SetActive(false);
            help.text = "WASD or Arrow Keys to fly\nLeft Click to slow down";
        }

        if (mode == "First") {
            jet.SetActive(false);
            first.SetActive(true);
            first.transform.position = firstT;
            third.SetActive(false);
            car.SetActive(false);
            help.text = "";
        }

        if (mode == "Third") {
            jet.SetActive(false);
            first.SetActive(false);
            third.SetActive(true);
            third.transform.position = thirdT;
            car.SetActive(false);
            help.text = "";
        }

        if (mode == "Car") {
            jet.SetActive(false);
            first.SetActive(false);
            third.SetActive(false);
            car.SetActive(true);
            car.transform.position = carT;
            help.text = "";
        }
    }


}
