using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Gun : MonoBehaviour {
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
		if(explosion)
			explosionPs = explosion.GetComponent<ParticleSystem>();
	}
	// Update is called once per frame
	void Update () {
		//if(Input.GetButtonDown("Fire1"))
		{
			Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
			RaycastHit hitInfo;

			if(Physics.Raycast(ray, out hitInfo))
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

                    if (hitInfo.transform.name.Contains("Super_Goblin_test"))
                    {
                        //고블린에 총알이 히트하면,
                        hitInfo.transform.GetComponent<EnemyHp>().Dmg(10);

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
                    }

                    else if (hitInfo.transform.name.Contains("Goblin_test"))
                    {
                        //고블린에 총알이 히트하면,
                        hitInfo.transform.GetComponent<EnemyHp>().Dmg(10);

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
