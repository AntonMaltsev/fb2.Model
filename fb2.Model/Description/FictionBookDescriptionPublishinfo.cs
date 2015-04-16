namespace fb2.Model.Description
{
    using System.Xml.Serialization;

    using fb2.Model.Data;

    /// <summary>
    ///     The fiction book description publishinfo.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlType(AnonymousType = true, Namespace = "http://www.gribuser.ru/xml/fictionbook/2.0")]
    public class FictionBookDescriptionPublishinfo
    {
        /// <summary>
        ///     The bookname.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("book-name")]
        public TextFieldType bookname { get; set; }

        /// <summary>
        ///     The publisher.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public TextFieldType publisher { get; set; }

        /// <summary>
        ///     The city.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public TextFieldType city { get; set; }

        /// <summary>
        ///     The year.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement(DataType = "gYear")]
        public string year { get; set; }

        /// <summary>
        ///     The isbn.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public TextFieldType isbn { get; set; }

        /// <summary>
        ///     The sequence.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("sequence")]
        public SequenceType[] sequence { get; set; }
    }
}