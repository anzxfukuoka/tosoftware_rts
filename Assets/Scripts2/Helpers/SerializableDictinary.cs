using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SerializableDictinary<K,V>
{
    [SerializeField] public List<DictinaryPage> _dictinary = new List<DictinaryPage>();
    [System.Serializable]
    public class DictinaryPage
    {
        public K Key;
        public V Value;
    }


    public V this[K key]
    {
        get => this._dictinary.Find((x) => EqualityComparer<K>.Default.Equals(x.Key, key)).Value;
    }



}
