using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Shoot : MonoBehaviour {


    public bool directionChosen = false;
    public Text pradziosVektorius;
    //jega
    public float atstumas;
    public float speed;
    private Rigidbody rb;
    GameObject plyer;
    // kordinates
    public Vector2 startPos;
    public Vector2 endPos;
    public Vector3 metimoKryptis;
    // laikas
    public float StartTime;
    public float EndTime;
    public float laikas;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        // Track a single touch as a direction control.
        if (Input.touchCount > 0)
        {
            var touch = Input.GetTouch(0);
			rb.isKinematic = false;
            // veikia tik tada kai palieciamas ekranas
            switch (touch.phase)
            {
                // plietimo vieta
                case TouchPhase.Began:
                    StartTime = Time.time;
                    startPos = touch.position;
                    directionChosen = false;
                    break;

                // braukimo metu
                case TouchPhase.Moved:
                    break;

                // atledimo vieta
                case TouchPhase.Ended:
                    endPos = touch.position;
                    EndTime = Time.time;
                    Metimas();
                    directionChosen = true;
                    break;
            }
            if(directionChosen)
            {
                Metimas();
                rb.useGravity = true;

                rb.AddForce(metimoKryptis * speed / 34);
            }
        }

    }


       void Metimas()
        {
            atstumas = Atstumas(startPos, endPos);
            laikas = EndTime - StartTime;
            speed = Speed(laikas, atstumas);
            metimoKryptis = MetimoKryptis(startPos, endPos);

            // Something that uses the chosen direction...
        }

    // metimo krytis is vector2
    Vector3 MetimoKryptis(Vector2 pr, Vector2 pb)
    {
        return new Vector3((atstumas), (-480), (pb.x-400));
    }
    // paskaiciuoja greti 
    float Speed(float time, float Dis)
    {
        return Dis / time;
    }
    // paskaiciuoja atstuma tarp dveju vektoriu
    float Atstumas(Vector2 p, Vector2 pb)
    {
        return p.y - pb.y;
    }




}
