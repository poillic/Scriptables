using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scriptables
{
    public abstract class BaseVariable<T> : ScriptableObject
    {
        public T _value;
    }
}
