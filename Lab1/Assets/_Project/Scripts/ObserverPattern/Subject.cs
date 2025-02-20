using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

namespace Platformer397
{
    public abstract class Subject : MonoBehaviour
    {
        // List of Observers
        // Add and/or Remove Observers from the list
        // Notification method to notify observers
        [SerializeField] private List<IObserver> observers = new List<IObserver>();

        public void AddObserver(IObserver observer) => observers.Add(observer);

        public void RemoveObserver(IObserver observer) => observers.Remove(observer);

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.OnNotify();
            }
        }
    }
}
