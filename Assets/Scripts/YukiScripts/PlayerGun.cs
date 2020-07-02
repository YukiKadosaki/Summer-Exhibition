using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class PlayerGun : MonoBehaviour
{
    [SerializeField] private GameObject pointerPrefab;
    [SerializeField] private float warpDistance;
    [SerializeField] private float warpInterval;

    private bool weaponed = false;
    private GameObject mainCamera;
    private GameObject gunBody;
    private GameObject[] partOfGun;
    private GameObject player;
    private PlayerScriptYuki playerCS;
    private GameObject pointerObj;
    private Pointer pointer;
    private float warpTime = 0;

    private void Start()
    {
        mainCamera = GameObject.Find("FirstPersonCharacter");
        partOfGun = GameObject.FindGameObjectsWithTag("WarpGun");
        gunBody = GameObject.Find("Handgun_body");
        player = GameObject.FindGameObjectWithTag("Player");
        playerCS = player.GetComponent<PlayerScriptYuki>();
    }

    public void GetGun(Collider other)
    {
        if (other.tag == "Player")
        {
            if (!weaponed)
            {
                foreach(GameObject part in partOfGun)
                {
                    if(null != part.GetComponent<MeshRenderer>())
                    {
                        part.GetComponent<MeshRenderer>().enabled = true;
                    }
                }
                weaponed = true;
                //ポインターを生成
                pointerObj = Instantiate(pointerPrefab) as GameObject;
                pointer = pointerObj.GetComponent<Pointer>();
            }
        }
    }

    private void Update()
    {
        if (weaponed)
        {
            //銃の先からの方向を計算
            Vector3 direction = this.transform.forward;
            RaycastHit hit;
            Ray ray = new Ray(transform.position + transform.forward, this.transform.forward);
            if (Physics.Raycast(ray, out hit, warpDistance, Physics.AllLayers, QueryTriggerInteraction.Ignore))
            {
                    pointer.VisibleChange(true);
                    pointer.PositionChange(hit.point);

                if (warpTime > warpInterval)
                {
                    pointer.AlphaChange(200);
                    if (Input.GetMouseButtonDown(0))
                    {
                        pointer.AlphaChange(0.1f);
                        playerCS.GunWarp(hit.point);
                        warpTime = 0;
                    }
                }
            }
            else
            {
                pointer.VisibleChange(false);
            }
        }
        warpTime += Time.deltaTime;
    }
}
