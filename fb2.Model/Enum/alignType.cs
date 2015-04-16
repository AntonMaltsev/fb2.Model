namespace fb2.Model.Enum
{
    using System.Xml.Serialization;

    /// <summary>
    ///     The align type.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlType(Namespace = "http://www.gribuser.ru/xml/fictionbook/2.0")]
    public enum AlignType
    {
        /// <summary>
        ///     The left.
        /// </summary>
        /// <remarks>
        /// </remarks>
        left, 

        /// <summary>
        ///     The right.
        /// </summary>
        /// <remarks>
        /// </remarks>
        right, 

        /// <summary>
        ///     The center.
        /// </summary>
        /// <remarks>
        /// </remarks>
        center
    }
}