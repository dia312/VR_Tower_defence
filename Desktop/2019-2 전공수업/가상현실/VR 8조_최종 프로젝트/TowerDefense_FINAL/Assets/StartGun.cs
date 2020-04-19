using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class StartGun : MonoBehaviour
{
    public Transform crossHair;

    Vector3 originSize;

    void Start()
    {
        originSize = crossHair.localScale * 3.2f;
    }
    // Update is called once per frame
    void Update()
    {
        //if(Input.GetButtonDown("Fire1"))
        {
            Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
            RaycastHit hitInfo;

            if (Physics.Raycast(ray, out hitInfo))
            {
                crossHair.position = hitInfo.point;
                crossHair.forward = -1 * ray.direction;
                crossHair.localScale = originSize * hitInfo.distance;
                if (Input.GetButtonDown("Fire1"))
                {
                    Debug.Log(hitInfo.transform.name);

                    if (hitInfo.transform.name.Contains("Button"))
                    {
                        Debug.Log("게임 시작");
                        hitInfo.transform.GetComponent<ChangeScene>().ChangeGameScene();
                        //hitInfo.transform.GetComponent<Drone>().Dmg(1);
                    }

                }
            }
        }
    }
}