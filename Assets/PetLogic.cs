﻿using UnityEngine;
using System.Collections;

public class PetLogic : MonoBehaviour {

	private float hunger = 0;
	private float tiredness = 0;
	// whether the pet needs to go to the loo
	private float excrements = 0;
	private float health = 100;
	// whether the pet needs attention or not
	private float mood = 100;

	private const float HUNGER_THRESHOLD = 50;
	private const float TIREDNESS_THRESHOLD = 50;
	private const float EXCREMENTS_THRESHOLD = 50;
	private const float HEALTH_THRESHOLD = 50;
	private const float MOOD_THRESHOLD = 50;

	private float nextUpdate = 0;

	public float updateRate;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate() {
		checkState ();

		if (Time.time > nextUpdate) {
			UpdateState();
			nextUpdate = Time.time + updateRate;
		}
	}

	void checkState() {

		if (hunger > HUNGER_THRESHOLD) {
			sendHungry();
		}

		if (tiredness > TIREDNESS_THRESHOLD) {
			sendSleepy();
		}

		if (excrements > EXCREMENTS_THRESHOLD) {
			sendExcrement();
		}

		if (health < HEALTH_THRESHOLD) {
			sendDeath();
		}

		if (mood < MOOD_THRESHOLD) {
			sendAttention();
		}

	}

	void UpdateState() {

		hunger += Random.Range(0.2, 0.5);
		tiredness += Random.Range(0.2, 0.5);
		excrements += Random.Range(0.2, 0.5);
		mood -= Random.Range(0.2, 0.5);

		if (hunger < HUNGER_THRESHOLD || mood < MOOD_THRESHOLD) {
			health -= Random.Range(0.2, 0.5);
		} else {
			health += Random.Range(0.2, 0.5);
		}

		if (mood > MOOD_THRESHOLD) {
			health += Random.Range(0.2, 0.5);
		}

	}

	void sendHungry() {
		// TODO
	}

	void sendSleepy() {
		// TODO
	}

	void sendExcrement() {
		// TODO
	}

	void sendDeath() {
		// TODO
	}

	void sendAttention() {
		// TODO
	}

	public void onFood() {
		// TODO
	}
	
	public void onAttention() {
		// TODO
	}
}
