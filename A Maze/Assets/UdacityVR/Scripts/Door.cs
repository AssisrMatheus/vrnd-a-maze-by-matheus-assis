using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject leftDoor;
    public GameObject rightDoor;

    // Declare an AudioSource named 'audioSource' and get a reference to the audio source in Start()
    public AudioSource audioSource;
    public AudioClip lockedClip;
    private AudioClip originalClip;

    // TODO: Create variables to track the gameplay states
    private bool locked = true;
    public bool opening = false;

    // TODO: Create variables to hold rotations used when animating the door opening
    private Quaternion leftDoorStartRotation;
    private Quaternion leftDoorEndRotation;
    private Quaternion rightDoorStartRotation;
    private Quaternion rightDoorEndRotation;

    // TODO: Create variables to control the speed of the interpolation when animating the door opening
    public float rotationTime = 10f;
    private float timer = 0f;

    public int rotationAngle = 45;

    void Start()
    {
        this.originalClip = this.audioSource.clip;

        // Use 'leftDoor' to get the start rotation of the 'Left_Door' game object and assign it to 'leftDoorStartRotation'
        this.leftDoorStartRotation = this.leftDoor.transform.rotation;
        // Use 'leftDoorStartRotation' and Quaternion.Euler() to set the end rotation of the 'Left_Door' game object and assign it to 'leftDoorEndRotation'
        this.leftDoorEndRotation = Quaternion.Euler(this.leftDoorStartRotation.eulerAngles + (-rotationAngle * Vector3.up));
        // Use 'rightDoor' to get the start rotation of the 'Right_Door' game object and assign it to 'rightDoorStartRotation'
        this.rightDoorStartRotation = this.rightDoor.transform.rotation;
        // Use 'rightDoorStartRotation' and Quaternion.Euler() to set the end rotation of the 'Right_Door' game object and assign it to 'rightDoorEndRotation'
        this.rightDoorEndRotation = Quaternion.Euler(this.rightDoorStartRotation.eulerAngles + (rotationAngle * Vector3.up));
    }


    void Update()
    {
        if(opening)
        {
            this.timer += (Time.deltaTime);

            // ... use Quaternion.Slerp() to interpolate from 'leftDoorStartRotation' to 'leftDoorEndRotation' by the interpolation time 'timer / rotationTime' and assign it to the 'leftDoor' rotation
            var lslerp = Quaternion.Slerp(this.leftDoorStartRotation, this.leftDoorEndRotation, this.timer);
            this.leftDoor.transform.rotation = lslerp;

            // ... use Quaternion.Slerp() to interpolate from 'rightDoorStartRotation' to 'rightDoorEndRotation' by the interpolation time 'timer / rotationTime' and assign it to the 'leftDoor' rotation
            var rslerp = Quaternion.Slerp(this.rightDoorStartRotation, this.rightDoorEndRotation, this.timer);
            this.rightDoor.transform.rotation = rslerp;
            if (this.timer >= this.rotationTime)
            {
                this.opening = false;
                this.timer = 0;
            }
        }
    }


    public void OnDoorClicked()
    {
        /// Called when the 'Left_Door' or 'Right_Door' game object is clicked
        /// - Starts opening the door if it has been unlocked
        /// - Plays an audio clip when the door starts opening

        if(!locked)
        {
            opening = true;
            this.audioSource.clip = originalClip;
            this.audioSource.Play();

            this.leftDoor.GetComponent<Collider>().enabled = false;
            this.rightDoor.GetComponent<Collider>().enabled = false;
        }
        else
        {
            //AudioSource.PlayClipAtPoint(this.lockedClip, this.transform.position);
            // For some reason the volume is really low
            this.audioSource.clip = lockedClip;
            this.audioSource.Play();
        }
    }


    public void Unlock()
    {
        /// Called from Key.OnKeyClicked(), i.e. the Key.cs script, when the 'Key' game object is clicked
        /// - Unlocks the door

        this.locked = false;
    }
}
