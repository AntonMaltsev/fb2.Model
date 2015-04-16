namespace fb2.Model.Description
{
    using System.Xml.Serialization;

    using fb2.Model.Data;
    using fb2.Model.Formating;

    /// <summary>
    ///     The fiction book description titleinfo.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlType(AnonymousType = true, Namespace = "http://www.gribuser.ru/xml/fictionbook/2.0")]
    public class FictionBookDescriptionTitleinfo
    {
        /// <summary>
        ///     The genre.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("genre")]
        public FictionBookDescriptionTitleinfoGenre[] genre { get; set; }

        /// <summary>
        ///     The author.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("author")]
        public AuthorType[] author { get; set; }

        /// <summary>
        ///     The booktitle.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("book-title")]
        public TextFieldType booktitle { get; set; }

        /// <summary>
        ///     The annotation.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public AnnotationType annotation { get; set; }

        /// <summary>
        ///     The keywords.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public TextFieldType keywords { get; set; }

        /// <summary>
        ///     The date.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public DateType date { get; set; }

        /// <summary>
        ///     The coverpage.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlArrayItem("image", IsNullable = false)]
        public ImageType[] coverpage { get; set; }

        /// <summary>
        ///     The lang.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement(DataType = "language")]
        public string lang { get; set; }

        /// <summary>
        ///     The srclang.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("src-lang", DataType = "language")]
        public string srclang { get; set; }

        /// <summary>
        ///     The translator.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("translator")]
        public AuthorType[] translator { get; set; }

        /// <summary>
        ///     The sequence.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("sequence")]
        public SequenceType[] sequence { get; set; }
    }
}