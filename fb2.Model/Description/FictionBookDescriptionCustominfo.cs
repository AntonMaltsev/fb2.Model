namespace fb2.Model.Description
{
    using System.Xml.Serialization;

    using fb2.Model.Data;

    /// <summary>
    ///     The fiction book description custominfo.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlType(AnonymousType = true, Namespace = "http://www.gribuser.ru/xml/fictionbook/2.0")]
    public class FictionBookDescriptionCustominfo : TextFieldType
    {
        /// <summary>
        /// The infotype.
        /// </summary>
        /// <value>
        /// The infotype.
        /// </value>
        [XmlAttribute("info-type")]
        public string infotype { get; set; }
    }
}