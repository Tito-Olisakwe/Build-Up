using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraController : MonoBehaviour
{
    public Transform waypointEpilogue;
    public Transform waypointChapter1;
    public Transform waypointChapter2;
    public Transform waypointChapter3;
    public Transform waypointChapter4;
    public Transform waypointChapter5;
    public Transform waypointChapter6;
    public Transform waypointChapter7;

    public float moveTime = 2f;

    void Start()
    {
        transform.position = waypointEpilogue.position;
        transform.rotation = waypointEpilogue.rotation;
    }

    public void MoveToEpilogue()
    {
        iTween.MoveTo(gameObject, iTween.Hash(
            "position", waypointEpilogue.position,
            "time", moveTime,
            "easetype", iTween.EaseType.easeInOutSine,
            "oncompletetarget", gameObject
        ));

        iTween.RotateTo(gameObject, iTween.Hash(
            "rotation", waypointEpilogue.eulerAngles,
            "time", moveTime,
            "easetype", iTween.EaseType.easeInOutSine
        ));
    }

    public void MoveToChapter1()
    {
        iTween.MoveTo(gameObject, iTween.Hash(
            "position", waypointChapter1.position,
            "time", moveTime,
            "easetype", iTween.EaseType.easeInOutSine,
            "oncompletetarget", gameObject
        ));

        iTween.RotateTo(gameObject, iTween.Hash(
            "rotation", waypointChapter1.eulerAngles,
            "time", moveTime,
            "easetype", iTween.EaseType.easeInOutSine
        ));
    }

    public void MoveToChapter2()
    {
        iTween.MoveTo(gameObject, iTween.Hash(
            "position", waypointChapter2.position,
            "time", moveTime,
            "easetype", iTween.EaseType.easeInOutSine,
            "oncompletetarget", gameObject
        ));

        iTween.RotateTo(gameObject, iTween.Hash(
            "rotation", waypointChapter2.eulerAngles,
            "time", moveTime,
            "easetype", iTween.EaseType.easeInOutSine
        ));
    }

    public void MoveToChapter3()
    {
        iTween.MoveTo(gameObject, iTween.Hash(
            "position", waypointChapter3.position,
            "time", moveTime,
            "easetype", iTween.EaseType.easeInOutSine,
            "oncompletetarget", gameObject
        ));

        iTween.RotateTo(gameObject, iTween.Hash(
            "rotation", waypointChapter3.eulerAngles,
            "time", moveTime,
            "easetype", iTween.EaseType.easeInOutSine
        ));
    }

    public void MoveToChapter4()
    {
        iTween.MoveTo(gameObject, iTween.Hash(
            "position", waypointChapter4.position,
            "time", moveTime,
            "easetype", iTween.EaseType.easeInOutSine,
            "oncompletetarget", gameObject
        ));

        iTween.RotateTo(gameObject, iTween.Hash(
            "rotation", waypointChapter4.eulerAngles,
            "time", moveTime,
            "easetype", iTween.EaseType.easeInOutSine
        ));
    }

    public void MoveToChapter5()
    {
        iTween.MoveTo(gameObject, iTween.Hash(
            "position", waypointChapter5.position,
            "time", moveTime,
            "easetype", iTween.EaseType.easeInOutSine,
            "oncompletetarget", gameObject
        ));

        iTween.RotateTo(gameObject, iTween.Hash(
            "rotation", waypointChapter5.eulerAngles,
            "time", moveTime,
            "easetype", iTween.EaseType.easeInOutSine
        ));
    }

    public void MoveToChapter6()
    {
        iTween.MoveTo(gameObject, iTween.Hash(
            "position", waypointChapter6.position,
            "time", moveTime,
            "easetype", iTween.EaseType.easeInOutSine,
            "oncompletetarget", gameObject
        ));

        iTween.RotateTo(gameObject, iTween.Hash(
            "rotation", waypointChapter6.eulerAngles,
            "time", moveTime,
            "easetype", iTween.EaseType.easeInOutSine
        ));
    }

    public void MoveToChapter7()
    {
        iTween.MoveTo(gameObject, iTween.Hash(
            "position", waypointChapter7.position,
            "time", moveTime,
            "easetype", iTween.EaseType.easeInOutSine,
            "oncompletetarget", gameObject
        ));

        iTween.RotateTo(gameObject, iTween.Hash(
            "rotation", waypointChapter7.eulerAngles,
            "time", moveTime,
            "easetype", iTween.EaseType.easeInOutSine
        ));
    }

    public void EndGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
