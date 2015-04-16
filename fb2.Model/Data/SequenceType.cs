namespace fb2.Model.Data
{
    using System.Xml.Schema;
    using System.Xml.Serialization;

    /// <summary>
    ///     The sequence type.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlType(Namespace = "http://www.gribuser.ru/xml/fictionbook/2.0")]
    public class SequenceType
    {
        /// <summary>
        ///     The sequence.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("sequence")]
        public SequenceType[] sequence { get; set; }

        /// <summary>
        ///     The name.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlAttribute]
        public string name { get; set; }

        /// <summary>
        ///     The number.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlAttribute(DataType = "integer")]
        public string number { get; set; }

        /// <summary>
        ///     The lang.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlAttribute(Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang { get; set; }
    }
}