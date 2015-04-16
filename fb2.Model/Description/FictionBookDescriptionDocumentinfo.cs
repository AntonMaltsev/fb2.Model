namespace fb2.Model.Description
{
    using System.Xml.Serialization;

    using fb2.Model.Data;
    using fb2.Model.Formating;

    /// <summary>
    ///     The fiction book description documentinfo.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlType(AnonymousType = true, Namespace = "http://www.gribuser.ru/xml/fictionbook/2.0")]
    public class FictionBookDescriptionDocumentinfo
    {
        /// <summary>
        ///     The author.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("author")]
        public AuthorType[] author { get; set; }

        /// <summary>
        ///     The programused.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("program-used")]
        public TextFieldType programused { get; set; }

        /// <summary>
        ///     The date.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public DateType date { get; set; }

        /// <summary>
        ///     The srcurl.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("src-url")]
        public string[] srcurl { get; set; }

        /// <summary>
        ///     The srcocr.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("src-ocr")]
        public TextFieldType srcocr { get; set; }

        /// <summary>
        ///     The id.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement(DataType = "token")]
        public string id { get; set; }

        /// <summary>
        ///     The version.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public float version { get; set; }

        /// <summary>
        ///     The history.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public AnnotationType history { get; set; }
    }
}