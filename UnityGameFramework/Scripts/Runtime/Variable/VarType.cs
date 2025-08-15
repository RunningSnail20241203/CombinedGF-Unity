using System;
using GameFramework;

namespace UnityGameFramework.Runtime
{
    public sealed class VarType : Variable<Type>
    {
        public VarType()
        {
            
        }

        public static implicit operator VarType(Type value)
        {
            var varValue = ReferencePool.Acquire<VarType>();
            varValue.Value = value;
            return varValue;
        }


        public static implicit operator Type(VarType value)
        {
            return value.Value;
        }
    }
}