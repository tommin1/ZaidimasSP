using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class restart : MonoBehaviour {

    public void button_clic(string ResetScine)
    {
        Application.LoadLevel(ResetScine);
    }
}
