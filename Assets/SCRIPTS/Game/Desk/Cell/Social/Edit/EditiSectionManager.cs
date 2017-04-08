using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditiSectionManager : MonoBehaviour {

    private List<GameObject> coverPhotos;
    private List<GameObject> userPhotos;

    void Awake () {
        CollectCoverPhotos();
        CollectUserPhotos();
    }

    //
    public void CollectCoverPhotos() {
        GameObject[] coverPhotoObjects = GameObject.FindGameObjectsWithTag("CoverPhoto");
        foreach (GameObject obj in coverPhotoObjects) {
            AddCoverPhotosToList(obj);
        }
    }

    public void AddCoverPhotosToList(GameObject cover) {
        coverPhotos.Add(cover);
    }

    //
    public void CollectUserPhotos() {
        GameObject[] userPhotoObjects = GameObject.FindGameObjectsWithTag("UserPhoto");
        foreach (GameObject obj in userPhotoObjects) {
            AddUserPhotosToList(obj);
        }
    }

    public void AddUserPhotosToList(GameObject user) {
        userPhotos.Add(user);
    }

    void Update () {
		
	}
}
