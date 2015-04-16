namespace fb2.Model.Types.Enum
{
    using System.Xml.Serialization;

    /// <summary>
    ///     The items choice type 5.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlType(Namespace = "http://www.gribuser.ru/xml/fictionbook/2.0", IncludeInSchema = false)]
    public enum ItemsChoiceType5
    {
        /// <summary>
        ///     The cite.
        /// </summary>
        /// <remarks>
        /// </remarks>
        cite, 

        /// <summary>
        ///     The emptyline.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlEnum("empty-line")]
        emptyline, 

        /// <summary>
        ///     The image.
        /// </summary>
        /// <remarks>
        /// </remarks>
        image, 

        /// <summary>
        ///     The p.
        /// </summary>
        /// <remarks>
        /// </remarks>
        p, 

        /// <summary>
        ///     The poem.
        /// </summary>
        /// <remarks>
        /// </remarks>
        poem, 

        /// <summary>
        ///     The section.
        /// </summary>
        /// <remarks>
        /// </remarks>
        section, 

        /// <summary>
        ///     The subtitle.
        /// </summary>
        /// <remarks>
        /// </remarks>
        subtitle, 

        /// <summary>
        ///     The table.
        /// </summary>
        /// <remarks>
        /// </remarks>
        table
    }
}