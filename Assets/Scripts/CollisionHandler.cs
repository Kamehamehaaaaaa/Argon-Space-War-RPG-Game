using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] float loadDelay = 1f;
    [SerializeField] ParticleSystem crashVFX;

    void OnTriggerEnter(Collider other) 
    {
        StartCrashSequence();
    }

    void StartCrashSequence()
    {
        crashVFX.Play();
        EnableMeshRendererShipParts(false);
        GetComponent<PlayerControls>().SetLasersActive(false);
        GetComponent<PlayerControls>().enabled = false;
        GetComponent<BoxCollider>().enabled = false;
        Invoke("ReloadLevel", loadDelay);
    }

    void EnableMeshRendererShipParts(bool isActive)
    {
        GameObject childObjPlayerShip = gameObject.transform.GetChild(0).gameObject;
        MeshRenderer[] meshRendererShipParts = childObjPlayerShip.GetComponentsInChildren<MeshRenderer>();
        foreach (MeshRenderer meshRendererShipPart in meshRendererShipParts)
        {
            meshRendererShipPart.enabled = isActive;
        }
    }

    void ReloadLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}
