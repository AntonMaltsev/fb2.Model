namespace fb2.Model.Types.Enum
{
    using System.Xml.Serialization;

    /// <summary>
    ///     The items choice type 1.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlType(Namespace = "http://www.gribuser.ru/xml/fictionbook/2.0", IncludeInSchema = false)]
    public enum ItemsChoiceType1
    {
        /// <summary>
        ///     The emphasis.
        /// </summary>
        /// <remarks>
        /// </remarks>
        emphasis, 

        /// <summary>
        ///     The strong.
        /// </summary>
        /// <remarks>
        /// </remarks>
        strong, 

        /// <summary>
        ///     The style.
        /// </summary>
        /// <remarks>
        /// </remarks>
        style
    }
}