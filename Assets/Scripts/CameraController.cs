using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform waypointEpilogue;
    public Transform waypointChapter1;
    // Add more waypoints as needed

    public float moveTime = 2f;

    void Start()
    {
        // Optional: Move the camera to the initial position and rotation
        transform.position = waypointEpilogue.position;
        transform.rotation = waypointEpilogue.rotation;
    }

    public void MoveToChapter1()
    {
        iTween.MoveTo(gameObject, iTween.Hash(
            "position", waypointChapter1.position,
            "rotation", waypointChapter1.eulerAngles,
            "time", moveTime,
            "easetype", iTween.EaseType.easeInOutSine
        ));
    }
    // Add more methods for other chapters if needed
}
