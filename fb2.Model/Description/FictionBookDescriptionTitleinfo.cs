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
        ///     The annotation field.
        /// </summary>
        private AnnotationType annotationField;

        /// <summary>
        ///     The author field.
        /// </summary>
        private AuthorType[] authorField;

        /// <summary>
        ///     The booktitle field.
        /// </summary>
        private TextFieldType booktitleField;

        /// <summary>
        ///     The coverpage field.
        /// </summary>
        private ImageType[] coverpageField;

        /// <summary>
        ///     The date field.
        /// </summary>
        private DateType dateField;

        /// <summary>
        ///     The genre field.
        /// </summary>
        private FictionBookDescriptionTitleinfoGenre[] genreField;

        /// <summary>
        ///     The keywords field.
        /// </summary>
        private TextFieldType keywordsField;

        /// <summary>
        ///     The lang field.
        /// </summary>
        private string langField;

        /// <summary>
        ///     The sequence field.
        /// </summary>
        private SequenceType[] sequenceField;

        /// <summary>
        ///     The srclang field.
        /// </summary>
        private string srclangField;

        /// <summary>
        ///     The translator field.
        /// </summary>
        private AuthorType[] translatorField;

        /// <summary>
        ///     The genre.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("genre")]
        public FictionBookDescriptionTitleinfoGenre[] genre
        {
            get
            {
                return this.genreField;
            }

            set
            {
                this.genreField = value;
            }
        }

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
        ///     The booktitle.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("book-title")]
        public TextFieldType booktitle
        {
            get
            {
                return this.booktitleField;
            }

            set
            {
                this.booktitleField = value;
            }
        }

        /// <summary>
        ///     The annotation.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public AnnotationType annotation
        {
            get
            {
                return this.annotationField;
            }

            set
            {
                this.annotationField = value;
            }
        }

        /// <summary>
        ///     The keywords.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public TextFieldType keywords
        {
            get
            {
                return this.keywordsField;
            }

            set
            {
                this.keywordsField = value;
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
        ///     The coverpage.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlArrayItem("image", IsNullable = false)]
        public ImageType[] coverpage
        {
            get
            {
                return this.coverpageField;
            }

            set
            {
                this.coverpageField = value;
            }
        }

        /// <summary>
        ///     The lang.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement(DataType = "language")]
        public string lang
        {
            get
            {
                return this.langField;
            }

            set
            {
                this.langField = value;
            }
        }

        /// <summary>
        ///     The srclang.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("src-lang", DataType = "language")]
        public string srclang
        {
            get
            {
                return this.srclangField;
            }

            set
            {
                this.srclangField = value;
            }
        }

        /// <summary>
        ///     The translator.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("translator")]
        public AuthorType[] translator
        {
            get
            {
                return this.translatorField;
            }

            set
            {
                this.translatorField = value;
            }
        }

        /// <summary>
        ///     The sequence.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("sequence")]
        public SequenceType[] sequence
        {
            get
            {
                return this.sequenceField;
            }

            set
            {
                this.sequenceField = value;
            }
        }
    }
}