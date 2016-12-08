using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {


	private CharacterController myCC;
	private Vector3 moveDirection = Vector3.zero;
	public float moveSpeed = 5;
	public float rotateSpeed = 1;

	void Start () {
			myCC = GetComponent<CharacterController> ();
			}
	void Rotate (float _myInput) 
	{
			transform.Rotate (0, _myInput*rotateSpeed, 0);
		}
		
//			void Move (float _myInput) 
//			{
//		moveVector.x =moveSpeed* _myInput;
//			//moveVector = transform.TransformDirection (moveVector*moveSpeed*Time.deltaTime);
//		character.
//			}
		
			void Update () {
					//Move (Input.GetAxis ("Vertical"));

		moveDirection = new Vector3(Input.GetAxis("Vertical"),0,0);
		moveDirection = transform.TransformDirection (moveDirection*moveSpeed*Time.deltaTime);
					Rotate (Input.GetAxis ("Horizontal"));
		myCC.Move (moveDirection);
				}
		}
