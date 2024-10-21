using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scriptables
{

[CreateAssetMenu( fileName = "new " + nameof( IntVariable ), menuName = ScriptableUtils.VARIABLE_PATH + nameof( IntVariable ) )]
public class IntVariable : BaseVariable<int>
{
}
}
