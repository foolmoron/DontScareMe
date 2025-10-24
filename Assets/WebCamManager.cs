using System.Collections;
using UnityEngine;

public class WebCamManager : MonoBehaviour {
    public WebCamTexture Tex;

    void Awake() {
        StartCoroutine(GetCameraTexture());
    }

    IEnumerator GetCameraTexture() {
        yield return Application.RequestUserAuthorization(UserAuthorization.WebCam);
        Tex = new WebCamTexture(1024, 768, 30);
        Tex.Play();
    }
}