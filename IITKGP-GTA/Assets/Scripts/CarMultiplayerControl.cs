using UnityEngine;
using System.Collections;
using UnityStandardAssets.Vehicles.Car;

public class CarMultiplayerControl : MonoBehaviour {

    public GameObject camera;
    
    // Use this for initialization
	void Start () {
        if (!GetComponent<NetworkView>().isMine) {
            GetComponent<CarController>().enabled = false;
            GetComponent<CarUserControl>().enabled = false;
            GetComponent<CarAudio>().enabled = false;
            camera.SetActive(false);
        }

        //NetworkPlayer netPlayer = Network.player;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnSerializeNetworkView(BitStream stream, NetworkMessageInfo info) {
        if (stream.isWriting) {
            Vector3 pos = transform.position;
            stream.Serialize(ref pos);

        }
        else {
            Vector3 posRecieve = Vector3.zero;
            stream.Serialize(ref posRecieve);
            transform.position = posRecieve;
        }
    }
}

