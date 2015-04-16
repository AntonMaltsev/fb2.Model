namespace fb2.Model.Description
{
    using System.Xml.Serialization;

    using fb2.Model.Types;
    using fb2.Model.Types.Data;

    /// <summary>
    ///     The fiction book description documentinfo.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlType(AnonymousType = true, Namespace = "http://www.gribuser.ru/xml/fictionbook/2.0")]
    public class FictionBookDescriptionDocumentinfo
    {
        /// <summary>
        ///     The author field.
        /// </summary>
        private AuthorType[] authorField;

        /// <summary>
        ///     The date field.
        /// </summary>
        private DateType dateField;

        /// <summary>
        ///     The history field.
        /// </summary>
        private AnnotationType historyField;

        /// <summary>
        ///     The id field.
        /// </summary>
        private string idField;

        /// <summary>
        ///     The programused field.
        /// </summary>
        private TextFieldType programusedField;

        /// <summary>
        ///     The srcocr field.
        /// </summary>
        private TextFieldType srcocrField;

        /// <summary>
        ///     The srcurl field.
        /// </summary>
        private string[] srcurlField;

        /// <summary>
        ///     The version field.
        /// </summary>
        private float versionField;

        /// <summary>
        ///     The author.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("author")]
        public AuthorType[] author
        {
            get
            {
                return this.authorField;
            }

            set
            {
                this.authorField = value;
            }
        }

        /// <summary>
        ///     The programused.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("program-used")]
        public TextFieldType programused
        {
            get
            {
                return this.programusedField;
            }

            set
            {
                this.programusedField = value;
            }
        }

        /// <summary>
        ///     The date.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public DateType date
        {
            get
            {
                return this.dateField;
            }

            set
            {
                this.dateField = value;
            }
        }

        /// <summary>
        ///     The srcurl.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("src-url")]
        public string[] srcurl
        {
            get
            {
                return this.srcurlField;
            }

            set
            {
                this.srcurlField = value;
            }
        }

        /// <summary>
        ///     The srcocr.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("src-ocr")]
        public TextFieldType srcocr
        {
            get
            {
                return this.srcocrField;
            }

            set
            {
                this.srcocrField = value;
            }
        }

        /// <summary>
        ///     The id.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement(DataType = "token")]
        public string id
        {
            get
            {
                return this.idField;
            }

            set
            {
                this.idField = value;
            }
        }

        /// <summary>
        ///     The version.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public float version
        {
            get
            {
                return this.versionField;
            }

            set
            {
                this.versionField = value;
            }
        }

        /// <summary>
        ///     The history.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public AnnotationType history
        {
            get
            {
                return this.historyField;
            }

            set
            {
                this.historyField = value;
            }
        }
    }
}