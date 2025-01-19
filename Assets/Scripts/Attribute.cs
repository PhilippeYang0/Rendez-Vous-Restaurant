using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public class Attributes
{

    [SerializeField] private Dictionary<Adjective,uint> _attributes;
    private List<Adjective> _orderedAdjectives;
    public UnityEvent AttributesUpdateEvent = new UnityEvent();
    public int Count => _orderedAdjectives.Count;
    public uint Value
    {
        get
        {
            uint value = 0;
            foreach (uint key in _orderedAdjectives)
            {
                value += key;
            }
            return value;
        }
    }

    public Adjective this[int index]
    {
        get
        {
            return _orderedAdjectives[index];
        }
    }

    public uint Contains(Adjective adjective)
    {
        if (_attributes.TryGetValue(adjective,out uint value))
        {
            return value;
        }
        return 0;
    }
    public void Add(Adjective adjective, uint level = 1)
    {
        if (level == 0)
        {
            Debug.Log("Trying to add an attribute of level 0");
            return;
        }
        if (_attributes.ContainsKey(adjective))
        {
            _attributes[adjective] += level;
        }
        else
        {
            _attributes.Add(adjective,level);
            _orderedAdjectives.Add(adjective);
        }
        AttributesUpdateEvent.Invoke();
    }

    public void Remove(Adjective adjective)
    {
        _attributes.Remove(adjective);
        _orderedAdjectives.Remove(adjective);
        AttributesUpdateEvent.Invoke();
    }
    public void Clear()
    {
        _attributes.Clear();
        _orderedAdjectives.Clear();
        AttributesUpdateEvent.Invoke();
    }

    public void Reverse()
    {
        _orderedAdjectives.Reverse();
        AttributesUpdateEvent.Invoke();
    }
    public void Sort(Comparer<Adjective> comparer)
    {
        _orderedAdjectives.Sort(comparer);
        AttributesUpdateEvent.Invoke();
    }
    public static int CompareByAdjective(Adjective a, Adjective b)
    {
        return string.Compare(a.ToString(), b.ToString());
    }

    public int CompareByLevel(Adjective a, Adjective b)
    {
        int compare = _attributes[a].CompareTo(_attributes[b]);
        if(compare == 0)
        {
            return CompareByAdjective(a, b);
        }
        return compare;
    }

    public void SortBySelected(List<Adjective> adjectives)
    {
        _orderedAdjectives = _orderedAdjectives
                            .GroupBy(adjective => adjectives.Contains(adjective))
                            .OrderByDescending(g => g.Key)
                            .Select(g => g.First())
                            .OrderByDescending(g => _attributes[g])
                            .ToList();
    }
}