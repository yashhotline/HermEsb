namespace Mrwesb.Builder.Types.Builders
{
    using System;
    using System.Reflection.Emit;

    /// <summary>
    /// 
    /// </summary>
    public interface ITypeBuilder
    {
        /// <summary>
        /// Creates the type from.
        /// </summary>
        /// <param name="t">The t.</param>
        /// <returns></returns>
        Type CreateTypeFrom(Type t);
    }
}