using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scriptables
{

[CreateAssetMenu( fileName = "new " + nameof( FloatVariable ), menuName = ScriptableUtils.VARIABLE_PATH + nameof( FloatVariable ) )]
public class FloatVariable : BaseVariable<float>
{
}
}
