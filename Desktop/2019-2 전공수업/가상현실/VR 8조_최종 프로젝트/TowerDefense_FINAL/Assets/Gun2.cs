using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Gun2 : MonoBehaviour
{
    public Transform bulletImpact;
    public Transform explosion;

    ParticleSystem bulletps;
    ParticleSystem explosionPs;

    public Transform crossHair;

    Vector3 originSize;

    void Start()
    {
        originSize = crossHair.localScale * 3.2f;
        if (bulletImpact)
            bulletps = bulletImpact.GetComponent<ParticleSystem>();
        if (explosion)
            explosionPs = explosion.GetComponent<ParticleSystem>();
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
                    if (bulletImpact)
                    {
                        bulletImpact.up = hitInfo.normal;
                        bulletImpact.position = hitInfo.point + hitInfo.normal * 0.2f;
                        bulletps.Stop();
                        bulletps.Play();
                    }
                    Debug.Log(hitInfo.transform.name);
                    if (hitInfo.transform.name.Contains("Super_Goblin_test"))
                    {
                        //드론에 총알이 히트하면,
                        if (explosion) //폭파 이펙트가 있으면
                        {
                            explosion.position = hitInfo.transform.position;

                            //이펙트 재생
                            explosionPs.Stop();
                            explosionPs.Play();

                            //오디오 재생
                            explosion.GetComponent<AudioSource>().Stop();
                            explosion.GetComponent<AudioSource>().Play();

                        }
                        Debug.Log("슈퍼고블린 공격");
                        hitInfo.transform.GetComponent<Goblin_test2>().EHp.Dmg(10);
                        //hitInfo.transform.GetComponent<Drone>().Dmg(1);
                    }
                    else if (hitInfo.transform.name.Contains("Goblin_test"))
                    {
                        //드론에 총알이 히트하면,
                        if (explosion) //폭파 이펙트가 있으면
                        {
                            explosion.position = hitInfo.transform.position;

                            //이펙트 재생
                            explosionPs.Stop();
                            explosionPs.Play();

                            //오디오 재생
                            explosion.GetComponent<AudioSource>().Stop();
                            explosion.GetComponent<AudioSource>().Play();

                        }
                        Debug.Log("일반고블린 공격");

                        hitInfo.transform.GetComponent<Goblin_test>().EHp.Dmg(10);
                        //hitInfo.transform.GetComponent<Drone>().Dmg(1);
                    }
                    else if (hitInfo.transform.name.Contains("Open"))
                    {
                        Debug.Log("Popup창 띄움!");

                        hitInfo.transform.GetComponent<OpenPopUP>().openClick();
                        //hitInfo.transform.GetComponent<Drone>().Dmg(1);
                    }
                    else if (hitInfo.transform.name.Contains("C1"))
                    {
                        Debug.Log("30증가!");

                        hitInfo.transform.GetComponent<ButtonEvent>().openClick();
                        //hitInfo.transform.GetComponent<Drone>().Dmg(1);
                    }
                    else if (hitInfo.transform.name.Contains("C2"))
                    {
                        Debug.Log("50증가!");

                        hitInfo.transform.GetComponent<ButtonEvent2>().openClick();
                        //hitInfo.transform.GetComponent<Drone>().Dmg(1);
                    }
                    else if (hitInfo.transform.name.Contains("C3"))
                    {
                        Debug.Log("100증가!");

                        hitInfo.transform.GetComponent<ButtonEvent3>().openClick();
                        //hitInfo.transform.GetComponent<Drone>().Dmg(1);
                    }
                    else if (hitInfo.transform.name.Contains("Exit"))
                    {
                        Debug.Log("Popup 나가기!");

                        hitInfo.transform.GetComponent<Exit>().exitClick();
                        //hitInfo.transform.GetComponent<Drone>().Dmg(1);
                    }
                    else if (hitInfo.transform.name.Contains("out"))
                    {
                        Debug.Log("cantbuy 나가기!");

                        hitInfo.transform.GetComponent<Exit2>().exit2Click();
                        //hitInfo.transform.GetComponent<Drone>().Dmg(1);
                    }
                    else if (hitInfo.transform.name.Contains("restart"))
                    {
                        Debug.Log("cantbuy 나가기!");

                        hitInfo.transform.GetComponent<GameRestart>().REClick();
                        //hitInfo.transform.GetComponent<Drone>().Dmg(1);
                    }
                    else
                    {
                        if (bulletImpact)
                        {
                            bulletImpact.GetComponent<AudioSource>().Stop();
                            bulletImpact.GetComponent<AudioSource>().Play();
                        }
                    }
                }
            }
        }
    }
}