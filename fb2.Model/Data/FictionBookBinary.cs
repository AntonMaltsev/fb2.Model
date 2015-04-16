namespace fb2.Model.Data
{
    using System.Xml.Serialization;

    /// <summary>
    ///     The fiction book binary.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlType(AnonymousType = true, Namespace = "http://www.gribuser.ru/xml/fictionbook/2.0")]
    public class FictionBookBinary
    {
        /// <summary>
        ///     The contenttype.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlAttribute("content-type")]
        public string contenttype { get; set; }

        /// <summary>
        ///     The id.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlAttribute(DataType = "ID")]
        public string id { get; set; }

        /// <summary>
        ///     The value.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlText(DataType = "base64Binary")]
        public byte[] Value { get; set; }
    }
}