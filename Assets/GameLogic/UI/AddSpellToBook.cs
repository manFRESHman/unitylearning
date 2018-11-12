﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddSpellToBook : MonoBehaviour {

	public GameObject templateEntry;
	private Dictionary<string, SpellInit> spells = new Dictionary<string, SpellInit>();
	private Dictionary<string, SpellBookEntry> entries = new Dictionary<string, SpellBookEntry>();
	public void addSpellBookEntry (string name, SpellInit spell) {
		GameObject newEntry = Instantiate (templateEntry)  as GameObject;
		newEntry.GetComponent<SpellBookEntry>().setText (name);
		newEntry.transform.SetParent (gameObject.transform, false);
		spells.Add (name, spell);
		entries.Add (name, newEntry.GetComponent<SpellBookEntry>());
	}

	public string Search (string prename){
		foreach (string key in spells.Keys) {
			if (key.StartsWith (prename)) return key;
		}
		return null;
	}

	public SpellInit ReturnInit (string name) {
		return spells[name];
	}
}
