namespace fb2.Model.Types.Enum
{
    using System.Xml.Serialization;

    /// <summary>
    ///     The items choice type.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlType(Namespace = "http://www.gribuser.ru/xml/fictionbook/2.0", IncludeInSchema = false)]
    public enum ItemsChoiceType
    {
        /// <summary>
        ///     The email.
        /// </summary>
        /// <remarks>
        /// </remarks>
        email, 

        /// <summary>
        ///     The firstname.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlEnum("first-name")]
        firstname, 

        /// <summary>
        ///     The homepage.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlEnum("home-page")]
        homepage, 

        /// <summary>
        ///     The lastname.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlEnum("last-name")]
        lastname, 

        /// <summary>
        ///     The middlename.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlEnum("middle-name")]
        middlename, 

        /// <summary>
        ///     The nickname.
        /// </summary>
        /// <remarks>
        /// </remarks>
        nickname
    }
}